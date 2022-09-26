namespace AlphaX.FluentSQL.Tokens
{
    public class Column : QueryToken
    {
        private string _name;

        public Column(IQueryContext context, string name) : base(context)
        {
            _name = name;
        }

        public override string GetValue()
        {
            return _name;
        }
    }
}
