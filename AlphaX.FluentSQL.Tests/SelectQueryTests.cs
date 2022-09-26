using AlphaX.FluentSQL;
using NUnit.Framework;

namespace AlphaX.FluentSQL.Tests
{
    public class SelectQueryTests
    {
        [TestCase]
        public void Select_All_Columns_With_One_Equal_Condition()
        {
            var query = "SELECT * FROM customers WHERE name = 'john'";
            var fluentQuery = SQLQuery.Select.All().From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_All_Columns_With_Multi_Equal_Condition()
        {
            var query = "SELECT * FROM customers WHERE name = 'john' AND age = 18";
            var fluentQuery = SQLQuery.Select.All().From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").And()
                .Column("age").EqualsTo("18").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_All_Columns_Without_Condition()
        {
            var query = "SELECT * FROM customers";
            var fluentQuery = SQLQuery.Select.All().From().Table("customers").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_One_Column_Without_Condition()
        {
            var query = "SELECT name FROM customers";
            var fluentQuery = SQLQuery.Select.Columns("name").From().Table("customers").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_One_Column_With_One_Equal_Condition()
        {
            var query = "SELECT name FROM customers WHERE name = 'john'";
            var fluentQuery = SQLQuery.Select.Columns("name").From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_One_Column_With_Multi_Equal_Condition()
        {
            var query = "SELECT name FROM customers WHERE name = 'john' AND age = 18";
            var fluentQuery = SQLQuery.Select.Columns("name").From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").And()
                .Column("age").EqualsTo("18").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_Multi_Column_Without_Condition()
        {
            var query = "SELECT id, name FROM customers";
            var fluentQuery = SQLQuery.Select.Columns("id, name").From().Table("customers").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_Multi_Column_With_One_Equal_Condition()
        {
            var query = "SELECT id, name FROM customers WHERE name = 'john'";
            var fluentQuery = SQLQuery.Select.Columns("id", "name").From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }

        [TestCase]
        public void Select_Multi_Column_With_Multi_Equal_Condition()
        {
            var query = "SELECT id, name FROM customers WHERE name = 'john' AND age = 18";
            var fluentQuery = SQLQuery.Select.Columns("id", "name").From().Table("customers")
                .Where().Column("name").EqualsTo("'john'").And()
                .Column("age").EqualsTo("18").ToSQL();
            Assert.That(fluentQuery, Is.EqualTo(query));
        }
    }
}
