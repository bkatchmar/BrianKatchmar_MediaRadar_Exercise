<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<BJK_MR.Models.Containers.PersonContainer>" %>
<!doctype html>
<html lang="en">
    <head runat="server">
        <title>Brian J Katchmar - Media Radar Test</title>
        <link rel="stylesheet" href="/Content/reset.css" /> 
    </head>
    <body>
        <% foreach (var person in Model.AllPeople) { %>
            <div><%= person.FirstName %>&nbsp;<%= person.LastName %></div>
        <% } %>
    </body>
</html>