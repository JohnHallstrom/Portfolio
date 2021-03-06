#  Database manager for bookstores

![image](https://user-images.githubusercontent.com/70512727/110217776-431c2e00-7eb6-11eb-9645-30bfca286042.png)

### Description

> Setting up the project: 

- Start Visual Studio and press 'Clone a reoisitory' on the start page.
- Enter the URL for the project's GitHub page, select where to store it locally and press 'Clone'.
- Open Solution Explorer and double click "Databas - Latioration 3.sln"

> Setting up the Databse:
- Start SQL Server Management Studio (SSMS) and connect to localhost.
- In 'Object Explorer', expand the 'localhost' server and right-click on 'Databases' and choose 'Restore Database...'.
- In the 'General' tab, select 'Device:' as the source for the restoration, then click the 'three small dots' button on the very right.
- Select 'File' as the 'Backup media type' and press 'Add'.
- Navigate to the 'Bokhandel.bak' file, select it and press 'OK' 
  (If you can not access the Visual Studio project directory, try placing the database file in a directory SSMS has access to, like the root of your disk)
- Once back in the 'Select backup devices' page, press 'OK', followed by 'OK' on the next page.

> Running the program:
- Now that everything has been set up, you are now ready to use the program as intended!
