using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_06
{
    public class Todos
    {
        List<Todo> todos = new List<Todo>();

        public Todos()
        {
            Add("To-do 1");
            Add("To-do 2");
        }

        public List<Todo> Get() => todos;

        public void Add(string description)
        {
            todos.Add(new Todo(description));
        }

        public void Remove(Todo todo)
        {
            todos.Remove(todo);
        }

        //public void RemoveAt(int index)
        //{
        //    todos.RemoveAt(index);
        //}

        //public void SetCompleted(Todo todo)
        //{
        //    todo.SetCompleted();
        //}

        //public void SetNotCompleted(Todo todo)
        //{
        //    todo.SetNotCompleted();
        //}

    }
}
