using System;

namespace WebApplication{
    public class Story{

        public int Id { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int State { get; set; }
        public DateTime CreatedDate { get; set; }

        public Story (int id)
        {
          Id = id;
        }

        public Story ()
        {
          // for EF
        }

    }
    public enum State{
        Active,
        InActive,
        New,
        Draft
    }

}



