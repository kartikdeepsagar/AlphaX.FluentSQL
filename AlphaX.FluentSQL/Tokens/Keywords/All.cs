namespace AlphaX.FluentSQL.Tokens
{
    public class All : QueryToken
    {
        public All(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.ALL;
        }
    }
}
