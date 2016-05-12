var express = require('express');
var url = require('url');
var app = express();
var port = 8080;
var router = express.Router();
var counter = 0;

router.get('/greeting', function(req, res) {
    var name = url.parse(req.url, true).query.name || 'Node World'; 
    res.json({
        "id": ++counter,
        "content": "Hello, " + name
    });
});

app.use('', router);
app.listen(port);
console.log('node server started on ' + port);
