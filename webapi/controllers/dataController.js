const mysql = require('../database/db')

class MainController {

    async getDataBySector(req , res){
        console.log(req.params.sectorID)
        if(req.params.sectorID != null) {
            let sectorID = req.params.sectorID
            var sql = `SELECT valor, latitud, longitud FROM Lectura WHERE idSector=${sectorID}`
            mysql.query(sql, (error, results) => {
                if(error) {
                    res.status(500)
                    res.send(error.message)
                } else if(results.length > 0) {
                    res.json(results);
                } else{
                    res.send('No results for this query')
                }
            })
        }
    }

    async logData(req , res){
        console.log(req.params.valor)
        console.log(req.params.latitud)
        console.log(req.params.longitud)
        console.log(req.params.sectorID)
        console.log(req.params.sensorID)

        if(req.params.valor != null && req.params.latitud != null && req.params.longitud != null &&req.params.sectorID != null && req.params.sensorID != null) {
            let valor = req.params.valor
            let latitud = req.params.latitud
            let longitud = req.params.longitud
            let sectorID = req.params.sectorID
            let sensorID = req.params.sensorID
            var sql = `CALL SPLogData(${valor},${latitud},${longitud},${sectorID},${sensorID})`
            mysql.query(sql, (error,data,fields) => {
                if(error) {
                    res.status(500)
                    res.send(error.message)
                } else {
                    console.log(data)
                    res.json({
                        status: 200,
                        message: "Log uploaded successfully",
                        affectedRows: data.affectedRows
                    })
                }
            })
        } else {
            res.send('Por favor llena todos los datos!')
        }
    }

    

    
}

const dataController = new MainController()
module.exports = dataController;

/*

*/
