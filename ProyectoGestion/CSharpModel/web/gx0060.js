/*!   GeneXus C# 16_0_7-138086 on 3/14/2020 11:48:28.51
*/
gx.evt.autoSkip=!1;gx.define("gx0060",!1,function(){var n,t;this.ServerClass="gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pModulosID=gx.fn.getIntegerValue("vPMODULOSID",",")};this.e130u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MODULOSIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODULOSIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODULOSID","Visible",!0)):(gx.fn.setCtrlProperty("MODULOSIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODULOSID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODULOSIDFILTERCONTAINER","Class")',ctrl:"MODULOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODULOSID","Visible")',ctrl:"vCMODULOSID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120u1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMODULOSNAME","Visible",!0)):(gx.fn.setCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMODULOSNAME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class")',ctrl:"MODULOSNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODULOSNAME","Visible")',ctrl:"vCMODULOSNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160u2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170u1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40];this.GXLastCtrlId=40;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(13,36,"MODULOSID","ID","","ModulosID","int",0,"px",4,4,"right",null,[],13,"ModulosID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(14,37,"MODULOSNAME","Name","","ModulosName","char",0,"px",20,20,"left",null,[],14,"ModulosName",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"MODULOSIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLMODULOSIDFILTER",format:1,grid:0,evt:"e110u1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMODULOSID",gxz:"ZV6cModulosID",gxold:"OV6cModulosID",gxvar:"AV6cModulosID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cModulosID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cModulosID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMODULOSID",gx.O.AV6cModulosID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cModulosID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMODULOSID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"MODULOSNAMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLMODULOSNAMEFILTER",format:1,grid:0,evt:"e120u1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCMODULOSNAME",gxz:"ZV7cModulosName",gxold:"OV7cModulosName",gxvar:"AV7cModulosName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cModulosName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cModulosName=n)},v2c:function(){gx.fn.setControlValue("vCMODULOSNAME",gx.O.AV7cModulosName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cModulosName=this.val())},val:function(){return gx.fn.getControlValue("vCMODULOSNAME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0,evt:"e130u1_client"};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV13Linkselection_GXI)},c2v:function(n){gx.O.AV13Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV13Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSID",gxz:"Z13ModulosID",gxold:"O13ModulosID",gxvar:"A13ModulosID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A13ModulosID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13ModulosID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MODULOSID",n||gx.fn.currentGridRowImpl(34),gx.O.A13ModulosID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A13ModulosID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("MODULOSID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"MODULOSNAME",gxz:"Z14ModulosName",gxold:"O14ModulosName",gxvar:"A14ModulosName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A14ModulosName=n)},v2z:function(n){n!==undefined&&(gx.O.Z14ModulosName=n)},v2c:function(n){gx.fn.setGridControlValue("MODULOSNAME",n||gx.fn.currentGridRowImpl(34),gx.O.A14ModulosName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A14ModulosName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("MODULOSNAME",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0,evt:"e170u1_client"};this.AV6cModulosID=0;this.ZV6cModulosID=0;this.OV6cModulosID=0;this.AV7cModulosName="";this.ZV7cModulosName="";this.OV7cModulosName="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z13ModulosID=0;this.O13ModulosID=0;this.Z14ModulosName="";this.O14ModulosName="";this.AV6cModulosID=0;this.AV7cModulosName="";this.AV9pModulosID=0;this.AV5LinkSelection="";this.A13ModulosID=0;this.A14ModulosName="";this.Events={e160u2_client:["ENTER",!0],e170u1_client:["CANCEL",!0],e130u1_client:["'TOGGLE'",!1],e110u1_client:["LBLMODULOSIDFILTER.CLICK",!1],e120u1_client:["LBLMODULOSNAMEFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModulosID",fld:"vCMODULOSID",pic:"ZZZ9"},{av:"AV7cModulosName",fld:"vCMODULOSNAME",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMODULOSIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODULOSIDFILTERCONTAINER","Class")',ctrl:"MODULOSIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODULOSIDFILTERCONTAINER","Class")',ctrl:"MODULOSIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODULOSID","Visible")',ctrl:"vCMODULOSID",prop:"Visible"}]];this.EvtParms["LBLMODULOSNAMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class")',ctrl:"MODULOSNAMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MODULOSNAMEFILTERCONTAINER","Class")',ctrl:"MODULOSNAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMODULOSNAME","Visible")',ctrl:"vCMODULOSNAME",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A13ModulosID",fld:"MODULOSID",pic:"ZZZ9",hsh:!0}],[{av:"AV9pModulosID",fld:"vPMODULOSID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModulosID",fld:"vCMODULOSID",pic:"ZZZ9"},{av:"AV7cModulosName",fld:"vCMODULOSNAME",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModulosID",fld:"vCMODULOSID",pic:"ZZZ9"},{av:"AV7cModulosName",fld:"vCMODULOSNAME",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModulosID",fld:"vCMODULOSID",pic:"ZZZ9"},{av:"AV7cModulosName",fld:"vCMODULOSNAME",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cModulosID",fld:"vCMODULOSID",pic:"ZZZ9"},{av:"AV7cModulosName",fld:"vCMODULOSNAME",pic:""}],[]];this.setVCMap("AV9pModulosID","vPMODULOSID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0060)})