namespace AlphaX.FluentSQL.Tokens
{
    public class Columns : QueryToken
    {
        private string[] _fields;

        public Columns(IQueryContext context, params string[] fields) : base(context)
        {
            _fields = fields;
        }

        public override string GetValue()
        {
            if (_fields.Length == 0)
                return Token.ALL;

            return string.Join(", ", _fields);
        }
    }
}
