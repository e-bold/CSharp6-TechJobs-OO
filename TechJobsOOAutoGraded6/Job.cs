using System;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods. 
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string nl = Environment.NewLine;


            //Ternary expression to check if the each argument data is empty. If it is empty return "Data not available" if its not return whatever the argument value is.
            //
            string Name1 = string.IsNullOrEmpty(Name) ? "Data not available" : Name;
            string EmployerName1 = string.IsNullOrEmpty(EmployerName.ToString()) ? "Data not available" : EmployerName.ToString();
            string EmployerLocation1 = string.IsNullOrEmpty(EmployerLocation.ToString()) ? "Data not available" : EmployerLocation.ToString();
            string JobType1 = string.IsNullOrEmpty(JobType.ToString()) ? "Data not available" : JobType.ToString();
            string JobCoreCompetency1 = string.IsNullOrEmpty(JobCoreCompetency.ToString()) ? "Data not available" : JobCoreCompetency.ToString();
          
            return 
            nl 
            + nl + "ID: " + Id 
            + nl + "Name: " + Name1
            + nl + "Employer: " + EmployerName1
            + nl + "Location: " + EmployerLocation1
            + nl + "Position Type: " + JobType1
            + nl + "Core Competency: " + JobCoreCompetency1
            + nl 
            + nl;
        }
    }
}

