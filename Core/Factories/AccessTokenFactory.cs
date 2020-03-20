using Jose;
using Core.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Core.Factories
{
    public class AccessTokenFactory
    {
        public const int ACCESS_TOKEN_EXPIRY = 1300819380;
        public const string PRIVATE_KEY = "../public/openthedoor.p12";

        public AccesToken Create(string userIdentifier, string userEmail, Service service, List<Scope> scopes)
        {
            string token = AccessTokenGenerate(userIdentifier, userEmail);

            return new AccesToken(
                token,
                System.DateTime.Now.Date.AddHours(1),
                userIdentifier,
                service,
                scopes
            );
        }

        private string AccessTokenGenerate(string userIdentifier, string userEmail)
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
    }
}
