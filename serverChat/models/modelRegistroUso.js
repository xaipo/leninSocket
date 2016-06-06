/**
 * Created by Lench0 on 02/06/2016.
 */
var restful= require('node-restful');
var mongoose= restful.mongoose;

var categoriaSchema = new mongoose.Schema({

    Hora_fecha_uso: Date,
    tiempo_uso: Number,
    num_pc: Number,
    hora_fin: Date,
    id_usuario: mongoose.Schema.ObjectId,
    
    

});


module.exports= restful.model('registrouso',categoriaSchema);