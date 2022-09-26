namespace AlphaX.FluentSQL.Tokens
{
    public class From : QueryToken
    {
        public From(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.FROM;
        }
    }
}
