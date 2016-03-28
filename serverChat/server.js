/**
 * Created by xaipo on 3/28/2016.
 */
var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

app.get('/', function(req, res){
    res.send('<h1>Hello world</h1>');
});
io.on('connection', function(socket){
    console.log('a user connected');

    socket.on('hi', function(msg){
        console.log(msg);
        socket.emit('respuesta', 'hola');
    });

    socket.on('disconnect', function(){
        console.log('user disconnected');
    });
});

http.listen(3000, function(){
    console.log('listening on *:3000');
});