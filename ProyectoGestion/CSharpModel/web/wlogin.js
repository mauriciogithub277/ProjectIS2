/*!   GeneXus C# 16_0_7-138086 on 3/14/2020 16:58:26.37
*/
gx.evt.autoSkip=!1;gx.define("wlogin",!1,function(){this.ServerClass="wlogin";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A2Name=gx.fn.getControlValue("NAME");this.A3Password=gx.fn.getControlValue("PASSWORD");this.A9RolesName=gx.fn.getControlValue("ROLESNAME")};this.e11082_client=function(){return this.executeServerEvent("'INICIAR'",!1,null,!1,!1)};this.e13082_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14082_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,9,12,13,14,16,17,18,21,22,23,25,26,27,28,29,30,31,32,33,34,35];this.GXLastCtrlId=35;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLE1",grid:0};n[9]={id:9,fld:"TEXTBLOCK1",format:0,grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSUARIO",gxz:"ZV5usuario",gxold:"OV5usuario",gxvar:"AV5usuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5usuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5usuario=n)},v2c:function(){gx.fn.setControlValue("vUSUARIO",gx.O.AV5usuario,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.AV5usuario=this.val())},val:function(){return gx.fn.getControlValue("vUSUARIO")},nac:gx.falseFn};this.declareDomainHdlr(14,function(){});n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vTEXTERROR",gxz:"ZV10textError",gxold:"OV10textError",gxvar:"AV10textError",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10textError=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10textError=n)},v2c:function(){gx.fn.setControlValue("vTEXTERROR",gx.O.AV10textError,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10textError=this.val())},val:function(){return gx.fn.getControlValue("vTEXTERROR")},nac:gx.falseFn};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,lvl:0,type:"char",len:20,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPASSWORD",gxz:"ZV9password",gxold:"OV9password",gxvar:"AV9password",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9password=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9password=n)},v2c:function(){gx.fn.setControlValue("vPASSWORD",gx.O.AV9password,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9password=this.val())},val:function(){return gx.fn.getControlValue("vPASSWORD")},nac:gx.falseFn};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vTEXTERROR2",gxz:"ZV11textError2",gxold:"OV11textError2",gxvar:"AV11textError2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11textError2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11textError2=n)},v2c:function(){gx.fn.setControlValue("vTEXTERROR2",gx.O.AV11textError2,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11textError2=this.val())},val:function(){return gx.fn.getControlValue("vTEXTERROR2")},nac:gx.falseFn};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"INICIAR",grid:0,evt:"e11082_client"};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"char",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLOGINERROR",gxz:"ZV14LoginError",gxold:"OV14LoginError",gxvar:"AV14LoginError",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14LoginError=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14LoginError=n)},v2c:function(){gx.fn.setControlValue("vLOGINERROR",gx.O.AV14LoginError,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14LoginError=this.val())},val:function(){return gx.fn.getControlValue("vLOGINERROR")},nac:gx.falseFn};this.AV5usuario="";this.ZV5usuario="";this.OV5usuario="";this.AV10textError="";this.ZV10textError="";this.OV10textError="";this.AV9password="";this.ZV9password="";this.OV9password="";this.AV11textError2="";this.ZV11textError2="";this.OV11textError2="";this.AV14LoginError="";this.ZV14LoginError="";this.OV14LoginError="";this.AV5usuario="";this.AV10textError="";this.AV9password="";this.AV11textError2="";this.AV14LoginError="";this.A3Password="";this.A2Name="";this.A9RolesName="";this.A8RolesID=0;this.Events={e11082_client:["'INICIAR'",!0],e13082_client:["ENTER",!0],e14082_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"A2Name",fld:"NAME",pic:"",hsh:!0},{av:"A3Password",fld:"PASSWORD",pic:"",hsh:!0}],[]];this.EvtParms["'INICIAR'"]=[[{av:"AV5usuario",fld:"vUSUARIO",pic:""},{av:"AV9password",fld:"vPASSWORD",pic:""},{av:"A2Name",fld:"NAME",pic:"",hsh:!0},{av:"A3Password",fld:"PASSWORD",pic:"",hsh:!0},{av:"A9RolesName",fld:"ROLESNAME",pic:""}],[{av:"AV10textError",fld:"vTEXTERROR",pic:""},{av:"AV11textError2",fld:"vTEXTERROR2",pic:""},{av:"AV14LoginError",fld:"vLOGINERROR",pic:""}]];this.setVCMap("A2Name","NAME",0,"char",20,0);this.setVCMap("A3Password","PASSWORD",0,"char",20,0);this.setVCMap("A9RolesName","ROLESNAME",0,"char",20,0);this.Initialize()});gx.wi(function(){gx.createParentObj(wlogin)})