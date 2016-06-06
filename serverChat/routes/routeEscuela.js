/**
 * Created by Lench0 on 02/06/2016.
 */
var express= require('express');
var router= express.Router();


// </editor-fold>
var Escuela = require('../Models/modelEscuela');



Escuela.methods(['get','put','post','delete','search']);
Escuela.register(router,'/escuela');



// </editor-fold>

//Return route
module.exports=router;
