<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<BJK_MR.Models.Containers.AdServiceContainer>" %>
<!DOCTYPE html>
<!-- Special Thanks to DataTables for the cool jQuery plugin to accomplish sorting and paging, why re-invent the wheel? - http://www.datatables.net/ -->
<html>
    <head runat="server">
        <title>ServiceConsumer</title>
        <link rel="stylesheet" href="/Content/reset.css" />
        <link rel="stylesheet" href="http://cdn.datatables.net/1.10.11/css/jquery.dataTables.min.css" />
    </head>
    <body>
        <table id="example" class="display" cellspacing="0" width="100%">
            <thead>
                <tr>
                    <th>Ad ID</th>
                    <th>Brand ID</th>
                    <th>Brand Name</th>
                    <th>Num Pages</th>
                    <th>Position</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>Ad ID</th>
                    <th>Brand ID</th>
                    <th>Brand Name</th>
                    <th>Num Pages</th>
                    <th>Position</th>
                </tr>
            </tfoot>
            <tbody>
                <% foreach (var ad in Model.Ads) { %>
                    <tr>
                        <td><%= ad.AdId %></td>
                        <td><%= ad.Brand.BrandId %></td>
                        <td><%= ad.Brand.BrandName %></td>
                        <td><%= ad.NumPages %></td>
                        <td><%= ad.Position %></td>
                    </tr>
                <% } %>
            </tbody>
        </table>
    </body>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>
    <script src="http://cdn.datatables.net/1.10.11/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <!-- Default sort should be by brand name alphabetically. -->
    <% if (Model.ExerciseNumber == BJK_MR.Models.Containers.ExerciseNumber.EXERCISE_1 || Model.ExerciseNumber == BJK_MR.Models.Containers.ExerciseNumber.EXERCISE_2) {%>
        <script type="text/javascript">
            jQuery(document).ready(function () {
                jQuery('table#example').DataTable({
                    "order": [[2, "asc"]]
                });
            });
        </script>
    <% } else if (Model.ExerciseNumber == BJK_MR.Models.Containers.ExerciseNumber.EXERCISE_3) { %>
        <script type="text/javascript">
            jQuery(document).ready(function () {
                var table = jQuery('table#example').DataTable();
                table.order([3, "desc"],[2, "asc"]).draw()
            });
        </script>
    <% } %>
</html>