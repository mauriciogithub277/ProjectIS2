/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:2.76
*/
gx.evt.autoSkip = false;
gx.define('estadoproyecto', false, function () {
   this.ServerClass =  "estadoproyecto" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7EstadoProyectoID=gx.fn.getIntegerValue("vESTADOPROYECTOID",gx.thousandSeparator) ;
      this.A40EstadoProyectoApellido=gx.fn.getIntegerValue("ESTADOPROYECTOAPELLIDO",gx.thousandSeparator) ;
      this.A41EstadoProyectoDireccion=gx.fn.getIntegerValue("ESTADOPROYECTODIRECCION",gx.thousandSeparator) ;
      this.A42EstadoProyectoLugarNacimeinto=gx.fn.getIntegerValue("ESTADOPROYECTOLUGARNACIMEINTO",gx.thousandSeparator) ;
      this.AV12Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Estadoproyectoid=function()
   {
      return this.validCliEvt("Valid_Estadoproyectoid", 0, function () {
      try {
         var gxballoon = gx.util.balloon.getNew("ESTADOPROYECTOID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
          if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
      });
   }
   this.e12072_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e13076_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14076_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39];
   this.GXLastCtrlId =39;
   this.DVPANEL_TABLEATTRIBUTESContainer = gx.uc.getNew(this, 16, 0, "BootstrapPanel", "DVPANEL_TABLEATTRIBUTESContainer", "Dvpanel_tableattributes", "DVPANEL_TABLEATTRIBUTES");
   var DVPANEL_TABLEATTRIBUTESContainer = this.DVPANEL_TABLEATTRIBUTESContainer;
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", gx.getMessage( "WWP_TemplateDataPanelTitle"), "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsible", "Collapsible", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("IconPosition", "Iconposition", "right", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEATTRIBUTESContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLECONTENT",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Estadoproyectoid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOPROYECTOID",gxz:"Z7EstadoProyectoID",gxold:"O7EstadoProyectoID",gxvar:"A7EstadoProyectoID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A7EstadoProyectoID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7EstadoProyectoID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("ESTADOPROYECTOID",gx.O.A7EstadoProyectoID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A7EstadoProyectoID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("ESTADOPROYECTOID",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOPROYECTONOMBRE",gxz:"Z34EstadoProyectoNombre",gxold:"O34EstadoProyectoNombre",gxvar:"A34EstadoProyectoNombre",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A34EstadoProyectoNombre=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z34EstadoProyectoNombre=Value},v2c:function(){gx.fn.setControlValue("ESTADOPROYECTONOMBRE",gx.O.A34EstadoProyectoNombre,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A34EstadoProyectoNombre=this.val()},val:function(){return gx.fn.getControlValue("ESTADOPROYECTONOMBRE")},nac:gx.falseFn};
   this.declareDomainHdlr( 30 , function() {
   });
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"BTNTRN_ENTER",grid:0,evt:"e13076_client",std:"ENTER"};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"BTNTRN_CANCEL",grid:0,evt:"e14076_client"};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"BTNTRN_DELETE",grid:0,evt:"e15076_client",std:"DELETE"};
   this.A7EstadoProyectoID = 0 ;
   this.Z7EstadoProyectoID = 0 ;
   this.O7EstadoProyectoID = 0 ;
   this.A34EstadoProyectoNombre = "" ;
   this.Z34EstadoProyectoNombre = "" ;
   this.O34EstadoProyectoNombre = "" ;
   this.AV8WWPContext = {UserId:0,UserName:""} ;
   this.AV9TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV12Pgmname = "" ;
   this.AV7EstadoProyectoID = 0 ;
   this.AV10WebSession = {} ;
   this.A7EstadoProyectoID = 0 ;
   this.A34EstadoProyectoNombre = "" ;
   this.A40EstadoProyectoApellido = 0 ;
   this.A41EstadoProyectoDireccion = 0 ;
   this.A42EstadoProyectoLugarNacimeinto = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e12072_client": ["AFTER TRN", true] ,"e13076_client": ["ENTER", true] ,"e14076_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstadoProyectoID',fld:'vESTADOPROYECTOID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7EstadoProyectoID',fld:'vESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9'},{av:'A40EstadoProyectoApellido',fld:'ESTADOPROYECTOAPELLIDO',pic:'ZZZ9'},{av:'A41EstadoProyectoDireccion',fld:'ESTADOPROYECTODIRECCION',pic:'ZZZ9'},{av:'A42EstadoProyectoLugarNacimeinto',fld:'ESTADOPROYECTOLUGARNACIMEINTO',pic:'ZZZ9'}],[]];
   this.EvtParms["START"] = [[{av:'AV12Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}],[]];
   this.EvtParms["VALID_ESTADOPROYECTOID"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7EstadoProyectoID", "vESTADOPROYECTOID", 0, "int", 4, 0);
   this.setVCMap("A40EstadoProyectoApellido", "ESTADOPROYECTOAPELLIDO", 0, "int", 4, 0);
   this.setVCMap("A41EstadoProyectoDireccion", "ESTADOPROYECTODIRECCION", 0, "int", 4, 0);
   this.setVCMap("A42EstadoProyectoLugarNacimeinto", "ESTADOPROYECTOLUGARNACIMEINTO", 0, "int", 4, 0);
   this.setVCMap("AV12Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV9TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(estadoproyecto);});
