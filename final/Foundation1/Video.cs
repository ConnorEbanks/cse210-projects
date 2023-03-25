class Video
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public int _length { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        // Return the number of comments
        public int GetNumberOfComments()
        {
            return Comments.Count;
        }
    }