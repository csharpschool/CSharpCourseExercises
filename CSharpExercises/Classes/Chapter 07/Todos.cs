using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_07
{
    public class Todos
    {
        List<Todo> todos = new List<Todo>();

        public List<Todo> Get() => todos;
        public void Add(string description) => todos.Add(new Todo(description));
        public void Remove(Todo todo) => todos.Remove(todo);
    }
}
