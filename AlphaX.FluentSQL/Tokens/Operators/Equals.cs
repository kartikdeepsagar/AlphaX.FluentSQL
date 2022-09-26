namespace AlphaX.FluentSQL.Tokens
{
    public class EqualsTo : QueryToken
    {
        private string _value;

        public EqualsTo(IQueryContext context, string value) : base(context)
        {
            _value = value;
        }

        public override string GetValue()
        {
            return $"{Token.EQUALSTO} {_value}";
        }
    }
}
