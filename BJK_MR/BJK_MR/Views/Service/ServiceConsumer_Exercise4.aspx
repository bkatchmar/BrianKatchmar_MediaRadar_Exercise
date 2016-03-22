<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<!DOCTYPE html>
<!-- Special Thanks to DataTables for the cool jQuery plugin to accomplish sorting and paging, why re-invent the wheel? - http://www.datatables.net/ -->
<html>
    <head id="Head1" runat="server">
        <title>ServiceConsumer</title>
        <link rel="stylesheet" href="/Content/reset.css" />
        <link rel="stylesheet" href="http://cdn.datatables.net/1.10.11/css/jquery.dataTables.min.css" />
    </head>
    <body>
        <table id="example" class="display" cellspacing="0" width="100%">
            <thead>
                <tr>
                    <th>Brand Name</th>
                    <th>Total Coverage Amount</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>Brand Name</th>
                    <th>Total Coverage Amount</th>
                </tr>
            </tfoot>
            <tbody>
                <% foreach (var ad in Model) { %>
                    <tr>
                        <td><%= ad.BrandName%></td>
                        <td><%= ad.TotalCoverage%></td>
                    </tr>
                <% } %>
            </tbody>
        </table>
    </body>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>
    <script src="http://cdn.datatables.net/1.10.11/js/jquery.dataTables.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        jQuery(document).ready(function () {
            var table = jQuery('table#example').DataTable();
            table.order([1, "desc"], [0, "asc"]).draw()
        });
    </script>
</html>