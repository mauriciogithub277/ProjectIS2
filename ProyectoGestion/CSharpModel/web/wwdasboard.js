/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 17:59:59.62
*/
gx.evt.autoSkip = false;
gx.define('wwdasboard', false, function () {
   this.ServerClass =  "wwdasboard" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.anyGridBaseTable = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV21rolUser=gx.fn.getControlValue("vROLUSER") ;
      this.AV21rolUser=gx.fn.getControlValue("vROLUSER") ;
   };
   this.e120g1_client=function()
   {
      this.clearMessages();
      if ( this.AV21rolUser == gx.getMessage( "Administrador") )
      {
         this.call("wwadmin.aspx", []);
      }
      else
      {
         this.AV8ErrorPerfil =  gx.getMessage( "Bloquedo")  ;
      }
      this.refreshOutputs([{av:'AV8ErrorPerfil',fld:'vERRORPERFIL',pic:''}]);
      return gx.$.Deferred().resolve();
   };
   this.e130g1_client=function()
   {
      this.clearMessages();
      this.call("wwproyect.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e140g1_client=function()
   {
      this.clearMessages();
      this.call("wconfig.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e150g2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e160g2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,21,22,23,26,29,32,35,38,39,40,41,42];
   this.GXLastCtrlId =42;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",37,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"wwdasboard",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px",gx.getMessage( "GXM_newrow"),false,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var Grid1Container = this.Grid1Container;
   Grid1Container.addSingleLineEdit(4,38,"PROYECTOID",gx.getMessage( "Proyecto ID"),"","ProyectoID","int",0,"px",4,4,"right",null,[],4,"ProyectoID",true,0,false,false,"Attribute",1,"");
   Grid1Container.addSingleLineEdit(20,39,"PROYECTONAME",gx.getMessage( "Nombre Proyecto"),"","ProyectoName","char",0,"px",40,40,"left",null,[],20,"ProyectoName",true,0,false,false,"Attribute",1,"");
   Grid1Container.addSingleLineEdit(21,40,"PROYECTOFECINICIO",gx.getMessage( "Fecha Inicio"),"","ProyectoFecInicio","date",0,"px",8,8,"right",null,[],21,"ProyectoFecInicio",true,0,false,false,"Attribute",1,"");
   Grid1Container.addSingleLineEdit(22,41,"PROYECTOFECFIN",gx.getMessage( "Fecha Fin"),"","ProyectoFecFin","date",0,"px",8,8,"right",null,[],22,"ProyectoFecFin",true,0,false,false,"Attribute",1,"");
   Grid1Container.addSingleLineEdit(23,42,"PROYECTOESTADO",gx.getMessage( "Estado"),"","ProyectoEstado","char",0,"px",30,30,"left",null,[],23,"ProyectoEstado",true,0,false,false,"Attribute",1,"");
   this.Grid1Container.emptyText = gx.getMessage( "");
   this.setGrid(Grid1Container);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLETOP",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TITLETEXT", format:0,grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id:14 ,lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vERRORPERFIL",gxz:"ZV8ErrorPerfil",gxold:"OV8ErrorPerfil",gxvar:"AV8ErrorPerfil",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV8ErrorPerfil=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV8ErrorPerfil=Value},v2c:function(){gx.fn.setControlValue("vERRORPERFIL",gx.O.AV8ErrorPerfil,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV8ErrorPerfil=this.val()},val:function(){return gx.fn.getControlValue("vERRORPERFIL")},nac:gx.falseFn};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"GRIDCELL",grid:0};
   GXValidFnc[17]={ id: 17, fld:"GRIDTABLE",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TABLE2",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TABLE1",grid:0};
   GXValidFnc[29]={ id: 29, fld:"ADMINISTRACION",grid:0,evt:"e120g1_client"};
   GXValidFnc[32]={ id: 32, fld:"MODULODESARROLLO",grid:0,evt:"e130g1_client"};
   GXValidFnc[35]={ id: 35, fld:"MODULOCONFIGURACION",grid:0,evt:"e140g1_client"};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:37,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTOID",gxz:"Z4ProyectoID",gxold:"O4ProyectoID",gxvar:"A4ProyectoID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A4ProyectoID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4ProyectoID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("PROYECTOID",row || gx.fn.currentGridRowImpl(37),gx.O.A4ProyectoID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A4ProyectoID=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("PROYECTOID",row || gx.fn.currentGridRowImpl(37),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"char",len:40,dec:0,sign:false,ro:1,isacc:0,grid:37,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTONAME",gxz:"Z20ProyectoName",gxold:"O20ProyectoName",gxvar:"A20ProyectoName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A20ProyectoName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z20ProyectoName=Value},v2c:function(row){gx.fn.setGridControlValue("PROYECTONAME",row || gx.fn.currentGridRowImpl(37),gx.O.A20ProyectoName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A20ProyectoName=this.val(row)},val:function(row){return gx.fn.getGridControlValue("PROYECTONAME",row || gx.fn.currentGridRowImpl(37))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,isacc:0,grid:37,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTOFECINICIO",gxz:"Z21ProyectoFecInicio",gxold:"O21ProyectoFecInicio",gxvar:"A21ProyectoFecInicio",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A21ProyectoFecInicio=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z21ProyectoFecInicio=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("PROYECTOFECINICIO",row || gx.fn.currentGridRowImpl(37),gx.O.A21ProyectoFecInicio,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.A21ProyectoFecInicio=gx.fn.toDatetimeValue(this.val(row))},val:function(row){return gx.fn.getGridDateTimeValue("PROYECTOFECINICIO",row || gx.fn.currentGridRowImpl(37))},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,isacc:0,grid:37,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTOFECFIN",gxz:"Z22ProyectoFecFin",gxold:"O22ProyectoFecFin",gxvar:"A22ProyectoFecFin",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A22ProyectoFecFin=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z22ProyectoFecFin=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("PROYECTOFECFIN",row || gx.fn.currentGridRowImpl(37),gx.O.A22ProyectoFecFin,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.A22ProyectoFecFin=gx.fn.toDatetimeValue(this.val(row))},val:function(row){return gx.fn.getGridDateTimeValue("PROYECTOFECFIN",row || gx.fn.currentGridRowImpl(37))},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,isacc:0,grid:37,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTOESTADO",gxz:"Z23ProyectoEstado",gxold:"O23ProyectoEstado",gxvar:"A23ProyectoEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A23ProyectoEstado=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z23ProyectoEstado=Value},v2c:function(row){gx.fn.setGridControlValue("PROYECTOESTADO",row || gx.fn.currentGridRowImpl(37),gx.O.A23ProyectoEstado,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A23ProyectoEstado=this.val(row)},val:function(row){return gx.fn.getGridControlValue("PROYECTOESTADO",row || gx.fn.currentGridRowImpl(37))},nac:gx.falseFn};
   this.AV8ErrorPerfil = "" ;
   this.ZV8ErrorPerfil = "" ;
   this.OV8ErrorPerfil = "" ;
   this.Z4ProyectoID = 0 ;
   this.O4ProyectoID = 0 ;
   this.Z20ProyectoName = "" ;
   this.O20ProyectoName = "" ;
   this.Z21ProyectoFecInicio = gx.date.nullDate() ;
   this.O21ProyectoFecInicio = gx.date.nullDate() ;
   this.Z22ProyectoFecFin = gx.date.nullDate() ;
   this.O22ProyectoFecFin = gx.date.nullDate() ;
   this.Z23ProyectoEstado = "" ;
   this.O23ProyectoEstado = "" ;
   this.AV8ErrorPerfil = "" ;
   this.AV21rolUser = "" ;
   this.A4ProyectoID = 0 ;
   this.A20ProyectoName = "" ;
   this.A21ProyectoFecInicio = gx.date.nullDate() ;
   this.A22ProyectoFecFin = gx.date.nullDate() ;
   this.A23ProyectoEstado = "" ;
   this.Events = {"e150g2_client": ["ENTER", true] ,"e160g2_client": ["CANCEL", true] ,"e120g1_client": ["'ADMINISTRACIóN'", false] ,"e130g1_client": ["'MODULO DESARROLLO'", false] ,"e140g1_client": ["'MODULO CONFIGURACION'", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'AV21rolUser',fld:'vROLUSER',pic:'',hsh:true}],[]];
   this.EvtParms["'ADMINISTRACIóN'"] = [[{av:'AV21rolUser',fld:'vROLUSER',pic:'',hsh:true}],[{av:'AV8ErrorPerfil',fld:'vERRORPERFIL',pic:''}]];
   this.EvtParms["'MODULO DESARROLLO'"] = [[],[]];
   this.EvtParms["'MODULO CONFIGURACION'"] = [[],[]];
   this.setVCMap("AV21rolUser", "vROLUSER", 0, "char", 20, 0);
   this.setVCMap("AV21rolUser", "vROLUSER", 0, "char", 20, 0);
   Grid1Container.addRefreshingVar({rfrVar:"AV21rolUser"});
   Grid1Container.addRefreshingParm({rfrVar:"AV21rolUser"});
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(wwdasboard);});
