namespace AlphaX.FluentSQL.Tokens
{
    public class Where : QueryToken
    {
        public Where(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.WHERE;
        }
    }
}
