namespace AlphaX.FluentSQL.Tokens
{
    public class Select : QueryToken
    {
        public Select(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.SELECT;
        }
    }
}
