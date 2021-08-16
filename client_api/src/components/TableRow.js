import React from 'react';
import styles from '../css/style.css';


function TableRow({data}) {
  return (
    <tr className='tableRow'>
      <td>{data.userId}</td>
      <td>{data.registrationDate}</td>
      <td>{data.lastActivityDate}</td>
    </tr>
  );
}

export default TableRow;