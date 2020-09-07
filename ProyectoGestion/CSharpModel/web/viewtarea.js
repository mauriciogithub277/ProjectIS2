/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:1.65
*/
gx.evt.autoSkip = false;
gx.define('viewtarea', false, function () {
   this.ServerClass =  "viewtarea" ;
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
      this.AV12TareaID=gx.fn.getIntegerValue("vTAREAID",gx.thousandSeparator) ;
      this.AV6TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV12TareaID=gx.fn.getIntegerValue("vTAREAID",gx.thousandSeparator) ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      if ( this.AV11LoadAllTabs || ( this.AV7SelectedTabCode == "" ) || ( this.AV7SelectedTabCode == gx.getMessage( "General") ) )
      {
         this.createWebComponent('Generalwc','TareaGeneral',[this.AV12TareaID]);
      }
   };
   this.e130r1_client=function()
   {
      this.clearMessages();
      this.AV7SelectedTabCode =  this.TABContainer.ActivePageControlName  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{ctrl:'GENERALWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e140r2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e150r2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29];
   this.GXLastCtrlId =29;
   this.TABContainer = gx.uc.getNew(this, 22, 19, "gx.ui.controls.Tab", "TABContainer", "Tab", "TAB");
   var TABContainer = this.TABContainer;
   TABContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABContainer.setProp("ActivePage", "Activepage", '', "int");
   TABContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABContainer.setProp("PageCount", "Pagecount", 1, "num");
   TABContainer.setProp("Class", "Class", "WWTab", "str");
   TABContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABContainer.setProp("Visible", "Visible", true, "bool");
   TABContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABContainer.addEventHandler("TabChanged", this.e130r1_client);
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
   GXValidFnc[19]={ id:19 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREANAME",gxz:"Z26TareaName",gxold:"O26TareaName",gxvar:"A26TareaName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A26TareaName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z26TareaName=Value},v2c:function(){gx.fn.setControlValue("TAREANAME",gx.O.A26TareaName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A26TareaName=this.val()},val:function(){return gx.fn.getControlValue("TAREANAME")},nac:gx.falseFn};
   this.declareDomainHdlr( 19 , function() {
   });
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"TABLEGENERAL",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   this.A26TareaName = "" ;
   this.Z26TareaName = "" ;
   this.O26TareaName = "" ;
   this.A26TareaName = "" ;
   this.AV12TareaID = 0 ;
   this.AV6TabCode = "" ;
   this.A5TareaID = 0 ;
   this.AV11LoadAllTabs = false ;
   this.AV7SelectedTabCode = "" ;
   this.Events = {"e140r2_client": ["ENTER", true] ,"e150r2_client": ["CANCEL", true] ,"e130r1_client": ["TAB.TABCHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV12TareaID',fld:'vTAREAID',pic:'ZZZ9',hsh:true},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A26TareaName',fld:'TAREANAME',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'AV15Pgmname',fld:'vPGMNAME',pic:''},{av:'A5TareaID',fld:'TAREAID',pic:'ZZZ9'},{av:'AV12TareaID',fld:'vTAREAID',pic:'ZZZ9',hsh:true},{av:'A26TareaName',fld:'TAREANAME',pic:''},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("VIEWALL","Link")',ctrl:'VIEWALL',prop:'Link'},{av:'gx.fn.getCtrlProperty("VIEWALL","Visible")',ctrl:'VIEWALL',prop:'Visible'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABContainer.ActivePageControlName',ctrl:'TAB',prop:'ActivePageControlName'},{ctrl:'GENERALWC'}]];
   this.EvtParms["TAB.TABCHANGED"] = [[{av:'this.TABContainer.ActivePageControlName',ctrl:'TAB',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV12TareaID',fld:'vTAREAID',pic:'ZZZ9',hsh:true}],[{av:'AV7SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{ctrl:'GENERALWC'}]];
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV7SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV12TareaID", "vTAREAID", 0, "int", 4, 0);
   this.setVCMap("AV6TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV12TareaID", "vTAREAID", 0, "int", 4, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV7SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0030" , lvl: 1 });
});
gx.wi( function() { gx.createParentObj(viewtarea);});
