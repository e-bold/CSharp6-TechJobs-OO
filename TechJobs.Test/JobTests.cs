
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
    Job job1 = new Job();
    Job job2 = new Job();
    Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    Job job5 = new Job("", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id +1 , job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester" );
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME" );
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert" );
            Assert.AreEqual(job3.JobType.ToString(), "Quality control" );
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence" );
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }


        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            //Arrange - Storing the job3 toString() to a string variable
            string text = job3.ToString();

            //Act - Splitting the text variable by newline. It means every new lines in the text will be removed and replaced with empty string as we are separating them.
            string[] textArray = text.Split(Environment.NewLine); 

            //Assert - Checking if the first and last at index equals to empty string, since we used split method to separate it by newline(newline gets replaced by empty string).
            Assert.AreEqual(textArray[0], "");
            Assert.AreEqual(textArray[textArray.Length - 1], "");

            //Initial Test - I think its wrong
            // Assert.IsTrue(job3.ToString().Contains(Environment.NewLine));
        }


        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job4.ToString().Contains("ID: 4"));
            Assert.IsTrue(job4.ToString().Contains("Name: Product tester"));
            Assert.IsTrue(job4.ToString().Contains("Employer: ACME"));
            Assert.IsTrue(job4.ToString().Contains("Location: Desert"));
            Assert.IsTrue(job4.ToString().Contains("Position Type: Quality control"));
            Assert.IsTrue(job4.ToString().Contains("Core Competency: Persistence"));
        }


        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job5.ToString().Contains("ID: 5"));
            Assert.IsTrue(job5.ToString().Contains("Name: Data not available"));
            Assert.IsTrue(job5.ToString().Contains("Employer: Data not available"));
            Assert.IsTrue(job5.ToString().Contains("Location: Desert"));
            Assert.IsTrue(job5.ToString().Contains("Position Type: Quality control"));
            Assert.IsTrue(job5.ToString().Contains("Core Competency: Data not available"));
        }
    }
}

