import Vue from "vue";
import { Component } from "vue-property-decorator";

interface TodoItem {
  id: AAGUID;
  name: string;
  isDone: boolean;
}

@Component
export default class TodoComponent extends Vue {
  todos: TodoItem[] = [];

  mounted() {
    fetch("api/Todo")
      .then(response => response.json() as Promise<TodoItem[]>)
      .then(data => {
        this.todos = data;
      });
  }

  /**
   * createTodo
   */
  public createTodo(todo: TodoItem) {
    let newTodo = todo;
    newTodo.isDone = false;

    this.todos.push(newTodo);
  }

  public toggleTodo(todo: TodoItem) {
    todo.isDone != todo.isDone;
    console.log(todo)
  }
}
