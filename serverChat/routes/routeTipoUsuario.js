/**
 * Created by Lench0 on 24/05/2016.
 */
// <editor-fold defaultstate="collapsed" desc="Dependencias">
var express= require('express');
var router= express.Router();


// </editor-fold>
var TipoUsuario = require('../models/modelTipoUsuario');



TipoUsuario.methods(['get','put','post','delete','search']);
TipoUsuario.register(router,'/tipousuario');



// </editor-fold>

//Return route
module.exports=router;