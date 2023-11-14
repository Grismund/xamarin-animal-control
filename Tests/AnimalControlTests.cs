using NUnit.Framework;
using xammy;


namespace Tests
{
    [TestFixture]
    public class AnimalControlTests
    {
        [Test]
        public void Animal_Setter_ShouldSetAnimal()
        {
            // Arrange
            AnimalControl animalControl = new AnimalControl();
            
            // Act
            animalControl.Animal = "Frog";
            
            // Assert
            Assert.AreEqual("Frog", animalControl.Animal);
        }
        
        [Test]
        public void Animal_Setter_ShouldSetAnimalUri()
        {
            // Arrange
            AnimalControl animalControl = new AnimalControl();
            string frogUri = "https://i.etsystatic.com/isla/910f97/34229353/isla_fullxfull.34229353_lywq3bgq.jpg?version=0";
            
            // Act
            animalControl.Animal = "Frog";
            
            // Assert
            Assert.AreEqual(frogUri, animalControl.AnimalUri);
        }
        
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(4, 2 + 2);
        }
    }
}

