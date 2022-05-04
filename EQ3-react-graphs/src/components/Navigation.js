import {Link} from "react-router-dom";
import React from "react"; 

// Logo va en navbar-brand
/*
        <li className="nav-item">
          <a className="nav-link" href="/Graphs">Gráfica</a>
        </li>
        <li className="nav-item">
          <a className="nav-link" href="/Busqueda">Busqueda de Datos</a>
        </li>
*/

const Navigation = () =>{

return (

    <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
    <a className="navbar-brand" href="#">Ternium</a>
    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>

    <div className="collapse navbar-collapse" id="navbarColor01">
      <ul className="navbar-nav mr-auto">
        <li className="nav-item active">
          <Link className="nav-link" to="/">Inicio</Link>
        </li>
        <li className="nav-item">
          <a className="nav-link" href="/Unity">Mapa de Calor</a>
        </li>
      </ul>
    </div>
  </nav>

)

}



export default Navigation