/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 17:59:57.87
*/
gx.evt.autoSkip = false;
gx.define('rolesusuariowc', true, function (CmpContext) {
   this.ServerClass =  "rolesusuariowc" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.anyGridBaseTable = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV6RolesID=gx.fn.getIntegerValue("vROLESID",gx.thousandSeparator) ;
      this.AV6RolesID=gx.fn.getIntegerValue("vROLESID",gx.thousandSeparator) ;
   };
   this.e110m2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e140m2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e150m2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29];
   this.GXLastCtrlId =29;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"rolesusuariowc",[],false,1,false,true,0,true,false,false,"",0,"px",0,"px",gx.getMessage( "GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(1,21,"USUARIOID",gx.getMessage( "ID"),"","UsuarioID","int",0,"px",4,4,"right",null,[],1,"UsuarioID",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(9,22,"NAME",gx.getMessage( "Name"),"","Name","char",0,"px",40,40,"left",null,[],9,"Name",true,0,false,false,"DescriptionAttribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(10,23,"PASSWORD",gx.getMessage( "Password"),"","Password","char",0,"px",20,20,"left",null,[],10,"Password",false,0,false,true,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit("Update",24,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",true,0,false,false,"TextActionAttribute",1,"WWTextActionColumn");
   GridContainer.addSingleLineEdit("Delete",25,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",true,0,false,false,"TextActionAttribute",1,"WWTextActionColumn");
   this.GridContainer.emptyText = gx.getMessage( "");
   this.setGrid(GridContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLETOP",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"BTNINSERT",grid:0,evt:"e110m2_client"};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"GRIDCELL",grid:0};
   GXValidFnc[14]={ id: 14, fld:"GRIDTABLE",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[21]={ id:21 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z1UsuarioID",gxold:"O1UsuarioID",gxvar:"A1UsuarioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1UsuarioID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1UsuarioID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("USUARIOID",row || gx.fn.currentGridRowImpl(20),gx.O.A1UsuarioID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A1UsuarioID=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("USUARIOID",row || gx.fn.currentGridRowImpl(20),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[22]={ id:22 ,lvl:2,type:"char",len:40,dec:0,sign:false,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NAME",gxz:"Z9Name",gxold:"O9Name",gxvar:"A9Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A9Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z9Name=Value},v2c:function(row){gx.fn.setGridControlValue("NAME",row || gx.fn.currentGridRowImpl(20),gx.O.A9Name,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A9Name=this.val(row)},val:function(row){return gx.fn.getGridControlValue("NAME",row || gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};
   GXValidFnc[23]={ id:23 ,lvl:2,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PASSWORD",gxz:"Z10Password",gxold:"O10Password",gxvar:"A10Password",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A10Password=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z10Password=Value},v2c:function(row){gx.fn.setGridControlValue("PASSWORD",row || gx.fn.currentGridRowImpl(20),gx.O.A10Password,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A10Password=this.val(row)},val:function(row){return gx.fn.getGridControlValue("PASSWORD",row || gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};
   GXValidFnc[24]={ id:24 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV11Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11Update=Value},v2c:function(row){gx.fn.setGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(20),gx.O.AV11Update,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV11Update=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};
   GXValidFnc[25]={ id:25 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV12Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12Delete=Value},v2c:function(row){gx.fn.setGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV12Delete=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLESID",gxz:"Z2RolesID",gxold:"O2RolesID",gxvar:"A2RolesID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A2RolesID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2RolesID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("ROLESID",gx.O.A2RolesID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A2RolesID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("ROLESID",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 29 , function() {
   });
   this.Z1UsuarioID = 0 ;
   this.O1UsuarioID = 0 ;
   this.Z9Name = "" ;
   this.O9Name = "" ;
   this.Z10Password = "" ;
   this.O10Password = "" ;
   this.ZV11Update = "" ;
   this.OV11Update = "" ;
   this.ZV12Delete = "" ;
   this.OV12Delete = "" ;
   this.A2RolesID = 0 ;
   this.Z2RolesID = 0 ;
   this.O2RolesID = 0 ;
   this.A2RolesID = 0 ;
   this.AV6RolesID = 0 ;
   this.A1UsuarioID = 0 ;
   this.A9Name = "" ;
   this.A10Password = "" ;
   this.AV11Update = "" ;
   this.AV12Delete = "" ;
   this.Events = {"e110m2_client": ["'DOINSERT'", true] ,"e140m2_client": ["ENTER", true] ,"e150m2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}],[]];
   this.EvtParms["START"] = [[{av:'AV16Pgmname',fld:'vPGMNAME',pic:''},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'}],[{ctrl:'GRID',prop:'Rows'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("ROLESID","Visible")',ctrl:'ROLESID',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A1UsuarioID',fld:'USUARIOID',pic:'ZZZ9',hsh:true}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("NAME","Link")',ctrl:'NAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A1UsuarioID',fld:'USUARIOID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["GRID_FIRSTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_PREVPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_NEXTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_LASTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV6RolesID',fld:'vROLESID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}],[]];
   this.setVCMap("AV6RolesID", "vROLESID", 0, "int", 4, 0);
   this.setVCMap("AV6RolesID", "vROLESID", 0, "int", 4, 0);
   this.setVCMap("AV6RolesID", "vROLESID", 0, "int", 4, 0);
   GridContainer.addRefreshingVar({rfrVar:"AV6RolesID"});
   GridContainer.addRefreshingVar({rfrVar:"AV11Update", rfrProp:"Value", gxAttId:"Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV12Delete", rfrProp:"Value", gxAttId:"Delete"});
   GridContainer.addRefreshingParm({rfrVar:"AV6RolesID"});
   GridContainer.addRefreshingParm({rfrVar:"AV11Update", rfrProp:"Value", gxAttId:"Update"});
   GridContainer.addRefreshingParm({rfrVar:"AV12Delete", rfrProp:"Value", gxAttId:"Delete"});
   this.Initialize( );
});
