using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public partial class  Html
    {
        public string RenderAngularInput(Column column, string tableName)
        {
            return string.Format(@"<input type=""text"" ng-model=""{0}.{1}""/>", tableName, column.Name);
        }

        public string RenderAngularSaveButton()
        {
            return @"<button class=""btn btn-success"" ng-click=""save()"">Save</button>";
        }
    }
}
