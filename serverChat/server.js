/**
 * Created by xaipo on 3/28/2016.
 */
var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);
var mongoose=  require('mongoose');
var bodyParser= require('body-parser');
var cors = require('cors');

app.get('/', function(req, res){
    res.send('<h1>Hello world</h1>');
});
var macs = [];
io.on('connection', function(socket){

    console.log('a user connected');
    socket.on('enviomac', function(msg){
        console.log(msg);
        macs.push(msg);
        //socket.emit('respuesta', macs);
        console.log(macs);
    });

    socket.on("desbloquear", function(msg){
        console.log("el mensaje es "+msg);
        socket.broadcast.emit("mensaje", msg);
    });

    socket.on('devuelve', function(msg){
        console.log(msg);
        socket.broadcast.emit('estado', msg);
        console.log(msg);
    });


    socket.on('disconnect', function(){

        socket.broadcast.emit('desco_clie','down');
        console.log()
console.log('user disconnected ' +  'Usuario Admin');
});
});





/* conexion a mongodb*/
mongoose.connect('mongodb://localhost/controlLaboratorio', function(error){
    if(error){
        throw error;
    }else{
        console.log('Conectado a MongoDB');
    }
});

//var app= express();
app.use(bodyParser.urlencoded({extended:true}));
app.use(bodyParser.json());
app.use(cors());// permite angular interactuar



/*aqui apis*/

app.use('/api',require('./routes/routeTipoUsuario'));
app.use('/api',require('./routes/routeFacultad'));
app.use('/api',require('./routes/routeEscuela'));
app.use('/api',require('./routes/routeUsuario'));
app.use('/api',require('./routes/routeRegistroUso'));


//app.listen(3001);
//console.log("servidor ejecutando en el puerto 3000");
http.listen(3000, function(){
    console.log('listening on *:3000');
});