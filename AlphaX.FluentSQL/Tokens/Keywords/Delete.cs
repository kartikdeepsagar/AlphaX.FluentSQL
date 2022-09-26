namespace AlphaX.FluentSQL.Tokens
{
    public class Delete : QueryToken
    {
        public Delete(IQueryContext context) : base(context)
        {
        }

        public override string GetValue()
        {
            return Token.DELETE;
        }
    }
}
