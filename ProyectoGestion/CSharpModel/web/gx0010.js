/*!   GeneXus C# 16_0_7-138086 on 3/22/2020 21:2:15.99
*/
gx.evt.autoSkip=!1;gx.define("gx0010",!1,function(){var n,t;this.ServerClass="gx0010";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pUsuarioID=gx.fn.getIntegerValue("vPUSUARIOID",",")};this.e14071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!0)):(gx.fn.setCtrlProperty("USUARIOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCUSUARIOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("NAMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("NAMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCNAME","Visible",!0)):(gx.fn.setCtrlProperty("NAMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCNAME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("NAMEFILTERCONTAINER","Class")',ctrl:"NAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNAME","Visible")',ctrl:"vCNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PASSWORDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PASSWORDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPASSWORD","Visible",!0)):(gx.fn.setCtrlProperty("PASSWORDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPASSWORD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PASSWORDFILTERCONTAINER","Class")',ctrl:"PASSWORDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPASSWORD","Visible")',ctrl:"vCPASSWORD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17072_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18071_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51];this.GXLastCtrlId=51;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0010",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,46,"USUARIOID","ID","","UsuarioID","int",0,"px",4,4,"right",null,[],1,"UsuarioID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(2,47,"NAME","Name","","Name","char",0,"px",40,40,"left",null,[],2,"Name",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(3,48,"PASSWORD","Password","","Password","char",0,"px",20,20,"left",null,[],3,"Password",!0,0,!1,!0,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"USUARIOIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLUSUARIOIDFILTER",format:1,grid:0,evt:"e11071_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCUSUARIOID",gxz:"ZV6cUsuarioID",gxold:"OV6cUsuarioID",gxvar:"AV6cUsuarioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cUsuarioID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cUsuarioID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCUSUARIOID",gx.O.AV6cUsuarioID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cUsuarioID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCUSUARIOID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"NAMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLNAMEFILTER",format:1,grid:0,evt:"e12071_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCNAME",gxz:"ZV7cName",gxold:"OV7cName",gxvar:"AV7cName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cName=n)},v2c:function(){gx.fn.setControlValue("vCNAME",gx.O.AV7cName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cName=this.val())},val:function(){return gx.fn.getControlValue("vCNAME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PASSWORDFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPASSWORDFILTER",format:1,grid:0,evt:"e13071_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:20,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPASSWORD",gxz:"ZV8cPassword",gxold:"OV8cPassword",gxvar:"AV8cPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cPassword=n)},v2c:function(){gx.fn.setControlValue("vCPASSWORD",gx.O.AV8cPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cPassword=this.val())},val:function(){return gx.fn.getControlValue("vCPASSWORD")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0,evt:"e14071_client"};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV13Linkselection_GXI)},c2v:function(n){gx.O.AV13Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV13Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USUARIOID",gxz:"Z1UsuarioID",gxold:"O1UsuarioID",gxvar:"A1UsuarioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1UsuarioID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1UsuarioID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("USUARIOID",n||gx.fn.currentGridRowImpl(44),gx.O.A1UsuarioID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1UsuarioID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("USUARIOID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"char",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"NAME",gxz:"Z2Name",gxold:"O2Name",gxvar:"A2Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A2Name=n)},v2z:function(n){n!==undefined&&(gx.O.Z2Name=n)},v2c:function(n){gx.fn.setGridControlValue("NAME",n||gx.fn.currentGridRowImpl(44),gx.O.A2Name,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A2Name=this.val(n))},val:function(n){return gx.fn.getGridControlValue("NAME",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"char",len:20,dec:0,sign:!1,isPwd:!0,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PASSWORD",gxz:"Z3Password",gxold:"O3Password",gxvar:"A3Password",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A3Password=n)},v2z:function(n){n!==undefined&&(gx.O.Z3Password=n)},v2c:function(n){gx.fn.setGridControlValue("PASSWORD",n||gx.fn.currentGridRowImpl(44),gx.O.A3Password,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A3Password=this.val(n))},val:function(n){return gx.fn.getGridControlValue("PASSWORD",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTN_CANCEL",grid:0,evt:"e18071_client"};this.AV6cUsuarioID=0;this.ZV6cUsuarioID=0;this.OV6cUsuarioID=0;this.AV7cName="";this.ZV7cName="";this.OV7cName="";this.AV8cPassword="";this.ZV8cPassword="";this.OV8cPassword="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1UsuarioID=0;this.O1UsuarioID=0;this.Z2Name="";this.O2Name="";this.Z3Password="";this.O3Password="";this.AV6cUsuarioID=0;this.AV7cName="";this.AV8cPassword="";this.AV9pUsuarioID=0;this.AV5LinkSelection="";this.A1UsuarioID=0;this.A2Name="";this.A3Password="";this.Events={e17072_client:["ENTER",!0],e18071_client:["CANCEL",!0],e14071_client:["'TOGGLE'",!1],e11071_client:["LBLUSUARIOIDFILTER.CLICK",!1],e12071_client:["LBLNAMEFILTER.CLICK",!1],e13071_client:["LBLPASSWORDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuarioID",fld:"vCUSUARIOID",pic:"ZZZ9"},{av:"AV7cName",fld:"vCNAME",pic:""},{av:"AV8cPassword",fld:"vCPASSWORD",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLUSUARIOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("USUARIOIDFILTERCONTAINER","Class")',ctrl:"USUARIOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCUSUARIOID","Visible")',ctrl:"vCUSUARIOID",prop:"Visible"}]];this.EvtParms["LBLNAMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("NAMEFILTERCONTAINER","Class")',ctrl:"NAMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("NAMEFILTERCONTAINER","Class")',ctrl:"NAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCNAME","Visible")',ctrl:"vCNAME",prop:"Visible"}]];this.EvtParms["LBLPASSWORDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PASSWORDFILTERCONTAINER","Class")',ctrl:"PASSWORDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PASSWORDFILTERCONTAINER","Class")',ctrl:"PASSWORDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPASSWORD","Visible")',ctrl:"vCPASSWORD",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1UsuarioID",fld:"USUARIOID",pic:"ZZZ9",hsh:!0}],[{av:"AV9pUsuarioID",fld:"vPUSUARIOID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuarioID",fld:"vCUSUARIOID",pic:"ZZZ9"},{av:"AV7cName",fld:"vCNAME",pic:""},{av:"AV8cPassword",fld:"vCPASSWORD",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuarioID",fld:"vCUSUARIOID",pic:"ZZZ9"},{av:"AV7cName",fld:"vCNAME",pic:""},{av:"AV8cPassword",fld:"vCPASSWORD",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuarioID",fld:"vCUSUARIOID",pic:"ZZZ9"},{av:"AV7cName",fld:"vCNAME",pic:""},{av:"AV8cPassword",fld:"vCPASSWORD",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cUsuarioID",fld:"vCUSUARIOID",pic:"ZZZ9"},{av:"AV7cName",fld:"vCNAME",pic:""},{av:"AV8cPassword",fld:"vCPASSWORD",pic:""}],[]];this.setVCMap("AV9pUsuarioID","vPUSUARIOID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0010)})