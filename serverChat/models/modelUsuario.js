/**
 * Created by Lench0 on 02/06/2016.
 */
var restful= require('node-restful');
var mongoose= restful.mongoose;

var categoriaSchema = new mongoose.Schema({

    ci: Number,
    escuela: String,
    nombre: String,
    estado: String,
    sexo: String,
    id_escuela: mongoose.Schema.ObjectId,
    id_tipousuario: mongoose.Schema.ObjectId

});


module.exports= restful.model('usuario',categoriaSchema);/**
 * Created by Lench0 on 02/06/2016.
 */

