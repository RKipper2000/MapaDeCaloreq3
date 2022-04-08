let express = require('express')
let mysql = require('mysql')
let router = express.Router()

//1
let config = {
    host: 'http://localhost:3000/', //endpoint
    user: 'user', //usuario
    password: 'password', //contraseña
    database: 'MapaDeCaloreq3',
    dateStrings: true
}

//2
let conexion = mysql.createConnection(config);

//3
router.get ('/', (request, response, next) => { 
    let sql = `(select * from Lectura order by idLectura desc limit 100)`
    conexion.query(sql, (error, results, fields) => {
        if (error) response.send(error)
        response.json(results)
    })
})

//4
router.get ('/:idLectura', (request, response, next) => { 
    let sql = 'select * from Lectura where idLectura = ?'
    conexion.query(sql, [request.params.idLectura], (error, results, fields) => {
        if (error) response.send(error)
        response.json(results)
    })
})

//5
router.post('/', (request, response, next) => {
    let lectura = request.body
    let sql = 'insert into Lectura(idLectura, valor, fecha, hora, idSensor) values(?, ?, NOW(), NOW(), ?)'
    conexion.query(sql, [lectura.idLectura, lectura.valor, lectura.idSensor], (error, results, fields) => {
        if (error) response.send(error)
        response.json(results)
    })
})

/*
router.post('/', (request, response, next) => {
    let lectura = request.body
    let sql = 'insert into Lectura(idSensor, idPlanta, fecha, hora, dato) values(?, ?, NOW(), NOW(), ?)'
    conexion.query(sql, [lectura.idSensor, lectura.idPlanta, lectura.dato], (error, results, fields) => {
        if (error) response.send(error)
        response.json(results)
    })
})
*/

//6
router.delete('/:idLectura', (request, response, next) => {
    let sql = 'delete from Lectura where idLectura = ?'
    conexion.query(sql, [request.params.idLectura], (error, results, fields) => {
        if (error) response.send(error)
        response.json(results)
    })
})

//7
module.exports = router