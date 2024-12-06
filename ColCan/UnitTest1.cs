using System.ComponentModel.DataAnnotations;

namespace ColCan
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public Food Foods { get; set; }
        public User Users { get; set; }
        List<Food> GetTestFoods()
        {
            return new List<Food>
            {
                new Food{ Title = "Валера", Description = "test1" },
                new Food{ Title = "Серега", Description = "test2" },
                new Food{ Title = "Валера", Description = "test3" }
            };
        }

        [Test]
        public void TestSelectedFood()
        {
            var food = GetTestFoods();

            Assert.IsNotNull(food);
            Assert.That(food, Is.TypeOf<List<Food>>());

        }
        /*[Test]
        public void TestGetDescriptionFoodBySelectedFood()
        {
            var food = GetTestFoods();

            Assert.IsNotNull(Foods.Description);
            Assert.That(Foods.Description, Is.EqualTo(Foods.Description));         
        }*/
        [Test]
        public void LoginPasswordIsNotNull()
        {
            var login = Users.Login;
            var password = Users.Password;

            Assert.IsNotNull(login);
            Assert.IsNotNull(password);

            Assert.That(login, Is.EqualTo(Users.Login));
            Assert.That(password, Is.EqualTo(Users.Password));
        }

        [Test]
        public void LoginPasswordIsTrue()
        {
            var login = Users.Login;
            var password = Users.Password;

        }
    }
}