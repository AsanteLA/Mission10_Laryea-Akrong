import { useEffect, useState } from 'react';
import { BowlingLeague } from '../types/BowlingLeague';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlingLeague[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const response = await fetch('http://localhost:3001/bowlers');
      const b = await response.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);
}
