namespace Commender.Dtos{

    public class CommandReadDto{
        public int Id { get; set; }
        public string HowTo {get;set;}
        public string Line {get;set;}
        // public string Platform {get;set;} // we will not expose this to the client
    }
}