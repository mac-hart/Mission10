import { useEffect, useState } from 'react';
import { Bowlers } from './types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const rsp = await fetch('http://localhost:5032/bowler');
      const data = await rsp.json();
      setBowlData(data);
    };
    fetchData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers (Sharks and Marlins)</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
            <th>Address</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((bowler) => (
            <tr key={bowler.bowlerName}>
              <td>{bowler.bowlerName}</td>
              <td>{bowler.teamName}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
              <td>{bowler.bowlerAddress}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
