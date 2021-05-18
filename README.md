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
8. Split main html blocks in different files (as CssPartial, ).

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
7. Create View for home/index.

### Step 3 ###
1. Delete apsettings.json/appsettings.Development.json.
2. Create appsettings.staging.json and appsettings.prodaction.json files.
3. Change apsettings.json 
4. Create Config.cs with properties of apsettings.json 
5. Add our owned apsettings.json file in Startup.sc
6. Add new entity in Domain as: EntityBase =>  NewsItem => TextField
7. Create Db Context
8. Add Repositoty (Interface and his implementation)
9. Create DataManager for helpful use repository code
10.Add new functional app as like as servises in Startup.sc
11.Add database context in Startup.sc
12.Add IConfigure setups
13.Add Migration.

### Step 4 ###
1. Add admin area in Startup 
2. Create AdminAreaAuthorization.cs class witch one check atribute of controller and add him some filters.
3. Add settings to Startup for services.AddControllersWithViews policy of adminarea
4. Set admin area policy in Startup.cs
5. Create LoginViewModel
6. Add AccountController
7. Add HomeController and his view in AdminArea
8. Add TextFieldContoller and his view in AdminArea
9. Add Extension for cutting word "Controller"
10.Create NewsItemsController in AdminArea, and add action Edit(almost this is create), Delete
11.Add Edit View.

### Step 5 ###
1. Correct headerPartial view
2. Delete unused items in footerPartial
3. Create action in HomeController as Index and Contacts
4. Go to Index.cshtml add view 
5. Go to Contacts.cshtml add view 
6. Add NewsItems controller and Index action
7. Add Index view 
8. Add Swah view
9. Add SidebarViewComponent this is like controller
10.Add view for SidebarViewComponent

### Step 5 ###
1. Set publishib properties
2. Publish

### End ###