namespace AlphaX.FluentSQL.Tokens
{
    public class Create : QueryToken
    {
        public Create(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.CREATE;
        }
    }
}
