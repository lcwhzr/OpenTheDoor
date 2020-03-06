using System;

namespace OpenTheDoor.SSO {

    public class AuthorizationServer { 
        private string connectionStrings; 
        public AuthorizationServer(string connectionStrings) { 
            this.connectionStrings = connectionStrings; 
        }
        public bool addConfig() {
            createDatabase();             
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