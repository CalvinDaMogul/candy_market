import React, { Component } from 'react';
import valueRequests from '../APIRequests/valueRequests';
// import './Home.scss';

class Home extends Component {

  componentDidMount() {

  }

  getAllPeople =() => {
    valueRequests.getValues()
    .then((Response)=>console.error(Response))
    .catch()
  }
  

  render () {
    const testText = this.props.testText;
    return (
      <div className="Home">
          <h1 className="testTarget">{testText}</h1>
          <h2>testTarget</h2>
      </div>
    );
  }
}

export default Home;