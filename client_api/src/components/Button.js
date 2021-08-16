import React from 'react';
import styles from '../css/style.css';

function Button({text, func}) {
  return (
    <button  onClick={func} className='button'>{text}</button>
  );
}

export default Button;