/*!   GeneXus C# 16_0_7-138086 on 8/24/2020 21:14:8.98
*/
gx.evt.autoSkip=!1;gx.define("proyectogestionproyectwc",!0,function(n){var t,i;this.ServerClass="proyectogestionproyectwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6ProyectoID=gx.fn.getIntegerValue("vPROYECTOID",gx.thousandSeparator);this.AV6ProyectoID=gx.fn.getIntegerValue("vPROYECTOID",gx.thousandSeparator)};this.e130q2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e140q2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,15,16,17];this.GXLastCtrlId=17;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"proyectogestionproyectwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px",gx.getMessage("GXM_newrow"),!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(8,13,"GESTIONPROYECTID",gx.getMessage("Proyect ID"),"","GestionProyectID","int",0,"px",4,4,"right",null,[],8,"GestionProyectID",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.GridContainer.emptyText=gx.getMessage("");this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"GRIDCELL",grid:0};t[6]={id:6,fld:"GRIDTABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[13]={id:13,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"GESTIONPROYECTID",gxz:"Z8GestionProyectID",gxold:"O8GestionProyectID",gxvar:"A8GestionProyectID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A8GestionProyectID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z8GestionProyectID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("GESTIONPROYECTID",n||gx.fn.currentGridRowImpl(12),gx.O.A8GestionProyectID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A8GestionProyectID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("GESTIONPROYECTID",n||gx.fn.currentGridRowImpl(12),gx.thousandSeparator)},nac:gx.falseFn};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROYECTOID",gxz:"Z4ProyectoID",gxold:"O4ProyectoID",gxvar:"A4ProyectoID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4ProyectoID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4ProyectoID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROYECTOID",gx.O.A4ProyectoID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4ProyectoID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROYECTOID",gx.thousandSeparator)},nac:gx.falseFn};this.declareDomainHdlr(17,function(){});this.Z8GestionProyectID=0;this.O8GestionProyectID=0;this.A4ProyectoID=0;this.Z4ProyectoID=0;this.O4ProyectoID=0;this.A4ProyectoID=0;this.AV6ProyectoID=0;this.A8GestionProyectID=0;this.Events={e130q2_client:["ENTER",!0],e140q2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6ProyectoID",fld:"vPROYECTOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("PROYECTOID","Visible")',ctrl:"PROYECTOID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6ProyectoID",fld:"vPROYECTOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6ProyectoID",fld:"vPROYECTOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6ProyectoID",fld:"vPROYECTOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6ProyectoID",fld:"vPROYECTOID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.setVCMap("AV6ProyectoID","vPROYECTOID",0,"int",4,0);this.setVCMap("AV6ProyectoID","vPROYECTOID",0,"int",4,0);this.setVCMap("AV6ProyectoID","vPROYECTOID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6ProyectoID"});i.addRefreshingParm({rfrVar:"AV6ProyectoID"});this.Initialize()})