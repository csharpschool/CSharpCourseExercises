using Xunit;
using CSharpExercises.Classes.Chapter_06;

namespace CSharpExercises.Tests.Chapter_06
{
    public class ToDoTests
    {
        [Fact]
        public void CanCreateTodoInstance()
        {
            var todo = new Todo("Todo 1");

            Assert.NotNull(todo);
        }

        [Fact]
        public void CanReadDescriptionAndCollectionsAreEmpty()
        {
            var todo = new Todo("Todo 1");
            Assert.Equal("Todo 1", todo.GetDescription());
            Assert.Empty(todo.GetCheckboxAttributes());
            Assert.Empty(todo.GetDescriptionAttributes());
        }

        [Fact]
        public void CollectionsHaveValues()
        {
            var todo = new Todo("Todo 1");
            todo.CheckAttributes();
            Assert.NotEmpty(todo.GetCheckboxAttributes());
            Assert.NotEmpty(todo.GetDescriptionAttributes());
        }

        [Fact]
        public void CanCreateTodosInstance()
        {
            var todo = new Todos();

            Assert.NotNull(todo);
        }

        [Fact]
        public void CanAddAndGetTodos()
        {
            var todos = new Todos();
            todos.Add("todo 1");

            Assert.NotEmpty(todos.Get());
        }

        [Fact]
        public void CanRemoveTodos()
        {
            var todos = new Todos();
            todos.Add("To-do 1");
            var countBeforeDelete = todos.Get().Count;
            var todo = todos.Get().Find(t => t.GetDescription().Equals("To-do 1"));
            todos.Remove(todo);
            Assert.Equal(1, countBeforeDelete);
            Assert.Empty(todos.Get());
        }
    }
}
