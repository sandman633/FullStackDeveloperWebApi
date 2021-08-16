import TableHeader from "./TableHeader";
import TableRow from "./TableRow";
import styles from '../css/style.css';
import React, {useState} from "react";




function Table({data}) {





  return (
    <table className="table">
      <thead>
        <TableHeader/>
      </thead>
      <tbody>
        {data.map(row =>
          {return <TableRow className='tableRow' data={row} key={row.id} />
        })}
      </tbody>
    </table>
  );
}




export default Table;