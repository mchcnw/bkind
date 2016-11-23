namespace WebApplication{
    public class Story{

        public string Story { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int State { get; set; }


    public enum State{
        Active,
        InActive,
        New,
        Draft
    }

}

