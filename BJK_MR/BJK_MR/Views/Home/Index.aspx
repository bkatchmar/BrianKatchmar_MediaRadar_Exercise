<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<BJK_MR.Models.Containers.PersonContainer>" %>
<!doctype html>
<html lang="en">
    <head runat="server">
        <title>Brian J Katchmar - Media Radar Test</title>
        <link rel="stylesheet" href="/Content/reset.css" />
    </head>
    <body>
        <% foreach (var person in Model.AllPeople) { %>
            <div><%= person.ToString() %></div>
        <% } %>
    </body>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>
</html>