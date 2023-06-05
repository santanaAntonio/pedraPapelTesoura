import React, { useState } from 'react';
import './index.css';

import pedra from '../../../assets/img/pedra.png';
import papel from '../../../assets/img/papel.png';
import tesoura from '../../../assets/img/tesoura.png';
import randomico from '../../../assets/img/randomico.png';
import { useMatch } from '../../../api/match/match';
import { Scoreboard } from '../../components/scoreboard/scoreboard';


export function Match() {
  const { match } = useMatch();
  const [response, setResponse] = useState(null);

  async function makeMatch(bet) {
    const result = await match(bet);
    setResponse(result);
  }

  function resetMatch() {
    setResponse(null);
  }

  return (
    <div className="container">

      {response ? (
        <Scoreboard
          playerWon={response.playerWon}
          playerBet={response.playerBet}
          iaBet={response.iaBet}
          onPlayAgain={resetMatch}
        />
      ) : (
        <>
            <h1>Faça sua Jogada:</h1>
        <div className="match">
          <div className="jogada">
            <img onClick={() => makeMatch('pedra')} src={pedra} alt="pedra" />
            <h2>PEDRA</h2>
            <img onClick={() => makeMatch('papel')} src={papel} alt="papel" />
            <h2>PAPEL</h2>
            <img onClick={() => makeMatch('tesoura')} src={tesoura} alt="tesoura" />
            <h2>TESOURA</h2>
          </div>
          <div className="jogada">
            <img src={randomico} alt="randomico" />
            <h2>I.A.</h2>
          </div>
        </div>
          </> )}
    </div>
  );
}
