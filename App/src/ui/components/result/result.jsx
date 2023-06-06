import React, { useEffect, useState } from 'react';
import "../result/index.css"
import pedra from '../../../assets/img/pedra.png';
import papel from '../../../assets/img/papel.png';
import tesoura from '../../../assets/img/tesoura.png';

export function Result({ playerWon, playerBet, iaBet, onPlayAgain }) {
    const [showResult, setShowResult] = useState(false);

    useEffect(() => {
        const timer = setTimeout(() => {
            setShowResult(true);
        }, 500);

        return () => {
            clearTimeout(timer);
        };
    }, []);

    const resultClass = playerWon === 'Empate' ? 'resultado-empate' : playerWon === 'Derrota' ? 'resultado-derrota' : 'resultado-vitoria';

    return (
        <>
            <div className={`resultado ${showResult ? 'show' : ''}`}>
                <div className="jogada">
                    <img
                        src={
                            playerBet === 'PEDRA'
                                ? pedra
                                : playerBet === 'PAPEL'
                                    ? papel
                                    : tesoura
                        }
                        alt="jogada do jogador"
                    />
                    <h2>{playerBet}</h2>
                </div>
                <div className="jogada">
                    <img
                        src={
                            iaBet === 'PEDRA'
                                ? pedra
                                : iaBet === 'PAPEL'
                                    ? papel
                                    : tesoura
                        }
                        alt="jogada da Computador"
                    />
                    <h2>Computador</h2>
                </div>
            </div>
            <div className={`resultado-texto ${showResult ? 'show' : ''} ${resultClass}`}>
                <h2 className="animated-text">{playerWon}</h2>
                <button onClick={onPlayAgain}>Jogar Novamente</button>
            </div>
        </>
    );
}
