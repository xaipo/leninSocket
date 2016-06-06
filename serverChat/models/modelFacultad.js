var restful= require('node-restful');
var mongoose= restful.mongoose;

var categoriaSchema = new mongoose.Schema({
    
    descripcion: String,
    
});


module.exports= restful.model('facultad',categoriaSchema);/**
 * Created by Lench0 on 02/06/2016.
 */
