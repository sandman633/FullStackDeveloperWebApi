import React, { Component } from 'react';
import Button from './Button';
import Input from './Input';
import Table from './Table';
import axios from 'axios';




class App extends Component{


  constructor(props) {
    super(props);
    this.state = {
      userId: '',
      registrationDate:'',
      lastActivityDate: '',
      dataRow: [
        {}
      ],
      dataCalc:[
        {}
      ]
    };
    this.saveFunc = this.saveFunc.bind(this);
    this.addFunc = this.addFunc.bind(this);
    this.calculate = this.calculate.bind(this);
  }
  data = [];
  saveFunc(){
    console.log(this.data);
    console.log('save');
    axios.post('https://localhost:44389/UserActivity/CreateUsers',this.data).then(response => {
      console.log(response);
    });
    this.data=[];
    this.setState({dataRow: this.data});
  }
  addFunc(){
    this.data.push({userId:this.state.userId, registrationDate: this.state.registrationDate, lastActivityDate: this.state.lastActivityDate });
    this.setState({ dataRow: this.data });
    console.log(this.state.dataRow);
    console.log(this.data);
  }
  
  calculate(){
    axios.get('https://localhost:44389/UserActivity/Get').then(
      response=>{
        this.data=response.data;
      }
    );
    console.log(this.data);
  }



  onChange(e){
    var val = e.target.value;
    

    if(e.target.id =='Id'){
      this.setState( {userId: val} );
      // console.log(e.target.id);
      // console.log(val);
      // console.log(this.state.id);
    }
    if(e.target.id =='lastActiv'){
      this.setState( {lastActivityDate: val} );
    }
    if(e.target.id =='registDate'){
      this.setState( {registrationDate: val} );
    }

  }
  render(){
    return (
      <div className='main'>
        <div className='inputs'>
          <Input className='input' type={'text'} id={'Id'} name={'Id'} onChange={this.onChange.bind(this)} />
          <Input className='input' type={'date'} id={'registDate'} name={'registDate'} onChange={this.onChange.bind(this)} />
          <Input className='input' type={'date'} id={'lastActiv'} name={'lastActiv'} onChange={this.onChange.bind(this)} />
        </div>
        <div>
          <Table data={this.state.dataRow} />
        </div>
        <div className='buttons'>
          <Button func={this.saveFunc} text='Save'  />
          <Button func={this.addFunc} text='Add'  />
        </div>
        <div className='buttons'>
          <Button func={this.calculate} text='Calculate' />
        </div>
      </div>
    );
  }
}

export default App;
