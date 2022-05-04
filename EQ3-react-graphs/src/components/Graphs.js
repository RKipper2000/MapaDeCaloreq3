import React, { useState, useEffect } from "react";
import { VictoryChart, VictoryTheme, VictoryBar } from "victory";
import axios from "axios";

const Graphs = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    getData();

    const timer = setInterval(() => {
      
      getData();

    }, 10000);

  },[]);

  const getData = async () => {
    const res = await axios.get("http://localhost:5000/api/ganancias");
    console.log(res.data.rows);
    setData(res.data.rows);
  };

  return (
    <div style={{ width: "40%" }}>
      <h1>Gráfica del Mapa de Calor</h1>
      <VictoryChart
        theme={VictoryTheme.material}
        domainPadding={10}
        animate={{ duration: 1000, onLoad: { duration: 500 } }}
      >
        <VictoryBar
          data={data}
          x="año"
          y={(g) => g.ganancias * 1}
          style={{ data: { fill: "#c43a31", stroke: "black", strokeWidth: 2 } }}
        />
      </VictoryChart>
    </div>
  );
};

export default Graphs;
