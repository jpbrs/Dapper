import React, { Component } from 'react';

export class MyTasks extends Component {
  static displayName = MyTasks.name;

  constructor(props) {
    super(props);
    this.state = { Tasks: [], loading: true };
  }



  componentDidMount() {
    this.populateTaskData();
  }

  static renderTasksTable(Tasks) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Nome</th>
            <th>Local</th>
            <th>Cliente</th>
            <th>Horario</th>
          </tr>
        </thead>
        <tbody>
          {Tasks.map(Task =>
            <tr key={Task.horario}>
              <td>{Task.nome}</td>
              <td>{Task.localidade}</td>
                  <td>{Task.cliente}</td>
                  <td>{Task.horario}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : MyTasks.renderTasksTable(this.state.Tasks);

    return (
      <div>
        <h1 id="tabelLabel" >Task</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateTaskData() {
      const response = await fetch('task/userid/2');
    const data = await response.json();
    this.setState({ Tasks: data, loading: false });
  }
}
