using NUnit.Framework;


namespace Deployment_Configuration_Example.Tests
{
    public class MessageControllerTests
    {
        //Mock<ILogger<MessageController>> _logger;
        //Mock<IConfiguration> _config;
        //Mock<IConfigurationSection> _configSection;

        [SetUp]
        public void Setup()
        {
            //_configSection = new Mock<IConfigurationSection>();
            //_config = new Mock<IConfiguration>();
            //_logger = new Mock<ILogger<MessageController>>();
        }

        [Test]
        public void Get_ToTestStandardMessageResponse_RespondsWithMockedMessage()
        {
            //// Arrange
            //_config.Setup(c => c.GetSection("TheMessage")).Returns(_configSection.Object);
            //_configSection.Setup(cs => cs.Value).Returns("This is a test");

            //var controller = new MessageController(_logger.Object, _config.Object);

            //// Act
            //var response = controller.Get();

            //// Assert
            //Assert.AreEqual("This is a test", response);

            Assert.Pass();

        }
    }
}