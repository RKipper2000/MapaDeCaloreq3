import Unity, { UnityContext } from "react-unity-webgl";
import React from "react";

const UnityTest = () => {
  const unityContext = new UnityContext({
    loaderUrl: "../../unity/app.loader.js",
    dataUrl: "../../unity/app.data",
    frameworkUrl: "../../unity/app.framework.js",
    codeUrl: "../../unity/app.wasm",
  });

  return (
    <div>
      <h1> Mapa de Calor </h1>
      <Unity
        unityContext={unityContext}
        style={{
          height: "89%",
          width: "89%",
          overflow: "auto",
          //border: "2px solid black",
          background: "grey",
          margin: "0 auto",
          marginTop: "10px",
          display: "flex",
        }}
      />
    </div>
  );
};

export default UnityTest;

