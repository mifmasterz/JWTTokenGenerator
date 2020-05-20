using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using JWT.Algorithms;
using JWT;
using JWT.Serializers;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace GHIElectronics.TinyCLR.Tools.JWTGenerator
{
    public class TokenGenerator
    {
        public static string GenerateJWTToken(string projectId, DateTime issueAt, DateTime expired, string rsaPrivateKey)
        {
            var rsaParams = GetRsaParameters(rsaPrivateKey);
            var encoder = GetRS256JWTEncoder(rsaParams);
            var iat =  ((DateTimeOffset)issueAt.ToUniversalTime()).ToUnixTimeSeconds();
            var exp = ((DateTimeOffset)expired.ToUniversalTime()).ToUnixTimeSeconds();

            // create the payload according to your need
            var payload = new Dictionary<string, object>
        {

            { "iat", iat},
            { "aud", projectId },
            { "exp", exp},

            // and other key-values 
        };

            // add headers. 'alg' and 'typ' key-values are added automatically.
            var header = new Dictionary<string, object>
        {
            //{ "{header_key}", "{your_private_key_id}" },
        };

            var token = encoder.Encode(header, payload, new byte[0]);

            return token;
        }

        private static IJwtEncoder GetRS256JWTEncoder(RSAParameters rsaParams)
        {
            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(rsaParams);

            var algorithm = new RS256Algorithm(csp, csp);
            var serializer = new JsonNetSerializer();
            var urlEncoder = new JwtBase64UrlEncoder();
            var encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            return encoder;
        }

        private static RSAParameters GetRsaParameters(string rsaPrivateKey)
        {
            var byteArray = Encoding.ASCII.GetBytes(rsaPrivateKey);
            using (var ms = new MemoryStream(byteArray))
            {
                using (var sr = new StreamReader(ms))
                {
                    // use Bouncy Castle to convert the private key to RSA parameters
                    var pemReader = new PemReader(sr);
                    var keyPair = pemReader.ReadObject() as AsymmetricCipherKeyPair;
                    return DotNetUtilities.ToRSAParameters(keyPair.Private as RsaPrivateCrtKeyParameters);
                }
            }
        }
       
    }
}
