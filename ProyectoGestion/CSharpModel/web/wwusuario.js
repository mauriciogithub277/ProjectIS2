/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:0.27
*/
gx.evt.autoSkip = false;
gx.define('wwusuario', false, function () {
   this.ServerClass =  "wwusuario" ;
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
      this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Valid_Rolesid=function()
   {
      var currentRow = gx.fn.currentGridRowImpl(25);
      return this.validCliEvt("Valid_Rolesid", 25, function () {
      try {
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("ROLESID", gx.fn.currentGridRowImpl(25));
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
   this.e110a1_client=function()
   {
      this.clearMessages();
      this.call("wwadmin.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e120a2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e160a2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e170a2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32,33,34,35];
   this.GXLastCtrlId =35;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwusuario",[],false,1,false,true,0,true,false,false,"",0,"px",0,"px",gx.getMessage( "GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(1,26,"USUARIOID",gx.getMessage( "ID"),"","UsuarioID","int",0,"px",4,4,"right",null,[],1,"UsuarioID",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(9,27,"NAME",gx.getMessage( " Usuario"),"","Name","char",0,"px",40,40,"left",null,[],9,"Name",true,0,false,false,"DescriptionAttribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(10,28,"PASSWORD",gx.getMessage( "Password"),"","Password","char",0,"px",20,20,"left",null,[],10,"Password",false,0,false,true,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(2,29,"ROLESID",gx.getMessage( "ID Roles "),"","RolesID","int",0,"px",4,4,"right",null,[],2,"RolesID",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(15,30,"ROLESNAME",gx.getMessage( "Nombre Rol "),"","RolesName","char",0,"px",40,40,"left",null,[],15,"RolesName",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit("Update",31,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",true,0,false,false,"TextActionAttribute",1,"WWTextActionColumn");
   GridContainer.addSingleLineEdit("Delete",32,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",true,0,false,false,"TextActionAttribute",1,"WWTextActionColumn");
   this.GridContainer.emptyText = gx.getMessage( "");
   this.setGrid(GridContainer);
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
   GXValidFnc[13]={ id: 13, fld:"BTNINSERT",grid:0,evt:"e120a2_client"};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id:16 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vNAME",gxz:"ZV13Name",gxold:"OV13Name",gxvar:"AV13Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13Name=Value},v2c:function(){gx.fn.setControlValue("vNAME",gx.O.AV13Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13Name=this.val()},val:function(){return gx.fn.getControlValue("vNAME")},nac:gx.falseFn};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"GRIDCELL",grid:0};
   GXValidFnc[19]={ id: 19, fld:"GRIDTABLE",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z1UsuarioID",gxold:"O1UsuarioID",gxvar:"A1UsuarioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1UsuarioID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1UsuarioID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("USUARIOID",row || gx.fn.currentGridRowImpl(25),gx.O.A1UsuarioID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A1UsuarioID=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("USUARIOID",row || gx.fn.currentGridRowImpl(25),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"char",len:40,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NAME",gxz:"Z9Name",gxold:"O9Name",gxvar:"A9Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A9Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z9Name=Value},v2c:function(row){gx.fn.setGridControlValue("NAME",row || gx.fn.currentGridRowImpl(25),gx.O.A9Name,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A9Name=this.val(row)},val:function(row){return gx.fn.getGridControlValue("NAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PASSWORD",gxz:"Z10Password",gxold:"O10Password",gxvar:"A10Password",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A10Password=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z10Password=Value},v2c:function(row){gx.fn.setGridControlValue("PASSWORD",row || gx.fn.currentGridRowImpl(25),gx.O.A10Password,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A10Password=this.val(row)},val:function(row){return gx.fn.getGridControlValue("PASSWORD",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Rolesid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLESID",gxz:"Z2RolesID",gxold:"O2RolesID",gxvar:"A2RolesID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A2RolesID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2RolesID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("ROLESID",row || gx.fn.currentGridRowImpl(25),gx.O.A2RolesID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A2RolesID=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("ROLESID",row || gx.fn.currentGridRowImpl(25),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"char",len:40,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROLESNAME",gxz:"Z15RolesName",gxold:"O15RolesName",gxvar:"A15RolesName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A15RolesName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15RolesName=Value},v2c:function(row){gx.fn.setGridControlValue("ROLESNAME",row || gx.fn.currentGridRowImpl(25),gx.O.A15RolesName,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A15RolesName=this.val(row)},val:function(row){return gx.fn.getGridControlValue("ROLESNAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV14Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14Update=Value},v2c:function(row){gx.fn.setGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(25),gx.O.AV14Update,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV14Update=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV15Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15Delete=Value},v2c:function(row){gx.fn.setGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,0)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV15Delete=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"VOLVER",grid:0,evt:"e110a1_client"};
   this.AV13Name = "" ;
   this.ZV13Name = "" ;
   this.OV13Name = "" ;
   this.Z1UsuarioID = 0 ;
   this.O1UsuarioID = 0 ;
   this.Z9Name = "" ;
   this.O9Name = "" ;
   this.Z10Password = "" ;
   this.O10Password = "" ;
   this.Z2RolesID = 0 ;
   this.O2RolesID = 0 ;
   this.Z15RolesName = "" ;
   this.O15RolesName = "" ;
   this.ZV14Update = "" ;
   this.OV14Update = "" ;
   this.ZV15Delete = "" ;
   this.OV15Delete = "" ;
   this.AV13Name = "" ;
   this.A1UsuarioID = 0 ;
   this.A9Name = "" ;
   this.A10Password = "" ;
   this.A2RolesID = 0 ;
   this.A15RolesName = "" ;
   this.AV14Update = "" ;
   this.AV15Delete = "" ;
   this.AV19Pgmname = "" ;
   this.Events = {"e120a2_client": ["'DOINSERT'", true] ,"e160a2_client": ["ENTER", true] ,"e170a2_client": ["CANCEL", true] ,"e110a1_client": ["'VOLVER'", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV13Name',fld:'vNAME',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV13Name',fld:'vNAME',pic:''},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{ctrl:'FORM',prop:'Caption'},{av:'AV13Name',fld:'vNAME',pic:''},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A1UsuarioID',fld:'USUARIOID',pic:'ZZZ9',hsh:true},{av:'A2RolesID',fld:'ROLESID',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("NAME","Link")',ctrl:'NAME',prop:'Link'},{av:'gx.fn.getCtrlProperty("ROLESNAME","Link")',ctrl:'ROLESNAME',prop:'Link'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A1UsuarioID',fld:'USUARIOID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["'VOLVER'"] = [[],[]];
   this.EvtParms["GRID_FIRSTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13Name',fld:'vNAME',pic:''}],[]];
   this.EvtParms["GRID_PREVPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13Name',fld:'vNAME',pic:''}],[]];
   this.EvtParms["GRID_NEXTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13Name',fld:'vNAME',pic:''}],[]];
   this.EvtParms["GRID_LASTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13Name',fld:'vNAME',pic:''}],[]];
   this.EvtParms["VALID_ROLESID"] = [[],[]];
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[16]);
   GridContainer.addRefreshingVar({rfrVar:"AV19Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV14Update", rfrProp:"Value", gxAttId:"Update"});
   GridContainer.addRefreshingVar({rfrVar:"AV15Delete", rfrProp:"Value", gxAttId:"Delete"});
   GridContainer.addRefreshingParm(this.GXValidFnc[16]);
   GridContainer.addRefreshingParm({rfrVar:"AV19Pgmname"});
   GridContainer.addRefreshingParm({rfrVar:"AV14Update", rfrProp:"Value", gxAttId:"Update"});
   GridContainer.addRefreshingParm({rfrVar:"AV15Delete", rfrProp:"Value", gxAttId:"Delete"});
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(wwusuario);});
