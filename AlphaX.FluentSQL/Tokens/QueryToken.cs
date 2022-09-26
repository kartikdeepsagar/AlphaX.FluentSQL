namespace AlphaX.FluentSQL.Tokens
{
    public abstract class QueryToken
    {
        internal IQueryContext Context { get; }

        public QueryToken(IQueryContext context)
        {
            Context = context;
            (Context as QueryContext).AppendToken(this);
        }

        public abstract string GetValue();
    }
}
