/**
 * Created by Lench0 on 24/05/2016.
 */
// <editor-fold defaultstate="collapsed" desc="Dependencias">
var express= require('express');
var router= express.Router();


// </editor-fold>
var Facultad = require('../Models/modelFacultad');



Facultad.methods(['get','put','post','delete','search']);
Facultad.register(router,'/facultad');



// </editor-fold>

//Return route
module.exports=router;
