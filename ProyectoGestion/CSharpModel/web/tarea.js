/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:3.93
*/
gx.evt.autoSkip = false;
gx.define('tarea', false, function () {
   this.ServerClass =  "tarea" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Tareaid=function()
   {
      return this.validSrvEvt("Valid_Tareaid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.Valid_Tareapid=function()
   {
      return this.validSrvEvt("Valid_Tareapid", 0).then((function (ret) {
      return ret;
      }).closure(this));
   }
   this.e11065_client=function()
   {
      this.clearMessages();
      this.call("wwproyecto.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e13062_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e14065_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e15065_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80];
   this.GXLastCtrlId =80;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TITLECONTAINER",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TITLE", format:0,grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"FORMCONTAINER",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TOOLBARCELL",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"BTN_FIRST",grid:0,evt:"e16065_client",std:"FIRST"};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"BTN_PREVIOUS",grid:0,evt:"e17065_client",std:"PREVIOUS"};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"BTN_NEXT",grid:0,evt:"e18065_client",std:"NEXT"};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"BTN_LAST",grid:0,evt:"e19065_client",std:"LAST"};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"BTN_SELECT",grid:0,evt:"e20065_client",std:"SELECT"};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tareaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAID",gxz:"Z5TareaID",gxold:"O5TareaID",gxvar:"A5TareaID",ucs:[],op:[58,68,63,53,48,44,39],ip:[58,68,63,53,48,44,39,34],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A5TareaID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z5TareaID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("TAREAID",gx.O.A5TareaID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A5TareaID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("TAREAID",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 34 , function() {
   });
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREANAME",gxz:"Z26TareaName",gxold:"O26TareaName",gxvar:"A26TareaName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A26TareaName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z26TareaName=Value},v2c:function(){gx.fn.setControlValue("TAREANAME",gx.O.A26TareaName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A26TareaName=this.val()},val:function(){return gx.fn.getControlValue("TAREANAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 39 , function() {
   });
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAVERSION",gxz:"Z27TareaVersion",gxold:"O27TareaVersion",gxvar:"A27TareaVersion",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A27TareaVersion=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z27TareaVersion=Value},v2c:function(){gx.fn.setControlValue("TAREAVERSION",gx.O.A27TareaVersion,0)},c2v:function(){if(this.val()!==undefined)gx.O.A27TareaVersion=this.val()},val:function(){return gx.fn.getControlValue("TAREAVERSION")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAPRIORIDAD",gxz:"Z28TareaPrioridad",gxold:"O28TareaPrioridad",gxvar:"A28TareaPrioridad",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A28TareaPrioridad=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z28TareaPrioridad=Value},v2c:function(){gx.fn.setControlValue("TAREAPRIORIDAD",gx.O.A28TareaPrioridad,0)},c2v:function(){if(this.val()!==undefined)gx.O.A28TareaPrioridad=this.val()},val:function(){return gx.fn.getControlValue("TAREAPRIORIDAD")},nac:gx.falseFn};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"char",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAESTADO",gxz:"Z29TareaEstado",gxold:"O29TareaEstado",gxvar:"A29TareaEstado",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A29TareaEstado=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z29TareaEstado=Value},v2c:function(){gx.fn.setComboBoxValue("TAREAESTADO",gx.O.A29TareaEstado)},c2v:function(){if(this.val()!==undefined)gx.O.A29TareaEstado=this.val()},val:function(){return gx.fn.getControlValue("TAREAESTADO")},nac:gx.falseFn};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tareapid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAPID",gxz:"Z6TareaPID",gxold:"O6TareaPID",gxvar:"A6TareaPID",ucs:[],op:[],ip:[58],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A6TareaPID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6TareaPID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("TAREAPID",gx.O.A6TareaPID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A6TareaPID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("TAREAPID",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 58 , function() {
   });
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:1024,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREADESCRIPCION",gxz:"Z30TareaDescripcion",gxold:"O30TareaDescripcion",gxvar:"A30TareaDescripcion",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A30TareaDescripcion=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z30TareaDescripcion=Value},v2c:function(){gx.fn.setControlValue("TAREADESCRIPCION",gx.O.A30TareaDescripcion,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A30TareaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("TAREADESCRIPCION")},nac:gx.falseFn};
   this.declareDomainHdlr( 63 , function() {
      gx.fn.setCtrlProperty("TAREADESCRIPCION","Link", (!gx.fn.getCtrlProperty("TAREADESCRIPCION","Enabled") ? "http://maps.google.com/maps?q="+encodeURIComponent( this.A30TareaDescripcion) : "") );
   });
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:1024,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAOBERSVACION",gxz:"Z31TareaObersvacion",gxold:"O31TareaObersvacion",gxvar:"A31TareaObersvacion",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A31TareaObersvacion=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z31TareaObersvacion=Value},v2c:function(){gx.fn.setControlValue("TAREAOBERSVACION",gx.O.A31TareaObersvacion,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A31TareaObersvacion=this.val()},val:function(){return gx.fn.getControlValue("TAREAOBERSVACION")},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
      gx.fn.setCtrlProperty("TAREAOBERSVACION","Link", (!gx.fn.getCtrlProperty("TAREAOBERSVACION","Enabled") ? "http://maps.google.com/maps?q="+encodeURIComponent( this.A31TareaObersvacion) : "") );
   });
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"BTN_ENTER",grid:0,evt:"e14065_client",std:"ENTER"};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"BTN_CANCEL",grid:0,evt:"e15065_client"};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"BTN_DELETE",grid:0,evt:"e21065_client",std:"DELETE"};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"ATRAS",grid:0,evt:"e11065_client"};
   this.A5TareaID = 0 ;
   this.Z5TareaID = 0 ;
   this.O5TareaID = 0 ;
   this.A26TareaName = "" ;
   this.Z26TareaName = "" ;
   this.O26TareaName = "" ;
   this.A27TareaVersion = "" ;
   this.Z27TareaVersion = "" ;
   this.O27TareaVersion = "" ;
   this.A28TareaPrioridad = "" ;
   this.Z28TareaPrioridad = "" ;
   this.O28TareaPrioridad = "" ;
   this.A29TareaEstado = "" ;
   this.Z29TareaEstado = "" ;
   this.O29TareaEstado = "" ;
   this.A6TareaPID = 0 ;
   this.Z6TareaPID = 0 ;
   this.O6TareaPID = 0 ;
   this.A30TareaDescripcion = "" ;
   this.Z30TareaDescripcion = "" ;
   this.O30TareaDescripcion = "" ;
   this.A31TareaObersvacion = "" ;
   this.Z31TareaObersvacion = "" ;
   this.O31TareaObersvacion = "" ;
   this.AV9WebSession = {} ;
   this.A5TareaID = 0 ;
   this.A26TareaName = "" ;
   this.A27TareaVersion = "" ;
   this.A28TareaPrioridad = "" ;
   this.A29TareaEstado = "" ;
   this.A30TareaDescripcion = "" ;
   this.A31TareaObersvacion = "" ;
   this.A6TareaPID = 0 ;
   this.Events = {"e13062_client": ["AFTER TRN", true] ,"e14065_client": ["ENTER", true] ,"e15065_client": ["CANCEL", true] ,"e11065_client": ["'ATRAS'", false]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[],[]];
   this.EvtParms["AFTER TRN"] = [[],[]];
   this.EvtParms["'ATRAS'"] = [[],[]];
   this.EvtParms["VALID_TAREAID"] = [[{ctrl:'TAREAESTADO'},{av:'A29TareaEstado',fld:'TAREAESTADO',pic:''},{av:'A5TareaID',fld:'TAREAID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}],[{av:'A26TareaName',fld:'TAREANAME',pic:''},{av:'A27TareaVersion',fld:'TAREAVERSION',pic:''},{av:'A28TareaPrioridad',fld:'TAREAPRIORIDAD',pic:''},{ctrl:'TAREAESTADO'},{av:'A29TareaEstado',fld:'TAREAESTADO',pic:''},{av:'A30TareaDescripcion',fld:'TAREADESCRIPCION',pic:''},{av:'A31TareaObersvacion',fld:'TAREAOBERSVACION',pic:''},{av:'A6TareaPID',fld:'TAREAPID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z5TareaID'},{av:'Z26TareaName'},{av:'Z27TareaVersion'},{av:'Z28TareaPrioridad'},{av:'Z29TareaEstado'},{av:'Z30TareaDescripcion'},{av:'Z31TareaObersvacion'},{av:'Z6TareaPID'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]];
   this.EvtParms["VALID_TAREAPID"] = [[{av:'A6TareaPID',fld:'TAREAPID',pic:'ZZZ9'}],[]];
   this.EnterCtrl = ["BTN_ENTER"];
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(tarea);});
