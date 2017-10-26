import express from 'express' //var express = require('express');
var path = require('path');
var open = require('open');

import webpack from 'webpack';
import config from '../webpack.config.dev';

const port =3000//var port =3000;
const app = express();
const compiler = webpack(config);

app.use(require('webpack-dev-middleware')(compiler,{
    noInfo: true,
    publicPath: config.output.publicPath
}));

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


// TRANSPILING:
// A source-to-source compiler, transcompiler or transpiler is a type of compiler
// that takes the source code of a program written in one programming language as its input and produces the equivalent source code in another programming language
/** Transpiling is a specific term for taking source code written in one language and transforming into another language that has a similar level of abstraction 
 * Popular Transpilers: {Babel, TypeScript, Elm}
 */