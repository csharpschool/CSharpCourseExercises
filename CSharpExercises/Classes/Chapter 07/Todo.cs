using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_07
{
    public class Todo
    {
        private string description = string.Empty;
        private bool completed = false;
        private Dictionary<string, object> checkboxAttributes = new Dictionary<string, object>();
        private Dictionary<string, object> descriptionAttributes = new Dictionary<string, object>();

        public Todo(string description)
        {
            this.description = description;
        }

        // Expression bodied methods
        public string GetDescription() => description;
        public Dictionary<string, object> GetCheckboxAttributes() => checkboxAttributes;
        public Dictionary<string, object> GetDescriptionAttributes() => descriptionAttributes;
        public void CheckAttributes()
        {
            completed = !completed;

            if (completed)
            {
                checkboxAttributes.Add("checked", "checked");
                descriptionAttributes.Add("class", "completed");
            }
            else
            {
                checkboxAttributes.Clear();
                descriptionAttributes.Clear();
            }
        }

    }
}
