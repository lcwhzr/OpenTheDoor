
Config de la base de donnees 
Il faut modifier le fichier API/appsettings.js 
et changer le champ suivant 
  	ConnectionStrings => DefaultConnection => Data Source=<DataBaseName.db>


Pour faire les migrations 
dotnet ef  migrations add <Nom de la Migration>
 dotnet ef database update

 Si vous devez supprimer la base 
 dotnet ef database drop

