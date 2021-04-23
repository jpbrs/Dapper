import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Secretta</h1>
        <p>Bem vindo ao seu site de secretarias virtuais!</p>
        <ul>
          <li>By <a href='https://github.com/jpbrs'>Joao Pedro Brandao</a> and <a href='https://github.com/pedromxavier'>Pedro Maciel Xavier</a></li>
         </ul>
      </div>
    );
  }
}
