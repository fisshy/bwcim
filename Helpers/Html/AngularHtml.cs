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
            var angularModel = string.Concat("{{", tableName, ".", column.Name, "}}");

            if (column.InPrimaryKey)
            {
                return string.Format(@"<span>{2}</span>", tableName, column.Name, angularModel);
            }

            switch (column.DataType.SqlDataType)
            {
                case SqlDataType.Time:
                case SqlDataType.Timestamp:
                case SqlDataType.SmallDateTime:
                case SqlDataType.Date:
                case SqlDataType.DateTime:
                case SqlDataType.DateTime2:
                case SqlDataType.DateTimeOffset:
                    var angularDateModel = string.Concat("{{", tableName, ".", column.Name, "  | date:'yyyy-MM-dd HH:mm'}}");
                    return string.Format(@"<a onaftersave=""saveColumn({0})"" editable-date=""{0}.{1}"">{2}</a>", tableName, column.Name, angularDateModel);
                case SqlDataType.SmallMoney:
                case SqlDataType.TinyInt:
                case SqlDataType.BigInt:
                case SqlDataType.SmallInt:
                case SqlDataType.Bit:
                case SqlDataType.Int:
                case SqlDataType.Money:
                case SqlDataType.Decimal:
                case SqlDataType.Float:
                case SqlDataType.Numeric:
                    return string.Format(@"<a onaftersave=""saveColumn({0})"" editable-number=""{0}.{1}"">{2}</a>", tableName, column.Name, angularModel);
                case SqlDataType.VarBinary:
                case SqlDataType.VarBinaryMax:
                case SqlDataType.VarChar:
                case SqlDataType.VarCharMax:
                case SqlDataType.Variant:
                case SqlDataType.Xml:
                case SqlDataType.Text:
                case SqlDataType.UniqueIdentifier:
                case SqlDataType.Char:
                case SqlDataType.NChar:
                case SqlDataType.NText:
                case SqlDataType.NVarChar:
                case SqlDataType.NVarCharMax:
                    return string.Format(@"<a onaftersave=""saveColumn({0})"" editable-text=""{0}.{1}"">{2}</a>", tableName, column.Name, angularModel);
                default:
                    return string.Format(@"<a onaftersave=""saveColumn({0})"" editable-text=""{0}.{1}"">{2}</a>", tableName, column.Name, angularModel);
            }
        }

        public string RenderAngularSaveButton()
        {
            return @"<button class=""btn btn-success"" ng-click=""save()"">Save</button>";
        }
    }
}
