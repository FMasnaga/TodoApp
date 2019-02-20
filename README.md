<h1>Project title</h1>
<p>TodoApp is a scheduling web application that allows the users to create, update, and delete a todo-item. A todo-item consists of description and date when TodoItem will be performed. All todo-items are listed on the dashboard and sorted by date.</p>


<h1>Motivation</h1>
The purpose of this app is to show CRUD operation, synchronous backend webAPI, database connection, front-end and back-end interaction with REST. 

<h1>Screenshots</h1>
<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/dashboard.png">
<br/>
<br/>
<br/>
<br/>
<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/update.png">


<h1>Tech/framework used</h1>
<ul>
  <li>C#/.net</li>
  <li>SQLITE</li>
  <li>EntityFramework</li>
  <li>Angular</li>
  <li>Bootstrap</li>
  <li>HTML & CSS</li>
</ul>


<h1>Features</h1>
<ul>
  <li>CRUD operation</li>
  <li>Synchronous and scalable application</li>
  <li>Responsive front-end for create and delete operation</li>
</ul>

<h1>Installation, Build, and Deploy</h1>
<p>Dotnet and angular installation are required to run this application. Below are steps to install them.</p>
<ul>
	<li>Install dotnet core version 2.1 or later from here https://dotnet.microsoft.com/download</li>
	<li>open terminal or command prompt to Install a package manager for Node.js by using this command "npm install"</li>
	<li>Install angular version 7 or later by using this command "Install npm install -g @angular/cli"</li>
</ul>
<br/>
<br/>
<p>After dotnet and angular are installed, below are steps to build and deploy this application.</p>
<ol>
	<li>Clone TodoApp from this link https://github.com/FMasnaga/TodoApp.git</li>
	<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/clone.png">
	<br/>
	<br/>
	<li>Open Terminal or Command Prompt, navigate to TODO.API sub-folder</li>
	<li>Build database migration by using this command "dotnet ef migrations add InitialCreate"</li>
	<li>Update database by using this command "dotnet ef database update"</li>
	<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/database.png">
	<br/>
	<br/>
	<li>run the api by using this command "dotnet watch run"</li>
	<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/dotnetrun.png">
	<br/>
	<br/>
	<li>open a new terminal and navigate to TODO-SPA sub-folder</li>
	<li>Now, run the front end application by using this command "ng serve --o" </li>
	<img src="https://github.com/FMasnaga/TodoApp/blob/master/img/angular.png">
</ol>
<br/>
  
<h1>Contribute</h1>
<p>Below are list of things you can contribute or improve this application:</p>
<ul>
  <li>Improve UI</li>
  <li>Use Modal for update operation to make this application a Single Page Application</li>
  <li>Add User SignUp and Login function</li>
</ul>
