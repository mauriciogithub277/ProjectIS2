/*!   GeneXus C# 16_0_7-138086 on 8/24/2020 21:28:7.50
*/
gx.evt.autoSkip=!1;gx.define("gx0050",!1,function(){var n,t;this.ServerClass="gx0050";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12pTareaID=gx.fn.getIntegerValue("vPTAREAID",gx.thousandSeparator)};this.e170x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREAID","Visible",!0)):(gx.fn.setCtrlProperty("TAREAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREAIDFILTERCONTAINER","Class")',ctrl:"TAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAID","Visible")',ctrl:"vCTAREAID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREANAMEFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREANAMEFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREANAME","Visible",!0)):(gx.fn.setCtrlProperty("TAREANAMEFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREANAME","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREANAMEFILTERCONTAINER","Class")',ctrl:"TAREANAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREANAME","Visible")',ctrl:"vCTAREANAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e130x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREAVERSION","Visible",!0)):(gx.fn.setCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREAVERSION","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class")',ctrl:"TAREAVERSIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAVERSION","Visible")',ctrl:"vCTAREAVERSION",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e140x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREAPRIORIDAD","Visible",!0)):(gx.fn.setCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREAPRIORIDAD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class")',ctrl:"TAREAPRIORIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAPRIORIDAD","Visible")',ctrl:"vCTAREAPRIORIDAD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e150x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREAESTADOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREAESTADOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREAESTADO","Visible",!0)):(gx.fn.setCtrlProperty("TAREAESTADOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREAESTADO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREAESTADOFILTERCONTAINER","Class")',ctrl:"TAREAESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAESTADO","Visible")',ctrl:"vCTAREAESTADO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160x1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("TAREAPIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("TAREAPIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCTAREAPID","Visible",!0)):(gx.fn.setCtrlProperty("TAREAPIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCTAREAPID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("TAREAPIDFILTERCONTAINER","Class")',ctrl:"TAREAPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAPID","Visible")',ctrl:"vCTAREAPID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e200x2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e210x1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84];this.GXLastCtrlId=84;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0050",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px",gx.getMessage("GXM_newrow"),!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(5,76,"TAREAID",gx.getMessage("ID"),"","TareaID","int",0,"px",4,4,"right",null,[],5,"TareaID",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(26,77,"TAREANAME",gx.getMessage("Name"),"","TareaName","char",0,"px",40,40,"left",null,[],26,"TareaName",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(27,78,"TAREAVERSION",gx.getMessage("Version"),"","TareaVersion","char",0,"px",20,20,"left",null,[],27,"TareaVersion",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(28,79,"TAREAPRIORIDAD",gx.getMessage("Prioridad"),"","TareaPrioridad","char",0,"px",20,20,"left",null,[],28,"TareaPrioridad",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(29,80,"TAREAESTADO",gx.getMessage("Estado"),"","TareaEstado","char",0,"px",20,20,"left",null,[],29,"TareaEstado",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(6,81,"TAREAPID",gx.getMessage("PID"),"","TareaPID","int",0,"px",4,4,"right",null,[],6,"TareaPID",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText=gx.getMessage("");this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TAREAIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLTAREAIDFILTER",format:1,grid:0,evt:"e110x1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREAID",gxz:"ZV6cTareaID",gxold:"OV6cTareaID",gxvar:"AV6cTareaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cTareaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cTareaID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCTAREAID",gx.O.AV6cTareaID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cTareaID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCTAREAID",gx.thousandSeparator)},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"TAREANAMEFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLTAREANAMEFILTER",format:1,grid:0,evt:"e120x1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREANAME",gxz:"ZV7cTareaName",gxold:"OV7cTareaName",gxvar:"AV7cTareaName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cTareaName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cTareaName=n)},v2c:function(){gx.fn.setControlValue("vCTAREANAME",gx.O.AV7cTareaName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cTareaName=this.val())},val:function(){return gx.fn.getControlValue("vCTAREANAME")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"TAREAVERSIONFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLTAREAVERSIONFILTER",format:1,grid:0,evt:"e130x1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREAVERSION",gxz:"ZV8cTareaVersion",gxold:"OV8cTareaVersion",gxvar:"AV8cTareaVersion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cTareaVersion=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cTareaVersion=n)},v2c:function(){gx.fn.setControlValue("vCTAREAVERSION",gx.O.AV8cTareaVersion,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cTareaVersion=this.val())},val:function(){return gx.fn.getControlValue("vCTAREAVERSION")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"TAREAPRIORIDADFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLTAREAPRIORIDADFILTER",format:1,grid:0,evt:"e140x1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREAPRIORIDAD",gxz:"ZV9cTareaPrioridad",gxold:"OV9cTareaPrioridad",gxvar:"AV9cTareaPrioridad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cTareaPrioridad=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9cTareaPrioridad=n)},v2c:function(){gx.fn.setControlValue("vCTAREAPRIORIDAD",gx.O.AV9cTareaPrioridad,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cTareaPrioridad=this.val())},val:function(){return gx.fn.getControlValue("vCTAREAPRIORIDAD")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"TAREAESTADOFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLTAREAESTADOFILTER",format:1,grid:0,evt:"e150x1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREAESTADO",gxz:"ZV10cTareaEstado",gxold:"OV10cTareaEstado",gxvar:"AV10cTareaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cTareaEstado=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cTareaEstado=n)},v2c:function(){gx.fn.setControlValue("vCTAREAESTADO",gx.O.AV10cTareaEstado,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cTareaEstado=this.val())},val:function(){return gx.fn.getControlValue("vCTAREAESTADO")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"TAREAPIDFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLTAREAPIDFILTER",format:1,grid:0,evt:"e160x1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCTAREAPID",gxz:"ZV11cTareaPID",gxold:"OV11cTareaPID",gxvar:"AV11cTareaPID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cTareaPID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cTareaPID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCTAREAPID",gx.O.AV11cTareaPID,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cTareaPID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCTAREAPID",gx.thousandSeparator)},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GRIDTABLE",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTNTOGGLE",grid:0,evt:"e170x1_client"};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[75]={id:75,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(n){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[76]={id:76,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAID",gxz:"Z5TareaID",gxold:"O5TareaID",gxvar:"A5TareaID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A5TareaID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5TareaID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TAREAID",n||gx.fn.currentGridRowImpl(74),gx.O.A5TareaID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5TareaID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("TAREAID",n||gx.fn.currentGridRowImpl(74),gx.thousandSeparator)},nac:gx.falseFn};n[77]={id:77,lvl:2,type:"char",len:40,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREANAME",gxz:"Z26TareaName",gxold:"O26TareaName",gxvar:"A26TareaName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A26TareaName=n)},v2z:function(n){n!==undefined&&(gx.O.Z26TareaName=n)},v2c:function(n){gx.fn.setGridControlValue("TAREANAME",n||gx.fn.currentGridRowImpl(74),gx.O.A26TareaName,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A26TareaName=this.val(n))},val:function(n){return gx.fn.getGridControlValue("TAREANAME",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[78]={id:78,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAVERSION",gxz:"Z27TareaVersion",gxold:"O27TareaVersion",gxvar:"A27TareaVersion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A27TareaVersion=n)},v2z:function(n){n!==undefined&&(gx.O.Z27TareaVersion=n)},v2c:function(n){gx.fn.setGridControlValue("TAREAVERSION",n||gx.fn.currentGridRowImpl(74),gx.O.A27TareaVersion,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A27TareaVersion=this.val(n))},val:function(n){return gx.fn.getGridControlValue("TAREAVERSION",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[79]={id:79,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAPRIORIDAD",gxz:"Z28TareaPrioridad",gxold:"O28TareaPrioridad",gxvar:"A28TareaPrioridad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A28TareaPrioridad=n)},v2z:function(n){n!==undefined&&(gx.O.Z28TareaPrioridad=n)},v2c:function(n){gx.fn.setGridControlValue("TAREAPRIORIDAD",n||gx.fn.currentGridRowImpl(74),gx.O.A28TareaPrioridad,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A28TareaPrioridad=this.val(n))},val:function(n){return gx.fn.getGridControlValue("TAREAPRIORIDAD",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[80]={id:80,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAESTADO",gxz:"Z29TareaEstado",gxold:"O29TareaEstado",gxvar:"A29TareaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A29TareaEstado=n)},v2z:function(n){n!==undefined&&(gx.O.Z29TareaEstado=n)},v2c:function(n){gx.fn.setGridControlValue("TAREAESTADO",n||gx.fn.currentGridRowImpl(74),gx.O.A29TareaEstado,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A29TareaEstado=this.val(n))},val:function(n){return gx.fn.getGridControlValue("TAREAESTADO",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[81]={id:81,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TAREAPID",gxz:"Z6TareaPID",gxold:"O6TareaPID",gxvar:"A6TareaPID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A6TareaPID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6TareaPID=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("TAREAPID",n||gx.fn.currentGridRowImpl(74),gx.O.A6TareaPID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A6TareaPID=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("TAREAPID",n||gx.fn.currentGridRowImpl(74),gx.thousandSeparator)},nac:gx.falseFn};n[82]={id:82,fld:"",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"BTN_CANCEL",grid:0,evt:"e210x1_client"};this.AV6cTareaID=0;this.ZV6cTareaID=0;this.OV6cTareaID=0;this.AV7cTareaName="";this.ZV7cTareaName="";this.OV7cTareaName="";this.AV8cTareaVersion="";this.ZV8cTareaVersion="";this.OV8cTareaVersion="";this.AV9cTareaPrioridad="";this.ZV9cTareaPrioridad="";this.OV9cTareaPrioridad="";this.AV10cTareaEstado="";this.ZV10cTareaEstado="";this.OV10cTareaEstado="";this.AV11cTareaPID=0;this.ZV11cTareaPID=0;this.OV11cTareaPID=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z5TareaID=0;this.O5TareaID=0;this.Z26TareaName="";this.O26TareaName="";this.Z27TareaVersion="";this.O27TareaVersion="";this.Z28TareaPrioridad="";this.O28TareaPrioridad="";this.Z29TareaEstado="";this.O29TareaEstado="";this.Z6TareaPID=0;this.O6TareaPID=0;this.AV6cTareaID=0;this.AV7cTareaName="";this.AV8cTareaVersion="";this.AV9cTareaPrioridad="";this.AV10cTareaEstado="";this.AV11cTareaPID=0;this.AV12pTareaID=0;this.AV5LinkSelection="";this.A5TareaID=0;this.A26TareaName="";this.A27TareaVersion="";this.A28TareaPrioridad="";this.A29TareaEstado="";this.A6TareaPID=0;this.Events={e200x2_client:["ENTER",!0],e210x1_client:["CANCEL",!0],e170x1_client:["'TOGGLE'",!1],e110x1_client:["LBLTAREAIDFILTER.CLICK",!1],e120x1_client:["LBLTAREANAMEFILTER.CLICK",!1],e130x1_client:["LBLTAREAVERSIONFILTER.CLICK",!1],e140x1_client:["LBLTAREAPRIORIDADFILTER.CLICK",!1],e150x1_client:["LBLTAREAESTADOFILTER.CLICK",!1],e160x1_client:["LBLTAREAPIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTareaID",fld:"vCTAREAID",pic:"ZZZ9"},{av:"AV7cTareaName",fld:"vCTAREANAME",pic:""},{av:"AV8cTareaVersion",fld:"vCTAREAVERSION",pic:""},{av:"AV9cTareaPrioridad",fld:"vCTAREAPRIORIDAD",pic:""},{av:"AV10cTareaEstado",fld:"vCTAREAESTADO",pic:""},{av:"AV11cTareaPID",fld:"vCTAREAPID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLTAREAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREAIDFILTERCONTAINER","Class")',ctrl:"TAREAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREAIDFILTERCONTAINER","Class")',ctrl:"TAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAID","Visible")',ctrl:"vCTAREAID",prop:"Visible"}]];this.EvtParms["LBLTAREANAMEFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREANAMEFILTERCONTAINER","Class")',ctrl:"TAREANAMEFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREANAMEFILTERCONTAINER","Class")',ctrl:"TAREANAMEFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREANAME","Visible")',ctrl:"vCTAREANAME",prop:"Visible"}]];this.EvtParms["LBLTAREAVERSIONFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class")',ctrl:"TAREAVERSIONFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREAVERSIONFILTERCONTAINER","Class")',ctrl:"TAREAVERSIONFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAVERSION","Visible")',ctrl:"vCTAREAVERSION",prop:"Visible"}]];this.EvtParms["LBLTAREAPRIORIDADFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class")',ctrl:"TAREAPRIORIDADFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREAPRIORIDADFILTERCONTAINER","Class")',ctrl:"TAREAPRIORIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAPRIORIDAD","Visible")',ctrl:"vCTAREAPRIORIDAD",prop:"Visible"}]];this.EvtParms["LBLTAREAESTADOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREAESTADOFILTERCONTAINER","Class")',ctrl:"TAREAESTADOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREAESTADOFILTERCONTAINER","Class")',ctrl:"TAREAESTADOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAESTADO","Visible")',ctrl:"vCTAREAESTADO",prop:"Visible"}]];this.EvtParms["LBLTAREAPIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("TAREAPIDFILTERCONTAINER","Class")',ctrl:"TAREAPIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("TAREAPIDFILTERCONTAINER","Class")',ctrl:"TAREAPIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCTAREAPID","Visible")',ctrl:"vCTAREAPID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A5TareaID",fld:"TAREAID",pic:"ZZZ9",hsh:!0}],[{av:"AV12pTareaID",fld:"vPTAREAID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTareaID",fld:"vCTAREAID",pic:"ZZZ9"},{av:"AV7cTareaName",fld:"vCTAREANAME",pic:""},{av:"AV8cTareaVersion",fld:"vCTAREAVERSION",pic:""},{av:"AV9cTareaPrioridad",fld:"vCTAREAPRIORIDAD",pic:""},{av:"AV10cTareaEstado",fld:"vCTAREAESTADO",pic:""},{av:"AV11cTareaPID",fld:"vCTAREAPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTareaID",fld:"vCTAREAID",pic:"ZZZ9"},{av:"AV7cTareaName",fld:"vCTAREANAME",pic:""},{av:"AV8cTareaVersion",fld:"vCTAREAVERSION",pic:""},{av:"AV9cTareaPrioridad",fld:"vCTAREAPRIORIDAD",pic:""},{av:"AV10cTareaEstado",fld:"vCTAREAESTADO",pic:""},{av:"AV11cTareaPID",fld:"vCTAREAPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTareaID",fld:"vCTAREAID",pic:"ZZZ9"},{av:"AV7cTareaName",fld:"vCTAREANAME",pic:""},{av:"AV8cTareaVersion",fld:"vCTAREAVERSION",pic:""},{av:"AV9cTareaPrioridad",fld:"vCTAREAPRIORIDAD",pic:""},{av:"AV10cTareaEstado",fld:"vCTAREAESTADO",pic:""},{av:"AV11cTareaPID",fld:"vCTAREAPID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cTareaID",fld:"vCTAREAID",pic:"ZZZ9"},{av:"AV7cTareaName",fld:"vCTAREANAME",pic:""},{av:"AV8cTareaVersion",fld:"vCTAREAVERSION",pic:""},{av:"AV9cTareaPrioridad",fld:"vCTAREAPRIORIDAD",pic:""},{av:"AV10cTareaEstado",fld:"vCTAREAESTADO",pic:""},{av:"AV11cTareaPID",fld:"vCTAREAPID",pic:"ZZZ9"}],[]];this.setVCMap("AV12pTareaID","vPTAREAID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);t.addRefreshingParm(this.GXValidFnc[66]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0050)})