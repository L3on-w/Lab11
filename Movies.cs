using System;
using System.Collections.Generic;
using System.Linq;


namespace movie_list
{
    public class Movies
    {
        public List<string> Movie { get; set; }

        public string title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }
        private string _title;

        public string category
        {
            set
            {
                _category = value;
            }
            get
            {
                return _category;
            }
        }
        private string _category;

       
    }
}
