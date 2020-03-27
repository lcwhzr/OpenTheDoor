using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Jose;

namespace Core.SSO
{
    public class JWTService
    {
        public const int ACCESS_TOKEN_EXPIRY = 1300819380;
        public const string PRIVATE_KEY = "../public/openthedoor.p12";

        public JWTService()
        {
        }

        public string JWTGenerate(string userIdentifier, string userEmail)
        {
            var payload = new Dictionary<string, object>()
            {
                { "sub", userIdentifier },
                { "email", userEmail },
                { "exp", ACCESS_TOKEN_EXPIRY }
            };

            /**
             *  Actuellement c'est inscrit en dur dans le code,
             *  mais par la suite, dans la documentation nous indiquerons
             *  comment le développeur devra générer sa clé privé et son certificat.
             *  Et il devra mettre toutes les informations sensibles tels que :
             *  le chemin de la clé privée et le mot de passe de la clé privé
             *  en variable d'environnement.
             */
            var privateKey = new X509Certificate2(PRIVATE_KEY, "openthedoor").GetRSAPrivateKey();

            return JWT.Encode(payload, privateKey, JwsAlgorithm.RS256);
        }

        public string JWTDecode(string token)
        {
            var privateKey = new X509Certificate2(PRIVATE_KEY, "openthedoor").GetRSAPrivateKey();

            return JWT.Decode(token, privateKey, JwsAlgorithm.RS256);
        }
    }
}
