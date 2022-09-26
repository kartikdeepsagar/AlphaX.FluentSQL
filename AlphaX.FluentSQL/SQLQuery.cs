using AlphaX.FluentSQL.Tokens;

namespace AlphaX.FluentSQL
{
    public static class SQLQuery
    {
        public static Select Select 
        { 
            get
            {
                var queryContext = new QueryContext();
                return new Select(queryContext);
            }
        }

        public static Delete Delete
        {
            get
            {
                var queryContext = new QueryContext();
                return new Delete(queryContext);
            }
        }

        public static All All(this Select select)
        {
            return new All(select.Context);
        }

        public static Columns Columns(this Select select, params string[] fields)
        {
            return new Columns(select.Context, fields);
        }

        public static From From(this All all)
        {
            return new From(all.Context);
        }

        public static From From(this Delete delete)
        {
            return new From(delete.Context);
        }

        public static From From(this Columns all)
        {
            return new From(all.Context);
        }

        public static Table Table(this From from, string table)
        {
            return new Table(from.Context, table);
        }

        public static Where Where(this Table table)
        {
            return new Where(table.Context);
        }

        public static Column Column(this Where where, string columnName)
        {
            return new Column(where.Context, columnName);
        }

        public static Column Column(this And and, string columnName)
        {
            return new Column(and.Context, columnName);
        }

        public static Column Column(this Or or, string columnName)
        {
            return new Column(or.Context, columnName);
        }

        #region Equals
        public static EqualsTo EqualsTo(this Column column, string value)
        {
            return new EqualsTo(column.Context, value);
        }

        public static And And(this EqualsTo equals)
        {
            return new And(equals.Context);
        }

        public static Or Or(this EqualsTo equals)
        {
            return new Or(equals.Context);
        }
        #endregion

        public static T NextLine<T>(this T token) where T : QueryToken
        {
            _ = new NextLine(token.Context);
            return token;
        }

        /// <summary>
        /// Gets the current query.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string ToSQL(this QueryToken token)
        {
            return token.Context.BuildQuery();
        }
    }
}
