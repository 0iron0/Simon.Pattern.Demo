using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.MethodTemplate
{
    public abstract class SqlBuilderBase
    {
        public string BuildSqlString(string tableName, string field, string value)
        {
            StringBuilder sb = new StringBuilder(256);
            sb.Append("Select *");
            sb.Append(" From " + tableName);
            sb.Append(" Where " + field + "=" + GetDateString(value));
            return sb.ToString();
        }

        public abstract string GetDateString(string value);
    }

    public class SqlBuilderForAccess : SqlBuilderBase
    {

        public override string GetDateString(string value)
        {
            return string.Format("#{0}#", value);
        }
    }

    public class SqlBuilderForSqlServer : SqlBuilderBase
    {

        public override string GetDateString(string value)
        {
            return string.Format("'{0}'", value);
        }
    }
}
