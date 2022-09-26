namespace AlphaX.FluentSQL.Tokens
{
    public class Table : QueryToken
    {
        private string _tableName;

        public Table(IQueryContext context, string tableName) : base(context)
        {
            _tableName = tableName;
        }

        public override string GetValue()
        {
            return _tableName;
        }
    }
}
