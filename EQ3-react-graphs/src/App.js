import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import Navigation from "./components/Navigation";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Graphs from "./components/Graphs";
import UnityTest from "./components/UnityTest";
import Footer from "./components/Footer";
import React from "react";

function App() {
  return (
    <div>
      <BrowserRouter>
        <Navigation />
        <Routes>
          <Route path="/" element={<h1>MapaDeCalor Equipo 3</h1>} />
          <Route path="/Graphs" element={<Graphs />} />
          <Route path="/Unity" element={<UnityTest />} />
        </Routes>
        
      </BrowserRouter>
    </div>
  );
}

export default App;