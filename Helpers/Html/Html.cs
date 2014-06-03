using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TextTemplating;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Smo;

namespace Helpers
{
    public partial class Html : TextTransformation
    {
        
        public string RenderTableHeader(ColumnCollection columns)
        {
            var sb = new StringBuilder();
            sb.Append("<thead>");
            sb.Append("<tr>");
            foreach (var column in columns)
            {
                var c = (Column)column;

                sb.AppendFormat("<th>{0}</th>", c.Name);
            }
            sb.Append("</tr>");
            sb.Append("</thead>");

            return sb.ToString().Trim();
        }

        public string RenderTableBodyWithAngularInput(ColumnCollection columns, string tableName)
        {
            var sb = new StringBuilder();
            sb.Append("<tbody>");
            sb.AppendFormat(@"<tr ng-repeat=""{0} in {0}s"">", tableName);
            foreach (var column in columns)
            {
                var c = (Column)column;

                sb.AppendFormat("<td>{0}</td>", RenderAngularInput(c, tableName));
            }
            sb.Append("</tr>");
            sb.Append("</tbody>");
            return sb.ToString().Trim();
        }

        public override string TransformText()
        {
            throw new NotImplementedException();
        }
    }
}
