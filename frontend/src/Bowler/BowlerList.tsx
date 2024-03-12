import { useEffect, useState } from 'react';
import { BowlingLeague } from '../types/BowlingLeague';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlingLeague[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const response = await fetch('http://localhost:5095/Bowling');
      const b = await response.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <br />
      <br />
      <div className="container">
        <table className="table table-bordered">
          <thead>
            <tr>
              <th>Bowler Name</th>
              <th>Team Name</th>
              <th>Address</th>
              <th>City</th>
              <th>State</th>
              <th>Zip</th>
              <th>Phone Number</th>
            </tr>
          </thead>
          <tbody>
            {bowlerData.map((b) => (
              <tr key={b.bowlerId}>
                <td>{b.bowlerName}</td>
                <td>{b.team.teamName}</td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default BowlerList;
