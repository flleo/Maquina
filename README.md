# Maquina
c#

Usamos el Package Manager Console, para a partir de clases modelo, crear la base de datos



Buscamos en el buscador de .net «Package Manager Console» o Consola de Administrador de Paquetes
Add a new migration by typing the following into the Package Manager Console(PMC):
add-migration Files, se puede llamar como quieras. Aqui se crea el codigo para crear la base de datos

Si no nos deja, primero picamos
Enable-Migrations


Run the migration by typing the following into the PMC.
update-database, aqui hacemos que se ejecute el Files creado


Vemos que se nos genera , la carpeta Migrations y dentro de ella la clase :

202008250944395_Files.cs	 (Las tablas de la base de datos)
Configuration.cs 		(La configuracion del contexto, donde se encuentra le DbContext)


Una vez creado las clases modelo, creamos los constructores con sus vistas automaticas.
