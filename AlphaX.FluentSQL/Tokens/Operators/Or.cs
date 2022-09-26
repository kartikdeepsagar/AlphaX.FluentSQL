namespace AlphaX.FluentSQL.Tokens
{
    public class Or : QueryToken
    {
        public Or(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.OR;
        }
    }
}
