namespace OOP.FinalTerm.Exam.Model
{
    //TODO: Students will implement the DirectorModel class with properties as per requirements
    //Inherit PersonModel
    //PersonModel must be created first if not already present
    public class DirectorModel : PersonModel
    {
        //add properties here
        //refer to README.md for property details
        //refer to MovieModel for guidance
        public string Genres { get; set; } 
        public int TotalMoviesCreated { get; set; }    
        
    }
}
