import "./index.css";
import menina from "../../../assets/img/menina.png";
import menino from "../../../assets/img/menino.png";
import useGlobalUser from "../../../context/user/user.context";
import { useNavigate } from "react-router-dom";

export function ProfileSelection() {
  const [user, setUser] = useGlobalUser();
  const navigate = useNavigate();

  function play(newUser) {
    setUser(newUser);
    navigate("/match");
  }
  return (
    <>
      <div>
        <h1>Selecione um Perfil:</h1>
        <div className="perfis">
          <div className="perfil" onClick={() => play("Maria")}>
            <img src={menina} alt="Menina" />
            <h2>Maria</h2>
          </div>
          <div className="perfil" onClick={() => play("João")}>
            <img src={menino} alt="Menina" />
            <h2>João</h2>
          </div>
        </div>
      </div>
    </>
  );
}
