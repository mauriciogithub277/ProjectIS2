/*!   GeneXus C# 16_0_7-138086 on 3/7/2020 16:50:21.69
*/
gx.evt.autoSkip=!1;gx.define("attractiongeneral",!0,function(n){this.ServerClass="attractiongeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Attractionid=function(){return this.validCliEvt("Valid_Attractionid",0,function(){try{var n=gx.util.balloon.getNew("ATTRACTIONID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110e1_client=function(){return this.clearMessages(),this.call("attraction.aspx",["UPD",this.A4AttractionID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120e1_client=function(){return this.clearMessages(),this.call("attraction.aspx",["DLT",this.A4AttractionID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150e2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160e2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110e1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120e1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Attractionid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONID",gxz:"Z4AttractionID",gxold:"O4AttractionID",gxvar:"A4AttractionID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4AttractionID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4AttractionID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ATTRACTIONID",gx.O.A4AttractionID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4AttractionID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ATTRACTIONID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONNAME",gxz:"Z5AttractionName",gxold:"O5AttractionName",gxvar:"A5AttractionName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5AttractionName=n)},v2z:function(n){n!==undefined&&(gx.O.Z5AttractionName=n)},v2c:function(){gx.fn.setControlValue("ATTRACTIONNAME",gx.O.A5AttractionName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A5AttractionName=this.val())},val:function(){return gx.fn.getControlValue("ATTRACTIONNAME")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONADDRESS",gxz:"Z6AttractionAddress",gxold:"O6AttractionAddress",gxvar:"A6AttractionAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6AttractionAddress=n)},v2z:function(n){n!==undefined&&(gx.O.Z6AttractionAddress=n)},v2c:function(){gx.fn.setControlValue("ATTRACTIONADDRESS",gx.O.A6AttractionAddress,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6AttractionAddress=this.val())},val:function(){return gx.fn.getControlValue("ATTRACTIONADDRESS")},nac:gx.falseFn};this.declareDomainHdlr(28,function(){gx.fn.setCtrlProperty("ATTRACTIONADDRESS","Link",gx.fn.getCtrlProperty("ATTRACTIONADDRESS","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A6AttractionAddress))});t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ATTRACTIONPHONE",gxz:"Z7AttractionPhone",gxold:"O7AttractionPhone",gxvar:"A7AttractionPhone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A7AttractionPhone=n)},v2z:function(n){n!==undefined&&(gx.O.Z7AttractionPhone=n)},v2c:function(){gx.fn.setControlValue("ATTRACTIONPHONE",gx.O.A7AttractionPhone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A7AttractionPhone=this.val())},val:function(){return gx.fn.getControlValue("ATTRACTIONPHONE")},nac:gx.falseFn};this.declareDomainHdlr(33,function(){});this.A4AttractionID=0;this.Z4AttractionID=0;this.O4AttractionID=0;this.A5AttractionName="";this.Z5AttractionName="";this.O5AttractionName="";this.A6AttractionAddress="";this.Z6AttractionAddress="";this.O6AttractionAddress="";this.A7AttractionPhone="";this.Z7AttractionPhone="";this.O7AttractionPhone="";this.A4AttractionID=0;this.A5AttractionName="";this.A6AttractionAddress="";this.A7AttractionPhone="";this.Events={e150e2_client:["ENTER",!0],e160e2_client:["CANCEL",!0],e110e1_client:["'DOUPDATE'",!1],e120e1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A4AttractionID",fld:"ATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6AttractionID",fld:"vATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A4AttractionID",fld:"ATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A4AttractionID",fld:"ATTRACTIONID",pic:"ZZZ9"}],[]];this.EvtParms.VALID_ATTRACTIONID=[[],[]];this.Initialize()})