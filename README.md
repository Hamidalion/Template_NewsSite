# Template_NewsSite

## Acquaintance ##


##### Purpose #####


### Step 1 ###
1. Create solution
2. Create ASP.NET Core Web Application (Template EMPTY or MVC)
3. Create derictories and init files as: _Layout, _ViewStart, _ViewImports.cshtml and etc.
4. Dawnload html template from https://html5up.net/
5. Dawnload CKEditor
6. Transfer of code and files from a template
7. Transfer CKEditor in wwwroot/js/
8. Split main html blocks in different files (as CssPartial, )

### Step 2 ###
1. Add NG-packets:
	-Microsoft.VisualStudio.Web.CodeGeneration.Design - for generation Controllers and View
	-Microsoft.Extensions.Logging.Debug - for logging debug
	-Microsoft.EntityFrameworkCore - for work with Dbase
	-Microsoft.EntityFrameworkCore.SqlServer - for use MySQL 
	-Microsoft.EntityFrameworkCore.Design - for work with Dbase
	-Microsoft.AspNetCore.Identity.EntityFrameworkCore - for authentication & authorization
2. Register services in Startup.sc in Configureservices
3. Add new middleware app in Startup.sc in Configure
4. SASS style compiller in CSS(main.scss->webcompiller-> then delete maim.css), 
	then in compillercofig.json change to "outputFile": "wwwroot/css/main.css",
	then command Save and new main.css and main.min.css was created.
5. Bind some JS-file in one. as like as with css. (Open wwwroot/JS -> select 2 or more files->Binder and minifire)
	then delete created file and open bundleconfig.json and set "outputFileName": "wwwroot/js/scripts.js", and add used js-files
	ATTANSION! library JQuery mast be in first places.
6. Create HomeController.
7. Create View for home/index

### Step 3 ###
1. Delete apsettings.json/appsettings.Development.json.
2. Create appsettings.staging.json and appsettings.prodaction.json files.
3. Change apsettings.json 
4. Create Config.cs with properties of apsettings.json 
5. Add our owned apsettings.json file in Startup.sc
6. Add new entity in Domain as: EntityBase =>  NewsItem => TextField
7. Create Db Context
8. Add Repositoty (Interface and his implementation)
9. 


### End ###