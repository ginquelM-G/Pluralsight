var express = require('express');
var path = require('path');
var open = require('open');

var port =3000;
var app = express();

app.get("/", function(req, res){
    res.sendFile(path.join(__dirname, '../src/index.html'));
});

app.listen(port, function(err, data){
    if(err){
        console.log(err);
    }else{
        open('http://localhost:' + port);
    }
});

//Sharing your project using localtunnel 
//open new cmd and write: lt --port 3000 or lt --port 3000 --subdomain cory"


//Automation: 
// npm start, npm run security-check