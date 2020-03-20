using System;

namespace OpenTheDoor.Core.SSO
{
    public  class AuthorizationServer
    { 
        private string connectionString;
        private SSOContext sSOContext;

        public AuthorizationServer(string connectionString) { 
            this.connectionString = connectionString;
        }

        public bool addConfig() {
            sSOContext = new SSOContext(connectionString);

            //check if we can access to the database             
            //call fonction the database,             
            //if ok call fonction to create table from models              
            return true;             
            //else retrun false          
        }

        private  bool createDatabase()         
        {             
            //if database is here or table are here with model             
            return  true;         
        }
    } 
}


