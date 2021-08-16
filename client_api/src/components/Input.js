import React from 'react';


function Input(props) {
  return (
    <input className='input' type={props.type} id={props.id} name={props.name} onChange={props.onChange} value={props.value} />
  );
}

export default Input;