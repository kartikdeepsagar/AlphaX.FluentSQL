namespace AlphaX.FluentSQL.Tokens
{
    public class Update : QueryToken
    {
        public Update(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.UPDATE;
        }
    }
}
