/**
 * Created by Lench0 on 24/05/2016.
 */
var restful= require('node-restful');
var mongoose= restful.mongoose;

var categoriaSchema = new mongoose.Schema({
    
    descripcion : String,

});


module.exports= restful.model('tipousuario',categoriaSchema);
