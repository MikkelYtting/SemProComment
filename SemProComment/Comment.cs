using System;

namespace SemProComment
{
    public class Comment
    {
        private string _commenttext;
        private int _id;


        public string Commenttext 
        {
            get => _commenttext;
            set
            {
                _commenttext = value;
            }
        }
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public Comment(int Id, string Commenttext)
        {
            _commenttext = Commenttext;
            _id = Id;
        }
        public Comment()
        {

        }

    }
}
