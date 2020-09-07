/*!   GeneXus C# 16_0_7-138086 on 8/24/2020 21:27:51.95
*/
gx.evt.autoSkip=!1;gx.define("rolesgeneral",!0,function(n){this.ServerClass="rolesgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Rolesid=function(){return this.validCliEvt("Valid_Rolesid",0,function(){try{var n=gx.util.balloon.getNew("ROLESID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.Valid_Modulosid=function(){return this.validCliEvt("Valid_Modulosid",0,function(){try{var n=gx.util.balloon.getNew("MODULOSID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e110l1_client=function(){return this.clearMessages(),this.call("roles.aspx",["UPD",this.A2RolesID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120l1_client=function(){return this.clearMessages(),this.call("roles.aspx",["DLT",this.A2RolesID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150l2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160l2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0,evt:"e110l1_client"};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0,evt:"e120l1_client"};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Rolesid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLESID",gxz:"Z2RolesID",gxold:"O2RolesID",gxvar:"A2RolesID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2RolesID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2RolesID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ROLESID",gx.O.A2RolesID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A2RolesID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ROLESID",gx.thousandSeparator)},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLESNAME",gxz:"Z15RolesName",gxold:"O15RolesName",gxvar:"A15RolesName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15RolesName=n)},v2z:function(n){n!==undefined&&(gx.O.Z15RolesName=n)},v2c:function(){gx.fn.setControlValue("ROLESNAME",gx.O.A15RolesName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A15RolesName=this.val())},val:function(){return gx.fn.getControlValue("ROLESNAME")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Modulosid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSID",gxz:"Z3ModulosID",gxold:"O3ModulosID",gxvar:"A3ModulosID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3ModulosID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3ModulosID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("MODULOSID",gx.O.A3ModulosID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A3ModulosID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("MODULOSID",gx.thousandSeparator)},nac:gx.falseFn};this.declareDomainHdlr(28,function(){});t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSNAME",gxz:"Z18ModulosName",gxold:"O18ModulosName",gxvar:"A18ModulosName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A18ModulosName=n)},v2z:function(n){n!==undefined&&(gx.O.Z18ModulosName=n)},v2c:function(){gx.fn.setControlValue("MODULOSNAME",gx.O.A18ModulosName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A18ModulosName=this.val())},val:function(){return gx.fn.getControlValue("MODULOSNAME")},nac:gx.falseFn};this.declareDomainHdlr(33,function(){});this.A2RolesID=0;this.Z2RolesID=0;this.O2RolesID=0;this.A15RolesName="";this.Z15RolesName="";this.O15RolesName="";this.A3ModulosID=0;this.Z3ModulosID=0;this.O3ModulosID=0;this.A18ModulosName="";this.Z18ModulosName="";this.O18ModulosName="";this.A2RolesID=0;this.A15RolesName="";this.A3ModulosID=0;this.A18ModulosName="";this.Events={e150l2_client:["ENTER",!0],e160l2_client:["CANCEL",!0],e110l1_client:["'DOUPDATE'",!1],e120l1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A2RolesID",fld:"ROLESID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6RolesID",fld:"vROLESID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A2RolesID",fld:"ROLESID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A2RolesID",fld:"ROLESID",pic:"ZZZ9"}],[]];this.EvtParms.VALID_ROLESID=[[],[]];this.EvtParms.VALID_MODULOSID=[[],[]];this.Initialize()})