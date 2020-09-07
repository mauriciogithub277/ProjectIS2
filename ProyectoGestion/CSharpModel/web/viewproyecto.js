/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:1.34
*/
gx.evt.autoSkip = false;
gx.define('viewproyecto', false, function () {
   this.ServerClass =  "viewproyecto" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV12ProyectoID=gx.fn.getIntegerValue("vPROYECTOID",gx.thousandSeparator) ;
      this.AV6TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV12ProyectoID=gx.fn.getIntegerValue("vPROYECTOID",gx.thousandSeparator) ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      if ( this.AV11LoadAllTabs || ( this.AV7SelectedTabCode == "" ) || ( this.AV7SelectedTabCode == gx.getMessage( "General") ) )
      {
         this.createWebComponent('Generalwc','ProyectoGeneral',[this.AV12ProyectoID]);
      }
      if ( this.AV11LoadAllTabs || ( this.AV7SelectedTabCode == gx.getMessage( "GestionProyect") ) )
      {
         this.createWebComponent('Gestionproyectwc','ProyectoGestionProyectWC',[this.AV12ProyectoID]);
      }
   };
   this.e130o1_client=function()
   {
      this.clearMessages();
      this.AV7SelectedTabCode =  this.TABContainer.ActivePageControlName  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{ctrl:'GENERALWC'},{ctrl:'GESTIONPROYECTWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e140o2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e150o2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29,32,33,35,36,37];
   this.GXLastCtrlId =37;
   this.TABContainer = gx.uc.getNew(this, 22, 19, "gx.ui.controls.Tab", "TABContainer", "Tab", "TAB");
   var TABContainer = this.TABContainer;
   TABContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABContainer.setProp("ActivePage", "Activepage", '', "int");
   TABContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABContainer.setProp("PageCount", "Pagecount", 2, "num");
   TABContainer.setProp("Class", "Class", "WWTab", "str");
   TABContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABContainer.setProp("Visible", "Visible", true, "bool");
   TABContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABContainer.addEventHandler("TabChanged", this.e130o1_client);
   this.setUserControl(TABContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLETOP",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"VIEWTITLE", format:0,grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"VIEWALL", format:0,grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABTABLE_1",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTONAME",gxz:"Z20ProyectoName",gxold:"O20ProyectoName",gxvar:"A20ProyectoName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A20ProyectoName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z20ProyectoName=Value},v2c:function(){gx.fn.setControlValue("PROYECTONAME",gx.O.A20ProyectoName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A20ProyectoName=this.val()},val:function(){return gx.fn.getControlValue("PROYECTONAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 19 , function() {
   });
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"TABLEGENERAL",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"GESTIONPROYECT_TITLE", format:0,grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"TABLEGESTIONPROYECT",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   this.A20ProyectoName = "" ;
   this.Z20ProyectoName = "" ;
   this.O20ProyectoName = "" ;
   this.A20ProyectoName = "" ;
   this.AV12ProyectoID = 0 ;
   this.AV6TabCode = "" ;
   this.A4ProyectoID = 0 ;
   this.AV11LoadAllTabs = false ;
   this.AV7SelectedTabCode = "" ;
   this.Events = {"e140o2_client": ["ENTER", true] ,"e150o2_client": ["CANCEL", true] ,"e130o1_client": ["TAB.TABCHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV12ProyectoID',fld:'vPROYECTOID',pic:'ZZZ9',hsh:true},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A20ProyectoName',fld:'PROYECTONAME',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'AV15Pgmname',fld:'vPGMNAME',pic:''},{av:'A4ProyectoID',fld:'PROYECTOID',pic:'ZZZ9'},{av:'AV12ProyectoID',fld:'vPROYECTOID',pic:'ZZZ9',hsh:true},{av:'A20ProyectoName',fld:'PROYECTONAME',pic:''},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("VIEWALL","Link")',ctrl:'VIEWALL',prop:'Link'},{av:'gx.fn.getCtrlProperty("VIEWALL","Visible")',ctrl:'VIEWALL',prop:'Visible'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABContainer.ActivePageControlName',ctrl:'TAB',prop:'ActivePageControlName'},{ctrl:'GENERALWC'},{ctrl:'GESTIONPROYECTWC'}]];
   this.EvtParms["TAB.TABCHANGED"] = [[{av:'this.TABContainer.ActivePageControlName',ctrl:'TAB',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV12ProyectoID',fld:'vPROYECTOID',pic:'ZZZ9',hsh:true}],[{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{ctrl:'GENERALWC'},{ctrl:'GESTIONPROYECTWC'}]];
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV7SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV12ProyectoID", "vPROYECTOID", 0, "int", 4, 0);
   this.setVCMap("AV6TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV12ProyectoID", "vPROYECTOID", 0, "int", 4, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV7SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0030" , lvl: 1 });
   this.setComponent({id: "GESTIONPROYECTWC" ,GXClass: null , Prefix: "W0038" , lvl: 1 });
});
gx.wi( function() { gx.createParentObj(viewproyecto);});
