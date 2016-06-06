/**
 * Created by Lench0 on 02/06/2016.
 */
var express= require('express');
var router= express.Router();


// </editor-fold>
var Usuario = require('../models/modelUsuario');



Usuario.methods(['get','put','post','delete','search']);
Usuario.register(router,'/usuario');



// </editor-fold>

//Return route
module.exports=router;

