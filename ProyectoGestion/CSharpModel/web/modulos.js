/*!   GeneXus C# 16_0_7-138086 on 3/14/2020 11:48:27.77
*/
gx.evt.autoSkip=!1;gx.define("modulos",!1,function(){this.ServerClass="modulos";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Modulosid=function(){return this.validSrvEvt("Valid_Modulosid",0).then(function(n){return n}.closure(this))};this.e11066_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12066_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53];this.GXLastCtrlId=53;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0,evt:"e13066_client",std:"FIRST"};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0,evt:"e14066_client",std:"PREVIOUS"};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0,evt:"e15066_client",std:"NEXT"};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0,evt:"e16066_client",std:"LAST"};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0,evt:"e17066_client",std:"SELECT"};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Modulosid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSID",gxz:"Z13ModulosID",gxold:"O13ModulosID",gxvar:"A13ModulosID",ucs:[],op:[44,39],ip:[44,39,34],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13ModulosID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13ModulosID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MODULOSID",gx.O.A13ModulosID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A13ModulosID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MODULOSID",",")},nac:gx.falseFn};this.declareDomainHdlr(34,function(){});n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSNAME",gxz:"Z14ModulosName",gxold:"O14ModulosName",gxvar:"A14ModulosName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14ModulosName=n)},v2z:function(n){n!==undefined&&(gx.O.Z14ModulosName=n)},v2c:function(){gx.fn.setControlValue("MODULOSNAME",gx.O.A14ModulosName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A14ModulosName=this.val())},val:function(){return gx.fn.getControlValue("MODULOSNAME")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSDESCRIPCION",gxz:"Z15ModulosDescripcion",gxold:"O15ModulosDescripcion",gxvar:"A15ModulosDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15ModulosDescripcion=n)},v2z:function(n){n!==undefined&&(gx.O.Z15ModulosDescripcion=n)},v2c:function(){gx.fn.setControlValue("MODULOSDESCRIPCION",gx.O.A15ModulosDescripcion,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A15ModulosDescripcion=this.val())},val:function(){return gx.fn.getControlValue("MODULOSDESCRIPCION")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){gx.fn.setCtrlProperty("MODULOSDESCRIPCION","Link",gx.fn.getCtrlProperty("MODULOSDESCRIPCION","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A15ModulosDescripcion))});n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"BTN_ENTER",grid:0,evt:"e11066_client",std:"ENTER"};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTN_CANCEL",grid:0,evt:"e12066_client"};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"BTN_DELETE",grid:0,evt:"e18066_client",std:"DELETE"};this.A13ModulosID=0;this.Z13ModulosID=0;this.O13ModulosID=0;this.A14ModulosName="";this.Z14ModulosName="";this.O14ModulosName="";this.A15ModulosDescripcion="";this.Z15ModulosDescripcion="";this.O15ModulosDescripcion="";this.A13ModulosID=0;this.A14ModulosName="";this.A15ModulosDescripcion="";this.Events={e11066_client:["ENTER",!0],e12066_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EvtParms.VALID_MODULOSID=[[{av:"A13ModulosID",fld:"MODULOSID",pic:"ZZZ9"},{av:"Gx_mode",fld:"vMODE",pic:"@!"}],[{av:"A14ModulosName",fld:"MODULOSNAME",pic:""},{av:"A15ModulosDescripcion",fld:"MODULOSDESCRIPCION",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!"},{av:"Z13ModulosID"},{av:"Z14ModulosName"},{av:"Z15ModulosDescripcion"},{ctrl:"BTN_DELETE",prop:"Enabled"},{ctrl:"BTN_ENTER",prop:"Enabled"}]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.wi(function(){gx.createParentObj(modulos)})