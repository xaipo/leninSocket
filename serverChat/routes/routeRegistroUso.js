/**
 * Created by Lench0 on 02/06/2016.
 */
var express= require('express');
var router= express.Router();


// </editor-fold>
var Registro = require('../Models/modelRegistroUso');



Registro.methods(['get','put','post','delete','search']);
Registro.register(router,'/registrouso');



// </editor-fold>

//Return route
module.exports=router;
