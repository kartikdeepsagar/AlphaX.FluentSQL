namespace AlphaX.FluentSQL.Tokens
{
    public class And : QueryToken
    {
        public And(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.AND;
        }
    }
}
