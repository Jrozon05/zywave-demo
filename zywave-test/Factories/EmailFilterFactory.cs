using Bogus;
using zywave_data.Model;

namespace zywave_test.Factories
{
    public static class EmailFilterFactory
    {
        private static Faker<EmailFilter> Factory = new Faker<EmailFilter>()
            .RuleFor(e => e.EmailText, f => f.Random.Words())
            .RuleFor(e => e.isClassified, f => f.Random.Bool());

        public static EmailFilter Create()
        {
            return Factory.Generate();
        }
    }
}