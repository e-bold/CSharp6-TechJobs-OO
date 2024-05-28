
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

        [TestMethod]
        public void TestSettingJobId()
        {
            //Arrange and Act
            //Done Already inside the class

            //Assert
        Assert.AreEqual(job1.Id +1 , job2.Id);

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Arrange and Act
            //Done Already inside the class

            //Assert
        Assert.AreEqual(job3.Name, "Product tester" );
        Assert.AreEqual(job3.EmployerName.ToString(), "ACME" );
        Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert" );
        Assert.AreEqual(job3.JobType.ToString(), "Quality control" );
        Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence" );
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            //Arrange and Act
            //Done Already inside the class

            //Assert
        Assert.IsFalse(job3.Equals(job4));

        }
    }
}

