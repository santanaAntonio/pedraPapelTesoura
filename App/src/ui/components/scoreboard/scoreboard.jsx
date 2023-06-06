import React, { useEffect, useState } from 'react';
import "../scoreboard/index.css"
import useGlobalUser from "../../../context/user/user.context";
import { useMatch } from '../../../api/match/match';

export function Scoreboard() {
    const [scores, setScores] = useState([])
    const [user, setUser] = useGlobalUser();
    const { scoreboard } = useMatch();

    useEffect(() => {
        async function GetScore() {
            const response = await scoreboard();
            setScores(response);
        }
        GetScore();
    }, [])


    return (
        <div className='scoreboard-container' >
            <div>
                {user} :  {scores.playerWin}
            </div>
            <div>
                Empates :  {scores.tie}
            </div>
            <div>
                Computador :  {scores.playerLoss}
            </div>
        </div>
    );
}
