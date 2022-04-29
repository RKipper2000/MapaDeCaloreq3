const express = require('express');
const dataController = require('../controllers/dataController')
const router = express.Router();

router.post('/api/logData/:valor/:latitud/:longitud/:sectorID/:sensorID', dataController.logData);

router.get('/api/getDataBySector/:sectorID', dataController.getDataBySector);


module.exports = router;