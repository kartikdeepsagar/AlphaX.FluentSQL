using System.Collections.Generic;
using System.Text;
using AlphaX.FluentSQL.Tokens;

namespace AlphaX.FluentSQL
{
    internal class QueryContext : IQueryContext
    {
        public List<QueryToken> _tokens;

        public QueryContext()
        {
            _tokens = new List<QueryToken>();
        }

        /// <summary>
        /// Builds and returns the current query.
        /// </summary>
        /// <returns></returns>
        public string BuildQuery()
        {
            var stringBuilder = new StringBuilder();

            _tokens.ForEach(token =>
            {
                stringBuilder.Append(token.GetValue());
                if(token is NextLine)
                    stringBuilder.AppendLine();
                else
                    stringBuilder.Append(Token.WHITESPACE);
            });

            return stringBuilder.ToString().Trim();
        }

        /// <summary>
        /// Appends a token to this context
        /// </summary>
        /// <param name="token"></param>
        public void AppendToken(QueryToken token)
        {
            _tokens.Add(token);
        }
    }
}
