let express = require('express')
let cors = require('cors')
let app = express()
let port = process.env.PORT || 3000

//1
app.use(express.json())
app.use(cors())

//2
let registro = require('./routes/lectura');

//3
app.use('/lectura', registro)

//4
app.listen(port, () => {
    console.log(`Servidor iniciado en el puerto ${port}`)
});