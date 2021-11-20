//Company : Navshar Software
//Project : Smart Pudhari
//Author  : Sourabh Raut
//Created On : 23-Feb-2021
//Version: 1.0
//Description : To common function 

var Constant = (function Constant() {
    'use strict';
    var contentType = 'application/json; charset=utf-8';
    var contentTypeXML = 'application/xml; charset=utf-8';
    var urlPrefix = window.location.origin + '/SPS';
    var dataType = "json";
    var secretKey="SmartPreSchool@3456"
    return {
        contentType: contentType,
        urlPrefix: urlPrefix,
        dataType: dataType,
        contentTypeXML: contentTypeXML,
        secretKey: secretKey
    }
})();