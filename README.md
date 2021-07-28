# Rufeng Ma's Final project: Hotel Management System
This is a Hotel Management System
-- Development system: macOS</p>
-- Front end: MVC</p>
-- Backend: .Net 5</p>
<h3>Before Run this project in VS,some suggestions</h3></p>
1. If you are on a Windows system, please go to <b>appsetting.json</b> to change the Connection String to your server IP.</p>
2. Run sql server</p>
3. Migration once.</p>
macOS==></p>
-- Make sure your Azure and SQL server are running.</p>
-- terminal: cd HotelManagement.MVC </p>
-- terminal: dotnet ef migrations add initialTables --project ../Infrastructure/Infrastructure.csproj</p>
-- VS: check <b>migration</b> file</p>
-- terminal: dotnet ef database update</p>
4.Run the <b>inserteData.sql, the data come from MovieShop project</b> file in your Azure Data Studio or sql server management studio (SSMS).</p>

<h3>Schema</h3>
<img src="Schema.png" height="400">
</p>
<h3>Homepage</h3>
<img src="Homepage.png" height="300">
</p>
<h3>Example Of Add/Delete/Update/Search</h3>
<img src="Example.png" height="350">
</p>
<h3>Customer Detail Page</h3>
<img src="CustomerDetails.png" height="400">
