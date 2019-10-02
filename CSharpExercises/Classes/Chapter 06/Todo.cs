using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_06
{
    public class Todo
    {
        private string description = string.Empty;
        public string completed = string.Empty;
        public List<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();

        public Todo(string description)
        {
            this.description = description;
        }

        // Expression bodied methods
        public string GetDescription() => description;
        public List<KeyValuePair<string, object>> GetAttributes() => attributes;
        public void CheckAttributes()
        {
            if (completed.Equals(string.Empty))
                attributes.Clear();
            else
                attributes.Add(new KeyValuePair<string, object>("checked", "checked"));
        }
    }
}
