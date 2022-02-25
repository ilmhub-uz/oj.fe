namespace oj.fe.Models.Posts;

public class Result
{
       public int Id { get; set; }
        public CreatedBy Created_by { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Create_time { get; set; }
        public DateTime Last_update_time { get; set; }
        public bool Visible { get; set; }
}
