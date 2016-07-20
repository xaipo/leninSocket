/**
 * Created by Lench0 on 02/06/2016.
 */
var restful= require('node-restful');
var mongoose= restful.mongoose;

var categoriaSchema = new mongoose.Schema({

    descripcion: String,
    id_facultad: mongoose.Schema.ObjectId,

});


module.exports= restful.model('escuela',categoriaSchema);/**
 * Created by Lench0 on 02/06/2016.
 */
