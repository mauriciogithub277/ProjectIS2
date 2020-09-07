/*!   GeneXus C# 16_0_7-138086 on 8/25/2020 18:0:4.79
*/
gx.evt.autoSkip = false;
gx.define('estadoproyectoww', false, function () {
   this.ServerClass =  "estadoproyectoww" ;
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
      this.AV43ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR") ;
      this.AV88Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV10GridState=gx.fn.getControlValue("vGRIDSTATE") ;
      this.AV28DynamicFiltersIgnoreFirst=gx.fn.getControlValue("vDYNAMICFILTERSIGNOREFIRST") ;
      this.AV27DynamicFiltersRemoving=gx.fn.getControlValue("vDYNAMICFILTERSREMOVING") ;
      this.AV43ColumnsSelector=gx.fn.getControlValue("vCOLUMNSSELECTOR") ;
      this.AV88Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV10GridState=gx.fn.getControlValue("vGRIDSTATE") ;
      this.AV28DynamicFiltersIgnoreFirst=gx.fn.getControlValue("vDYNAMICFILTERSIGNOREFIRST") ;
      this.AV27DynamicFiltersRemoving=gx.fn.getControlValue("vDYNAMICFILTERSREMOVING") ;
   };
   this.s122_client=function()
   {
      gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE1","Visible", false );
      gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR1","Visible", false );
      if ( this.AV16DynamicFiltersSelector1 == "ESTADOPROYECTONOMBRE" )
      {
         gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE1","Visible", true );
         gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR1","Visible", true );
      }
   };
   this.s132_client=function()
   {
      gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE2","Visible", false );
      gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR2","Visible", false );
      if ( this.AV20DynamicFiltersSelector2 == "ESTADOPROYECTONOMBRE" )
      {
         gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE2","Visible", true );
         gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR2","Visible", true );
      }
   };
   this.s142_client=function()
   {
      gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE3","Visible", false );
      gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR3","Visible", false );
      if ( this.AV24DynamicFiltersSelector3 == "ESTADOPROYECTONOMBRE" )
      {
         gx.fn.setCtrlProperty("vESTADOPROYECTONOMBRE3","Visible", true );
         gx.fn.setCtrlProperty("vDYNAMICFILTERSOPERATOR3","Visible", true );
      }
   };
   this.s172_client=function()
   {
      this.s202_client();
      if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_ESTADOPROYECTOIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s202_client=function()
   {
      this.DDO_ESTADOPROYECTOIDContainer.SortedStatus =  ""  ;
      this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus =  ""  ;
   };
   this.s212_client=function()
   {
      if ( ! this.AV28DynamicFiltersIgnoreFirst )
      {
         this.AV12GridStateDynamicFilter =  {Selected:"",Value:"",Operator:0,ValueTo:""}  ;
         this.AV12GridStateDynamicFilter.Selected =  this.AV16DynamicFiltersSelector1  ;
         if ( ( this.AV16DynamicFiltersSelector1 == "ESTADOPROYECTONOMBRE" ) && ! ((''==this.AV18EstadoProyectoNombre1)) )
         {
            this.AV12GridStateDynamicFilter.Value =  this.AV18EstadoProyectoNombre1  ;
            this.AV12GridStateDynamicFilter.Operator = gx.num.trunc( this.AV17DynamicFiltersOperator1 ,0) ;
         }
         if ( this.AV27DynamicFiltersRemoving || ! ((''==this.AV12GridStateDynamicFilter.Value)) )
         {
            this.AV10GridState.DynamicFilters.push(this.AV12GridStateDynamicFilter) ;
         }
      }
      if ( this.AV19DynamicFiltersEnabled2 )
      {
         this.AV12GridStateDynamicFilter =  {Selected:"",Value:"",Operator:0,ValueTo:""}  ;
         this.AV12GridStateDynamicFilter.Selected =  this.AV20DynamicFiltersSelector2  ;
         if ( ( this.AV20DynamicFiltersSelector2 == "ESTADOPROYECTONOMBRE" ) && ! ((''==this.AV22EstadoProyectoNombre2)) )
         {
            this.AV12GridStateDynamicFilter.Value =  this.AV22EstadoProyectoNombre2  ;
            this.AV12GridStateDynamicFilter.Operator = gx.num.trunc( this.AV21DynamicFiltersOperator2 ,0) ;
         }
         if ( this.AV27DynamicFiltersRemoving || ! ((''==this.AV12GridStateDynamicFilter.Value)) )
         {
            this.AV10GridState.DynamicFilters.push(this.AV12GridStateDynamicFilter) ;
         }
      }
      if ( this.AV23DynamicFiltersEnabled3 )
      {
         this.AV12GridStateDynamicFilter =  {Selected:"",Value:"",Operator:0,ValueTo:""}  ;
         this.AV12GridStateDynamicFilter.Selected =  this.AV24DynamicFiltersSelector3  ;
         if ( ( this.AV24DynamicFiltersSelector3 == "ESTADOPROYECTONOMBRE" ) && ! ((''==this.AV26EstadoProyectoNombre3)) )
         {
            this.AV12GridStateDynamicFilter.Value =  this.AV26EstadoProyectoNombre3  ;
            this.AV12GridStateDynamicFilter.Operator = gx.num.trunc( this.AV25DynamicFiltersOperator3 ,0) ;
         }
         if ( this.AV27DynamicFiltersRemoving || ! ((''==this.AV12GridStateDynamicFilter.Value)) )
         {
            this.AV10GridState.DynamicFilters.push(this.AV12GridStateDynamicFilter) ;
         }
      }
   };
   this.s222_client=function()
   {
      this.AV19DynamicFiltersEnabled2 =  false  ;
      this.AV20DynamicFiltersSelector2 =  "ESTADOPROYECTONOMBRE"  ;
      this.AV21DynamicFiltersOperator2 = gx.num.trunc( 0 ,0) ;
      this.AV22EstadoProyectoNombre2 =  ''  ;
      this.s132_client();
      this.AV23DynamicFiltersEnabled3 =  false  ;
      this.AV24DynamicFiltersSelector3 =  "ESTADOPROYECTONOMBRE"  ;
      this.AV25DynamicFiltersOperator3 = gx.num.trunc( 0 ,0) ;
      this.AV26EstadoProyectoNombre3 =  ''  ;
      this.s142_client();
   };
   this.e121f2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e131f2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e141f2_client=function()
   {
      return this.executeServerEvent("DDO_ESTADOPROYECTOID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e151f2_client=function()
   {
      return this.executeServerEvent("DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e161f2_client=function()
   {
      return this.executeServerEvent("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED", false, null, true, true);
   };
   this.e171f2_client=function()
   {
      return this.executeServerEvent("'REMOVEDYNAMICFILTERS1'", true, null, false, false);
   };
   this.e181f2_client=function()
   {
      return this.executeServerEvent("'REMOVEDYNAMICFILTERS2'", true, null, false, false);
   };
   this.e191f2_client=function()
   {
      return this.executeServerEvent("'REMOVEDYNAMICFILTERS3'", true, null, false, false);
   };
   this.e111f2_client=function()
   {
      return this.executeServerEvent("DDO_MANAGEFILTERS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e201f2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e211f2_client=function()
   {
      return this.executeServerEvent("'DOEXPORT'", false, null, false, false);
   };
   this.e221f2_client=function()
   {
      return this.executeServerEvent("'DOEXPORTREPORT'", false, null, false, false);
   };
   this.e231f2_client=function()
   {
      return this.executeServerEvent("'ADDDYNAMICFILTERS1'", true, null, false, false);
   };
   this.e241f2_client=function()
   {
      return this.executeServerEvent("VDYNAMICFILTERSSELECTOR1.CLICK", true, null, false, true);
   };
   this.e251f2_client=function()
   {
      return this.executeServerEvent("'ADDDYNAMICFILTERS2'", true, null, false, false);
   };
   this.e261f2_client=function()
   {
      return this.executeServerEvent("VDYNAMICFILTERSSELECTOR2.CLICK", true, null, false, true);
   };
   this.e271f2_client=function()
   {
      return this.executeServerEvent("VDYNAMICFILTERSSELECTOR3.CLICK", true, null, false, true);
   };
   this.e311f2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e321f2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,33,36,39,42,44,45,47,49,52,53,55,56,58,61,63,66,68,69,71,73,76,77,79,80,82,85,87,90,92,93,95,97,100,101,103,104,106,109,110,111,113,114,115,116,117,119,120,121,122,123,124,125,127,128,129,130,132,134,138,139,140,141,142,143,144,145,146];
   this.GXLastCtrlId =146;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",118,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"estadoproyectoww",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px",gx.getMessage( "GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit("Update",119,"vUPDATE","",gx.getMessage( "GXM_update"),"Update","char",0,"px",20,20,"left",null,[],"Update","Update",true,0,false,false,"Attribute",1,"WWIconActionColumn");
   GridContainer.addSingleLineEdit("Delete",120,"vDELETE","",gx.getMessage( "GX_BtnDelete"),"Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",true,0,false,false,"Attribute",1,"WWIconActionColumn");
   GridContainer.addSingleLineEdit(7,121,"ESTADOPROYECTOID","","","EstadoProyectoID","int",0,"px",4,4,"right",null,[],7,"EstadoProyectoID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(34,122,"ESTADOPROYECTONOMBRE","","","EstadoProyectoNombre","char",0,"px",40,40,"left",null,[],34,"EstadoProyectoNombre",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = gx.getMessage( "");
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
   var DVPANEL_TABLEHEADERContainer = this.DVPANEL_TABLEHEADERContainer;
   DVPANEL_TABLEHEADERContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEHEADERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEHEADERContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_TABLEHEADERContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", gx.getMessage( "WWP_FilterOptions"), "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "right", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 126, 45, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
   var GRIDPAGINATIONBARContainer = this.GRIDPAGINATIONBARContainer;
   GRIDPAGINATIONBARContainer.setProp("Enabled", "Enabled", true, "boolean");
   GRIDPAGINATIONBARContainer.setProp("Class", "Class", "PaginationBar", "str");
   GRIDPAGINATIONBARContainer.setProp("ShowFirst", "Showfirst", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowPrevious", "Showprevious", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowNext", "Shownext", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowLast", "Showlast", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("PagesToShow", "Pagestoshow", 5, "num");
   GRIDPAGINATIONBARContainer.setProp("PagingButtonsPosition", "Pagingbuttonsposition", "Right", "str");
   GRIDPAGINATIONBARContainer.setProp("PagingCaptionPosition", "Pagingcaptionposition", "Left", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridClass", "Emptygridclass", "PaginationBarEmptyGrid", "str");
   GRIDPAGINATIONBARContainer.setProp("SelectedPage", "Selectedpage", "", "char");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageSelector", "Rowsperpageselector", true, "bool");
   GRIDPAGINATIONBARContainer.setDynProp("RowsPerPageSelectedValue", "Rowsperpageselectedvalue", 10, "num");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageOptions", "Rowsperpageoptions", "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50", "str");
   GRIDPAGINATIONBARContainer.setProp("First", "First", "First", "str");
   GRIDPAGINATIONBARContainer.setProp("Previous", "Previous", "WWP_PagingPreviousCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Next", "Next", "WWP_PagingNextCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Last", "Last", "Last", "str");
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", gx.getMessage( "WWP_PagingCaption"), "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV67GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV67GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV67GridCurrentPage); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV68GridPageCount', "vGRIDPAGECOUNT", 'SetPageCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV68GridPageCount=UC.GetPageCount();gx.fn.setControlValue("vGRIDPAGECOUNT",UC.ParentObject.AV68GridPageCount); });
   GRIDPAGINATIONBARContainer.setProp("RecordCount", "Recordcount", '', "str");
   GRIDPAGINATIONBARContainer.setProp("Page", "Page", '', "str");
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e121f2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e131f2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_ESTADOPROYECTOIDContainer = gx.uc.getNew(this, 131, 45, "BootstrapDropDownOptions", "DDO_ESTADOPROYECTOIDContainer", "Ddo_estadoproyectoid", "DDO_ESTADOPROYECTOID");
   var DDO_ESTADOPROYECTOIDContainer = this.DDO_ESTADOPROYECTOIDContainer;
   DDO_ESTADOPROYECTOIDContainer.setProp("Class", "Class", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("IconType", "Icontype", "Image", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("Icon", "Icon", "", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("Enabled", "Enabled", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_ESTADOPROYECTOIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_ESTADOPROYECTOIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("DataListProcParametersPrefix", "Datalistprocparametersprefix", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_ESTADOPROYECTOIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeOnlySelectedOption", "Includeonlyselectedoption", false, "boolean");
   DDO_ESTADOPROYECTOIDContainer.setProp("IncludeSelectAllOption", "Includeselectalloption", false, "boolean");
   DDO_ESTADOPROYECTOIDContainer.setProp("CategoryFilteredBehaviour", "Categoryfilteredbehaviour", "ShowFilteredChildren", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("EmptyItem", "Emptyitem", false, "boolean");
   DDO_ESTADOPROYECTOIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_ESTADOPROYECTOIDContainer.setProp("EmptyItemText", "Emptyitemtext", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("OnlySelectedValues", "Onlyselectedvalues", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("SelectAllText", "Selectalltext", "", "char");
   DDO_ESTADOPROYECTOIDContainer.setProp("MultipleValuesSeparator", "Multiplevaluesseparator", "", "char");
   DDO_ESTADOPROYECTOIDContainer.addV2CFunction('AV65DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_ESTADOPROYECTOIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV65DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV65DDO_TitleSettingsIcons); });
   DDO_ESTADOPROYECTOIDContainer.addV2CFunction('AV57EstadoProyectoIDTitleFilterData', "vESTADOPROYECTOIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_ESTADOPROYECTOIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV57EstadoProyectoIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vESTADOPROYECTOIDTITLEFILTERDATA",UC.ParentObject.AV57EstadoProyectoIDTitleFilterData); });
   DDO_ESTADOPROYECTOIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_ESTADOPROYECTOIDContainer.addEventHandler("OnOptionClicked", this.e141f2_client);
   this.setUserControl(DDO_ESTADOPROYECTOIDContainer);
   this.DDO_ESTADOPROYECTONOMBREContainer = gx.uc.getNew(this, 133, 45, "BootstrapDropDownOptions", "DDO_ESTADOPROYECTONOMBREContainer", "Ddo_estadoproyectonombre", "DDO_ESTADOPROYECTONOMBRE");
   var DDO_ESTADOPROYECTONOMBREContainer = this.DDO_ESTADOPROYECTONOMBREContainer;
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Class", "Class", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IconType", "Icontype", "Image", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Icon", "Icon", "", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Caption", "Caption", "", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Enabled", "Enabled", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("Visible", "Visible", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DataListProc", "Datalistproc", "EstadoProyectoWWGetFilterData", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DataListProcParametersPrefix", "Datalistprocparametersprefix", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeOnlySelectedOption", "Includeonlyselectedoption", false, "boolean");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("IncludeSelectAllOption", "Includeselectalloption", false, "boolean");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("CategoryFilteredBehaviour", "Categoryfilteredbehaviour", "ShowFilteredChildren", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("EmptyItem", "Emptyitem", false, "boolean");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("EmptyItemText", "Emptyitemtext", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("OnlySelectedValues", "Onlyselectedvalues", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("SelectAllText", "Selectalltext", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.setProp("MultipleValuesSeparator", "Multiplevaluesseparator", "", "char");
   DDO_ESTADOPROYECTONOMBREContainer.addV2CFunction('AV65DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_ESTADOPROYECTONOMBREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV65DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV65DDO_TitleSettingsIcons); });
   DDO_ESTADOPROYECTONOMBREContainer.addV2CFunction('AV61EstadoProyectoNombreTitleFilterData', "vESTADOPROYECTONOMBRETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_ESTADOPROYECTONOMBREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV61EstadoProyectoNombreTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vESTADOPROYECTONOMBRETITLEFILTERDATA",UC.ParentObject.AV61EstadoProyectoNombreTitleFilterData); });
   DDO_ESTADOPROYECTONOMBREContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_ESTADOPROYECTONOMBREContainer.addEventHandler("OnOptionClicked", this.e151f2_client);
   this.setUserControl(DDO_ESTADOPROYECTONOMBREContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 135, 45, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("EnableAutoUpdateFromDocumentTitle", "Enableautoupdatefromdocumenttitle", false, "bool");
   WORKWITHPLUSUTILITIES1Container.setProp("EnableFixObjectFitCover", "Enablefixobjectfitcover", false, "bool");
   WORKWITHPLUSUTILITIES1Container.setProp("EnableFloatingLabels", "Enablefloatinglabels", false, "bool");
   WORKWITHPLUSUTILITIES1Container.setProp("EnableConvertComboToBootstrapSelect", "Enableconvertcombotobootstrapselect", false, "bool");
   WORKWITHPLUSUTILITIES1Container.setProp("CurrentTab_ReturnUrl", "Currenttab_returnurl", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setProp("Gx Control Type", "Gxcontroltype", '', "int");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   this.INNEWWINDOW1Container = gx.uc.getNew(this, 136, 45, "InNewWindow", "INNEWWINDOW1Container", "Innewwindow1", "INNEWWINDOW1");
   var INNEWWINDOW1Container = this.INNEWWINDOW1Container;
   INNEWWINDOW1Container.setProp("Class", "Class", "", "char");
   INNEWWINDOW1Container.setProp("Enabled", "Enabled", true, "boolean");
   INNEWWINDOW1Container.setDynProp("Width", "Width", "50", "str");
   INNEWWINDOW1Container.setDynProp("Height", "Height", "50", "str");
   INNEWWINDOW1Container.setProp("Name", "Name", "", "str");
   INNEWWINDOW1Container.setDynProp("Target", "Target", "", "str");
   INNEWWINDOW1Container.setProp("Fullscreen", "Fullscreen", false, "bool");
   INNEWWINDOW1Container.setProp("Location", "Location", true, "bool");
   INNEWWINDOW1Container.setProp("MenuBar", "Menubar", true, "bool");
   INNEWWINDOW1Container.setProp("Resizable", "Resizable", true, "bool");
   INNEWWINDOW1Container.setProp("Scrollbars", "Scrollbars", true, "bool");
   INNEWWINDOW1Container.setProp("TitleBar", "Titlebar", true, "bool");
   INNEWWINDOW1Container.setProp("ToolBar", "Toolbar", true, "bool");
   INNEWWINDOW1Container.setProp("directories", "Directories", true, "bool");
   INNEWWINDOW1Container.setProp("status", "Status", true, "bool");
   INNEWWINDOW1Container.setProp("copyhistory", "Copyhistory", true, "bool");
   INNEWWINDOW1Container.setProp("top", "Top", "5", "str");
   INNEWWINDOW1Container.setProp("left", "Left", "5", "str");
   INNEWWINDOW1Container.setProp("fitscreen", "Fitscreen", false, "bool");
   INNEWWINDOW1Container.setProp("RefreshParentOnClose", "Refreshparentonclose", false, "bool");
   INNEWWINDOW1Container.setProp("Targets", "Targets", '', "str");
   INNEWWINDOW1Container.setProp("Visible", "Visible", true, "bool");
   INNEWWINDOW1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(INNEWWINDOW1Container);
   this.DDO_GRIDCOLUMNSSELECTORContainer = gx.uc.getNew(this, 137, 45, "BootstrapDropDownOptions", "DDO_GRIDCOLUMNSSELECTORContainer", "Ddo_gridcolumnsselector", "DDO_GRIDCOLUMNSSELECTOR");
   var DDO_GRIDCOLUMNSSELECTORContainer = this.DDO_GRIDCOLUMNSSELECTORContainer;
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Class", "Class", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IconType", "Icontype", "Image", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Icon", "Icon", "", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Caption", "Caption", gx.getMessage( "WWP_EditColumnsCaption"), "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Tooltip", "Tooltip", "WWP_EditColumnsTooltip", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Cls", "Cls", "ColumnsSelector hidden-xs", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridColumnsSelector", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Enabled", "Enabled", true, "bool");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("Visible", "Visible", true, "bool");
   DDO_GRIDCOLUMNSSELECTORContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeSortASC", "Includesortasc", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeSortDSC", "Includesortdsc", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeFilter", "Includefilter", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeDataList", "Includedatalist", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DataListProcParametersPrefix", "Datalistprocparametersprefix", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("FixedFilters", "Fixedfilters", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeOnlySelectedOption", "Includeonlyselectedoption", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("IncludeSelectAllOption", "Includeselectalloption", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("CategoryFilteredBehaviour", "Categoryfilteredbehaviour", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("EmptyItem", "Emptyitem", false, "boolean");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SortASC", "Sortasc", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SortDSC", "Sortdsc", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SearchButtonText", "Searchbuttontext", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("UpdateButtonText", "Updatebuttontext", "WWP_ColumnsSelectorButton", "str");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("EmptyItemText", "Emptyitemtext", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("OnlySelectedValues", "Onlyselectedvalues", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("SelectAllText", "Selectalltext", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.setProp("MultipleValuesSeparator", "Multiplevaluesseparator", "", "char");
   DDO_GRIDCOLUMNSSELECTORContainer.addV2CFunction('AV65DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_GRIDCOLUMNSSELECTORContainer.addC2VFunction(function(UC) { UC.ParentObject.AV65DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV65DDO_TitleSettingsIcons); });
   DDO_GRIDCOLUMNSSELECTORContainer.addV2CFunction('AV43ColumnsSelector', "vCOLUMNSSELECTOR", 'SetDropDownOptionsData');
   DDO_GRIDCOLUMNSSELECTORContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43ColumnsSelector=UC.GetDropDownOptionsData();gx.fn.setControlValue("vCOLUMNSSELECTOR",UC.ParentObject.AV43ColumnsSelector); });
   DDO_GRIDCOLUMNSSELECTORContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_GRIDCOLUMNSSELECTORContainer.addEventHandler("OnColumnsChanged", this.e161f2_client);
   this.setUserControl(DDO_GRIDCOLUMNSSELECTORContainer);
   this.DDO_MANAGEFILTERSContainer = gx.uc.getNew(this, 34, 0, "BootstrapDropDownOptions", "DDO_MANAGEFILTERSContainer", "Ddo_managefilters", "DDO_MANAGEFILTERS");
   var DDO_MANAGEFILTERSContainer = this.DDO_MANAGEFILTERSContainer;
   DDO_MANAGEFILTERSContainer.setProp("Class", "Class", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("IconType", "Icontype", "Image", "str");
   DDO_MANAGEFILTERSContainer.setDynProp("Icon", "Icon", "", "str");
   DDO_MANAGEFILTERSContainer.setProp("Caption", "Caption", "", "str");
   DDO_MANAGEFILTERSContainer.setProp("Tooltip", "Tooltip", "WWP_ManageFiltersTooltip", "str");
   DDO_MANAGEFILTERSContainer.setProp("Cls", "Cls", "ManageFilters", "str");
   DDO_MANAGEFILTERSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_MANAGEFILTERSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "Regular", "str");
   DDO_MANAGEFILTERSContainer.setProp("Enabled", "Enabled", true, "bool");
   DDO_MANAGEFILTERSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_MANAGEFILTERSContainer.setProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_MANAGEFILTERSContainer.setProp("IncludeSortASC", "Includesortasc", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("IncludeSortDSC", "Includesortdsc", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("IncludeFilter", "Includefilter", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("IncludeDataList", "Includedatalist", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("DataListProcParametersPrefix", "Datalistprocparametersprefix", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_MANAGEFILTERSContainer.setProp("FixedFilters", "Fixedfilters", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("IncludeOnlySelectedOption", "Includeonlyselectedoption", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("IncludeSelectAllOption", "Includeselectalloption", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("CategoryFilteredBehaviour", "Categoryfilteredbehaviour", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("EmptyItem", "Emptyitem", false, "boolean");
   DDO_MANAGEFILTERSContainer.setProp("SortASC", "Sortasc", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SortDSC", "Sortdsc", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SearchButtonText", "Searchbuttontext", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("UpdateButtonText", "Updatebuttontext", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("EmptyItemText", "Emptyitemtext", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("OnlySelectedValues", "Onlyselectedvalues", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("SelectAllText", "Selectalltext", "", "char");
   DDO_MANAGEFILTERSContainer.setProp("MultipleValuesSeparator", "Multiplevaluesseparator", "", "char");
   DDO_MANAGEFILTERSContainer.DropDownOptionsTitleSettingsIcons = '';
   DDO_MANAGEFILTERSContainer.addV2CFunction('AV55ManageFiltersData', "vMANAGEFILTERSDATA", 'SetDropDownOptionsData');
   DDO_MANAGEFILTERSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55ManageFiltersData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vMANAGEFILTERSDATA",UC.ParentObject.AV55ManageFiltersData); });
   DDO_MANAGEFILTERSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_MANAGEFILTERSContainer.addEventHandler("OnOptionClicked", this.e111f2_client);
   this.setUserControl(DDO_MANAGEFILTERSContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"BTNINSERT",grid:0,evt:"e201f2_client"};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"BTNEXPORT",grid:0,evt:"e211f2_client"};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"BTNEXPORTREPORT",grid:0,evt:"e221f2_client"};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"BTNEDITCOLUMNS",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"TABLERIGHTHEADER",grid:0};
   GXValidFnc[33]={ id: 33, fld:"HTML_MANAGEFILTERS",grid:0};
   GXValidFnc[36]={ id: 36, fld:"TABLEFILTERS",grid:0};
   GXValidFnc[39]={ id: 39, fld:"TABLEDYNAMICFILTERS",grid:0};
   GXValidFnc[42]={ id: 42, fld:"DYNAMICFILTERSPREFIX1", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSSELECTOR1",gxz:"ZV16DynamicFiltersSelector1",gxold:"OV16DynamicFiltersSelector1",gxvar:"AV16DynamicFiltersSelector1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV16DynamicFiltersSelector1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16DynamicFiltersSelector1=Value},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSSELECTOR1",gx.O.AV16DynamicFiltersSelector1)},c2v:function(){if(this.val()!==undefined)gx.O.AV16DynamicFiltersSelector1=this.val()},val:function(){return gx.fn.getControlValue("vDYNAMICFILTERSSELECTOR1")},nac:gx.falseFn,evt:"e241f2_client"};
   GXValidFnc[47]={ id: 47, fld:"DYNAMICFILTERSMIDDLE1", format:0,grid:0};
   GXValidFnc[49]={ id: 49, fld:"TABLEMERGEDDYNAMICFILTERS1",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSOPERATOR1",gxz:"ZV17DynamicFiltersOperator1",gxold:"OV17DynamicFiltersOperator1",gxvar:"AV17DynamicFiltersOperator1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV17DynamicFiltersOperator1=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV17DynamicFiltersOperator1=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSOPERATOR1",gx.O.AV17DynamicFiltersOperator1)},c2v:function(){if(this.val()!==undefined)gx.O.AV17DynamicFiltersOperator1=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vDYNAMICFILTERSOPERATOR1",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id:56 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vESTADOPROYECTONOMBRE1",gxz:"ZV18EstadoProyectoNombre1",gxold:"OV18EstadoProyectoNombre1",gxvar:"AV18EstadoProyectoNombre1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18EstadoProyectoNombre1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18EstadoProyectoNombre1=Value},v2c:function(){gx.fn.setControlValue("vESTADOPROYECTONOMBRE1",gx.O.AV18EstadoProyectoNombre1,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18EstadoProyectoNombre1=this.val()},val:function(){return gx.fn.getControlValue("vESTADOPROYECTONOMBRE1")},nac:gx.falseFn};
   GXValidFnc[58]={ id: 58, fld:"UNNAMEDTABLEDYNAMICFILTERS_1",grid:0};
   GXValidFnc[61]={ id: 61, fld:"ADDDYNAMICFILTERS1",grid:0,evt:"e231f2_client"};
   GXValidFnc[63]={ id: 63, fld:"REMOVEDYNAMICFILTERS1",grid:0,evt:"e171f2_client"};
   GXValidFnc[66]={ id: 66, fld:"DYNAMICFILTERSPREFIX2", format:0,grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id:69 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSSELECTOR2",gxz:"ZV20DynamicFiltersSelector2",gxold:"OV20DynamicFiltersSelector2",gxvar:"AV20DynamicFiltersSelector2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV20DynamicFiltersSelector2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20DynamicFiltersSelector2=Value},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSSELECTOR2",gx.O.AV20DynamicFiltersSelector2)},c2v:function(){if(this.val()!==undefined)gx.O.AV20DynamicFiltersSelector2=this.val()},val:function(){return gx.fn.getControlValue("vDYNAMICFILTERSSELECTOR2")},nac:gx.falseFn,evt:"e261f2_client"};
   GXValidFnc[71]={ id: 71, fld:"DYNAMICFILTERSMIDDLE2", format:0,grid:0};
   GXValidFnc[73]={ id: 73, fld:"TABLEMERGEDDYNAMICFILTERS2",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSOPERATOR2",gxz:"ZV21DynamicFiltersOperator2",gxold:"OV21DynamicFiltersOperator2",gxvar:"AV21DynamicFiltersOperator2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV21DynamicFiltersOperator2=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21DynamicFiltersOperator2=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSOPERATOR2",gx.O.AV21DynamicFiltersOperator2)},c2v:function(){if(this.val()!==undefined)gx.O.AV21DynamicFiltersOperator2=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vDYNAMICFILTERSOPERATOR2",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vESTADOPROYECTONOMBRE2",gxz:"ZV22EstadoProyectoNombre2",gxold:"OV22EstadoProyectoNombre2",gxvar:"AV22EstadoProyectoNombre2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22EstadoProyectoNombre2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22EstadoProyectoNombre2=Value},v2c:function(){gx.fn.setControlValue("vESTADOPROYECTONOMBRE2",gx.O.AV22EstadoProyectoNombre2,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22EstadoProyectoNombre2=this.val()},val:function(){return gx.fn.getControlValue("vESTADOPROYECTONOMBRE2")},nac:gx.falseFn};
   GXValidFnc[82]={ id: 82, fld:"UNNAMEDTABLEDYNAMICFILTERS_2",grid:0};
   GXValidFnc[85]={ id: 85, fld:"ADDDYNAMICFILTERS2",grid:0,evt:"e251f2_client"};
   GXValidFnc[87]={ id: 87, fld:"REMOVEDYNAMICFILTERS2",grid:0,evt:"e181f2_client"};
   GXValidFnc[90]={ id: 90, fld:"DYNAMICFILTERSPREFIX3", format:0,grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id:93 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSSELECTOR3",gxz:"ZV24DynamicFiltersSelector3",gxold:"OV24DynamicFiltersSelector3",gxvar:"AV24DynamicFiltersSelector3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV24DynamicFiltersSelector3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24DynamicFiltersSelector3=Value},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSSELECTOR3",gx.O.AV24DynamicFiltersSelector3)},c2v:function(){if(this.val()!==undefined)gx.O.AV24DynamicFiltersSelector3=this.val()},val:function(){return gx.fn.getControlValue("vDYNAMICFILTERSSELECTOR3")},nac:gx.falseFn,evt:"e271f2_client"};
   GXValidFnc[95]={ id: 95, fld:"DYNAMICFILTERSMIDDLE3", format:0,grid:0};
   GXValidFnc[97]={ id: 97, fld:"TABLEMERGEDDYNAMICFILTERS3",grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id:101 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSOPERATOR3",gxz:"ZV25DynamicFiltersOperator3",gxold:"OV25DynamicFiltersOperator3",gxvar:"AV25DynamicFiltersOperator3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV25DynamicFiltersOperator3=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25DynamicFiltersOperator3=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vDYNAMICFILTERSOPERATOR3",gx.O.AV25DynamicFiltersOperator3)},c2v:function(){if(this.val()!==undefined)gx.O.AV25DynamicFiltersOperator3=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vDYNAMICFILTERSOPERATOR3",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[103]={ id: 103, fld:"",grid:0};
   GXValidFnc[104]={ id:104 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vESTADOPROYECTONOMBRE3",gxz:"ZV26EstadoProyectoNombre3",gxold:"OV26EstadoProyectoNombre3",gxvar:"AV26EstadoProyectoNombre3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26EstadoProyectoNombre3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26EstadoProyectoNombre3=Value},v2c:function(){gx.fn.setControlValue("vESTADOPROYECTONOMBRE3",gx.O.AV26EstadoProyectoNombre3,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26EstadoProyectoNombre3=this.val()},val:function(){return gx.fn.getControlValue("vESTADOPROYECTONOMBRE3")},nac:gx.falseFn};
   GXValidFnc[106]={ id: 106, fld:"UNNAMEDTABLEDYNAMICFILTERS_3",grid:0};
   GXValidFnc[109]={ id: 109, fld:"REMOVEDYNAMICFILTERS3",grid:0,evt:"e191f2_client"};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"",grid:0};
   GXValidFnc[115]={ id: 115, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[119]={ id:119 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:118,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV69Update",gxold:"OV69Update",gxvar:"AV69Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV69Update=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV69Update=Value},v2c:function(row){gx.fn.setGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(118),gx.O.AV69Update,1)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV69Update=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vUPDATE",row || gx.fn.currentGridRowImpl(118))},nac:gx.falseFn};
   GXValidFnc[120]={ id:120 ,lvl:2,type:"char",len:20,dec:0,sign:false,ro:1,isacc:0,grid:118,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV70Delete",gxold:"OV70Delete",gxvar:"AV70Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV70Delete=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV70Delete=Value},v2c:function(row){gx.fn.setGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(118),gx.O.AV70Delete,1)},c2v:function(row){if(this.val(row)!==undefined)gx.O.AV70Delete=this.val(row)},val:function(row){return gx.fn.getGridControlValue("vDELETE",row || gx.fn.currentGridRowImpl(118))},nac:gx.falseFn};
   GXValidFnc[121]={ id:121 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:118,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOPROYECTOID",gxz:"Z7EstadoProyectoID",gxold:"O7EstadoProyectoID",gxvar:"A7EstadoProyectoID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A7EstadoProyectoID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7EstadoProyectoID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("ESTADOPROYECTOID",row || gx.fn.currentGridRowImpl(118),gx.O.A7EstadoProyectoID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A7EstadoProyectoID=gx.num.intval(this.val(row))},val:function(row){return gx.fn.getGridIntegerValue("ESTADOPROYECTOID",row || gx.fn.currentGridRowImpl(118),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[122]={ id:122 ,lvl:2,type:"char",len:40,dec:0,sign:false,ro:1,isacc:0,grid:118,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTADOPROYECTONOMBRE",gxz:"Z34EstadoProyectoNombre",gxold:"O34EstadoProyectoNombre",gxvar:"A34EstadoProyectoNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A34EstadoProyectoNombre=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z34EstadoProyectoNombre=Value},v2c:function(row){gx.fn.setGridControlValue("ESTADOPROYECTONOMBRE",row || gx.fn.currentGridRowImpl(118),gx.O.A34EstadoProyectoNombre,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(row){if(this.val(row)!==undefined)gx.O.A34EstadoProyectoNombre=this.val(row)},val:function(row){return gx.fn.getGridControlValue("ESTADOPROYECTONOMBRE",row || gx.fn.currentGridRowImpl(118))},nac:gx.falseFn};
   GXValidFnc[123]={ id: 123, fld:"",grid:0};
   GXValidFnc[124]={ id: 124, fld:"",grid:0};
   GXValidFnc[125]={ id: 125, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[127]={ id: 127, fld:"",grid:0};
   GXValidFnc[128]={ id: 128, fld:"",grid:0};
   GXValidFnc[129]={ id: 129, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[130]={ id: 130, fld:"JSDYNAMICFILTERS", format:1,grid:0};
   GXValidFnc[132]={ id:132 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE",gxz:"ZV60ddo_EstadoProyectoIDTitleControlIdToReplace",gxold:"OV60ddo_EstadoProyectoIDTitleControlIdToReplace",gxvar:"AV60ddo_EstadoProyectoIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV60ddo_EstadoProyectoIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV60ddo_EstadoProyectoIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE",gx.O.AV60ddo_EstadoProyectoIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV60ddo_EstadoProyectoIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[134]={ id:134 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE",gxz:"ZV64ddo_EstadoProyectoNombreTitleControlIdToReplace",gxold:"OV64ddo_EstadoProyectoNombreTitleControlIdToReplace",gxvar:"AV64ddo_EstadoProyectoNombreTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV64ddo_EstadoProyectoNombreTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV64ddo_EstadoProyectoNombreTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE",gx.O.AV64ddo_EstadoProyectoNombreTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV64ddo_EstadoProyectoNombreTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[138]={ id:138 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSENABLED2",gxz:"ZV19DynamicFiltersEnabled2",gxold:"OV19DynamicFiltersEnabled2",gxvar:"AV19DynamicFiltersEnabled2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV19DynamicFiltersEnabled2=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19DynamicFiltersEnabled2=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vDYNAMICFILTERSENABLED2",gx.O.AV19DynamicFiltersEnabled2,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV19DynamicFiltersEnabled2=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vDYNAMICFILTERSENABLED2")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[139]={ id:139 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDYNAMICFILTERSENABLED3",gxz:"ZV23DynamicFiltersEnabled3",gxold:"OV23DynamicFiltersEnabled3",gxvar:"AV23DynamicFiltersEnabled3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV23DynamicFiltersEnabled3=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23DynamicFiltersEnabled3=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vDYNAMICFILTERSENABLED3",gx.O.AV23DynamicFiltersEnabled3,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV23DynamicFiltersEnabled3=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vDYNAMICFILTERSENABLED3")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[140]={ id:140 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[141]={ id:141 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[142]={ id:142 ,lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMANAGEFILTERSEXECUTIONSTEP",gxz:"ZV51ManageFiltersExecutionStep",gxold:"OV51ManageFiltersExecutionStep",gxvar:"AV51ManageFiltersExecutionStep",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51ManageFiltersExecutionStep=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV51ManageFiltersExecutionStep=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vMANAGEFILTERSEXECUTIONSTEP",gx.O.AV51ManageFiltersExecutionStep,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV51ManageFiltersExecutionStep=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vMANAGEFILTERSEXECUTIONSTEP",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[143]={ id:143 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFESTADOPROYECTOID",gxz:"ZV58TFEstadoProyectoID",gxold:"OV58TFEstadoProyectoID",gxvar:"AV58TFEstadoProyectoID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV58TFEstadoProyectoID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV58TFEstadoProyectoID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFESTADOPROYECTOID",gx.O.AV58TFEstadoProyectoID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV58TFEstadoProyectoID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFESTADOPROYECTOID",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[144]={ id:144 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFESTADOPROYECTOID_TO",gxz:"ZV59TFEstadoProyectoID_To",gxold:"OV59TFEstadoProyectoID_To",gxvar:"AV59TFEstadoProyectoID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV59TFEstadoProyectoID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV59TFEstadoProyectoID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFESTADOPROYECTOID_TO",gx.O.AV59TFEstadoProyectoID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV59TFEstadoProyectoID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFESTADOPROYECTOID_TO",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[145]={ id:145 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFESTADOPROYECTONOMBRE",gxz:"ZV62TFEstadoProyectoNombre",gxold:"OV62TFEstadoProyectoNombre",gxvar:"AV62TFEstadoProyectoNombre",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV62TFEstadoProyectoNombre=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV62TFEstadoProyectoNombre=Value},v2c:function(){gx.fn.setControlValue("vTFESTADOPROYECTONOMBRE",gx.O.AV62TFEstadoProyectoNombre,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV62TFEstadoProyectoNombre=this.val()},val:function(){return gx.fn.getControlValue("vTFESTADOPROYECTONOMBRE")},nac:gx.falseFn};
   GXValidFnc[146]={ id:146 ,lvl:0,type:"char",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFESTADOPROYECTONOMBRE_SEL",gxz:"ZV63TFEstadoProyectoNombre_Sel",gxold:"OV63TFEstadoProyectoNombre_Sel",gxvar:"AV63TFEstadoProyectoNombre_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV63TFEstadoProyectoNombre_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV63TFEstadoProyectoNombre_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFESTADOPROYECTONOMBRE_SEL",gx.O.AV63TFEstadoProyectoNombre_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV63TFEstadoProyectoNombre_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFESTADOPROYECTONOMBRE_SEL")},nac:gx.falseFn};
   this.AV16DynamicFiltersSelector1 = "" ;
   this.ZV16DynamicFiltersSelector1 = "" ;
   this.OV16DynamicFiltersSelector1 = "" ;
   this.AV17DynamicFiltersOperator1 = 0 ;
   this.ZV17DynamicFiltersOperator1 = 0 ;
   this.OV17DynamicFiltersOperator1 = 0 ;
   this.AV18EstadoProyectoNombre1 = "" ;
   this.ZV18EstadoProyectoNombre1 = "" ;
   this.OV18EstadoProyectoNombre1 = "" ;
   this.AV20DynamicFiltersSelector2 = "" ;
   this.ZV20DynamicFiltersSelector2 = "" ;
   this.OV20DynamicFiltersSelector2 = "" ;
   this.AV21DynamicFiltersOperator2 = 0 ;
   this.ZV21DynamicFiltersOperator2 = 0 ;
   this.OV21DynamicFiltersOperator2 = 0 ;
   this.AV22EstadoProyectoNombre2 = "" ;
   this.ZV22EstadoProyectoNombre2 = "" ;
   this.OV22EstadoProyectoNombre2 = "" ;
   this.AV24DynamicFiltersSelector3 = "" ;
   this.ZV24DynamicFiltersSelector3 = "" ;
   this.OV24DynamicFiltersSelector3 = "" ;
   this.AV25DynamicFiltersOperator3 = 0 ;
   this.ZV25DynamicFiltersOperator3 = 0 ;
   this.OV25DynamicFiltersOperator3 = 0 ;
   this.AV26EstadoProyectoNombre3 = "" ;
   this.ZV26EstadoProyectoNombre3 = "" ;
   this.OV26EstadoProyectoNombre3 = "" ;
   this.ZV69Update = "" ;
   this.OV69Update = "" ;
   this.ZV70Delete = "" ;
   this.OV70Delete = "" ;
   this.Z7EstadoProyectoID = 0 ;
   this.O7EstadoProyectoID = 0 ;
   this.Z34EstadoProyectoNombre = "" ;
   this.O34EstadoProyectoNombre = "" ;
   this.AV60ddo_EstadoProyectoIDTitleControlIdToReplace = "" ;
   this.ZV60ddo_EstadoProyectoIDTitleControlIdToReplace = "" ;
   this.OV60ddo_EstadoProyectoIDTitleControlIdToReplace = "" ;
   this.AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = "" ;
   this.ZV64ddo_EstadoProyectoNombreTitleControlIdToReplace = "" ;
   this.OV64ddo_EstadoProyectoNombreTitleControlIdToReplace = "" ;
   this.AV19DynamicFiltersEnabled2 = false ;
   this.ZV19DynamicFiltersEnabled2 = false ;
   this.OV19DynamicFiltersEnabled2 = false ;
   this.AV23DynamicFiltersEnabled3 = false ;
   this.ZV23DynamicFiltersEnabled3 = false ;
   this.OV23DynamicFiltersEnabled3 = false ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV51ManageFiltersExecutionStep = 0 ;
   this.ZV51ManageFiltersExecutionStep = 0 ;
   this.OV51ManageFiltersExecutionStep = 0 ;
   this.AV58TFEstadoProyectoID = 0 ;
   this.ZV58TFEstadoProyectoID = 0 ;
   this.OV58TFEstadoProyectoID = 0 ;
   this.AV59TFEstadoProyectoID_To = 0 ;
   this.ZV59TFEstadoProyectoID_To = 0 ;
   this.OV59TFEstadoProyectoID_To = 0 ;
   this.AV62TFEstadoProyectoNombre = "" ;
   this.ZV62TFEstadoProyectoNombre = "" ;
   this.OV62TFEstadoProyectoNombre = "" ;
   this.AV63TFEstadoProyectoNombre_Sel = "" ;
   this.ZV63TFEstadoProyectoNombre_Sel = "" ;
   this.OV63TFEstadoProyectoNombre_Sel = "" ;
   this.AV55ManageFiltersData = [ ] ;
   this.AV16DynamicFiltersSelector1 = "" ;
   this.AV17DynamicFiltersOperator1 = 0 ;
   this.AV18EstadoProyectoNombre1 = "" ;
   this.AV20DynamicFiltersSelector2 = "" ;
   this.AV21DynamicFiltersOperator2 = 0 ;
   this.AV22EstadoProyectoNombre2 = "" ;
   this.AV24DynamicFiltersSelector3 = "" ;
   this.AV25DynamicFiltersOperator3 = 0 ;
   this.AV26EstadoProyectoNombre3 = "" ;
   this.AV67GridCurrentPage = 0 ;
   this.AV65DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:"",TreeviewCollapse:"",TreeviewCollapse_GXI:"",TreeviewExpand:"",TreeviewExpand_GXI:""} ;
   this.AV60ddo_EstadoProyectoIDTitleControlIdToReplace = "" ;
   this.AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = "" ;
   this.AV19DynamicFiltersEnabled2 = false ;
   this.AV23DynamicFiltersEnabled3 = false ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV51ManageFiltersExecutionStep = 0 ;
   this.AV58TFEstadoProyectoID = 0 ;
   this.AV59TFEstadoProyectoID_To = 0 ;
   this.AV62TFEstadoProyectoNombre = "" ;
   this.AV63TFEstadoProyectoNombre_Sel = "" ;
   this.AV69Update = "" ;
   this.AV70Delete = "" ;
   this.A7EstadoProyectoID = 0 ;
   this.A34EstadoProyectoNombre = "" ;
   this.AV43ColumnsSelector = {Columns:[]} ;
   this.AV88Pgmname = "" ;
   this.AV10GridState = {CurrentPage:0,OrderedBy:0,OrderedDsc:false,HidingSearch:0,PageSize:"",FilterValues:[],DynamicFilters:[]} ;
   this.AV28DynamicFiltersIgnoreFirst = false ;
   this.AV27DynamicFiltersRemoving = false ;
   this.AV12GridStateDynamicFilter = {Selected:"",Value:"",Operator:0,ValueTo:""} ;
   this.Events = {"e121f2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e131f2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e141f2_client": ["DDO_ESTADOPROYECTOID.ONOPTIONCLICKED", true] ,"e151f2_client": ["DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED", true] ,"e161f2_client": ["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED", true] ,"e171f2_client": ["'REMOVEDYNAMICFILTERS1'", true] ,"e181f2_client": ["'REMOVEDYNAMICFILTERS2'", true] ,"e191f2_client": ["'REMOVEDYNAMICFILTERS3'", true] ,"e111f2_client": ["DDO_MANAGEFILTERS.ONOPTIONCLICKED", true] ,"e201f2_client": ["'DOINSERT'", true] ,"e211f2_client": ["'DOEXPORT'", true] ,"e221f2_client": ["'DOEXPORTREPORT'", true] ,"e231f2_client": ["'ADDDYNAMICFILTERS1'", true] ,"e241f2_client": ["VDYNAMICFILTERSSELECTOR1.CLICK", true] ,"e251f2_client": ["'ADDDYNAMICFILTERS2'", true] ,"e261f2_client": ["VDYNAMICFILTERSSELECTOR2.CLICK", true] ,"e271f2_client": ["VDYNAMICFILTERSSELECTOR3.CLICK", true] ,"e311f2_client": ["ENTER", true] ,"e321f2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vMANAGEFILTERSEXECUTIONSTEP","Visible")',ctrl:'vMANAGEFILTERSEXECUTIONSTEP',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vDYNAMICFILTERSENABLED2","Visible")',ctrl:'vDYNAMICFILTERSENABLED2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vDYNAMICFILTERSENABLED3","Visible")',ctrl:'vDYNAMICFILTERSENABLED3',prop:'Visible'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Jsonclick")',ctrl:'ADDDYNAMICFILTERS1',prop:'Jsonclick'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Jsonclick")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Jsonclick'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Jsonclick")',ctrl:'ADDDYNAMICFILTERS2',prop:'Jsonclick'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Jsonclick")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Jsonclick'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS3","Jsonclick")',ctrl:'REMOVEDYNAMICFILTERS3',prop:'Jsonclick'},{av:'gx.fn.getCtrlProperty("vTFESTADOPROYECTOID","Visible")',ctrl:'vTFESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFESTADOPROYECTOID_TO","Visible")',ctrl:'vTFESTADOPROYECTOID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFESTADOPROYECTONOMBRE","Visible")',ctrl:'vTFESTADOPROYECTONOMBRE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFESTADOPROYECTONOMBRE_SEL","Visible")',ctrl:'vTFESTADOPROYECTONOMBRE_SEL',prop:'Visible'},{av:'this.DDO_ESTADOPROYECTOIDContainer.TitleControlIdToReplace',ctrl:'DDO_ESTADOPROYECTOID',prop:'TitleControlIdToReplace'},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.TitleControlIdToReplace',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'TitleControlIdToReplace'},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'this.DDO_MANAGEFILTERSContainer.Icon',ctrl:'DDO_MANAGEFILTERS',prop:'Icon'},{av:'AV65DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.DDO_GRIDCOLUMNSSELECTORContainer.TitleControlIdToReplace',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'TitleControlIdToReplace'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredTextTo_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SelectedValue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["DDO_ESTADOPROYECTOID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.ActiveEventKey',ctrl:'DDO_ESTADOPROYECTOID',prop:'ActiveEventKey'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredText_get',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_get'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredTextTo_get',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_get'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.ActiveEventKey',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'ActiveEventKey'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.FilteredText_get',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_get'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SelectedValue_get',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_get'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV69Update',fld:'vUPDATE',pic:''},{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:'vUPDATE',prop:'Link'},{av:'AV70Delete',fld:'vDELETE',pic:''},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:'vDELETE',prop:'Link'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Link")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Link'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_GRIDCOLUMNSSELECTORContainer.ColumnsSelectorValues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'ADDDYNAMICFILTERS1'"] = [[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'REMOVEDYNAMICFILTERS1'"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["VDYNAMICFILTERSSELECTOR1.CLICK"] = [[{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'ADDDYNAMICFILTERS2'"] = [[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'REMOVEDYNAMICFILTERS2'"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["VDYNAMICFILTERSSELECTOR2.CLICK"] = [[{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'REMOVEDYNAMICFILTERS3'"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["VDYNAMICFILTERSSELECTOR3.CLICK"] = [[{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["DDO_MANAGEFILTERS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_MANAGEFILTERSContainer.ActiveEventKey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredTextTo_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SelectedValue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Visible")',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Visible")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{ctrl:'ESTADOPROYECTOID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTOID","Title")',ctrl:'ESTADOPROYECTOID',prop:'Title'},{ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("ESTADOPROYECTONOMBRE","Title")',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'DOEXPORT'"] = [[{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredTextTo_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SelectedValue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.EvtParms["'DOEXPORTREPORT'"] = [[{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}],[{av:'this.INNEWWINDOW1Container.Target',ctrl:'INNEWWINDOW1',prop:'Target'},{av:'this.INNEWWINDOW1Container.Height',ctrl:'INNEWWINDOW1',prop:'Height'},{av:'this.INNEWWINDOW1Container.Width',ctrl:'INNEWWINDOW1',prop:'Width'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'vDYNAMICFILTERSSELECTOR1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{ctrl:'vDYNAMICFILTERSSELECTOR3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{ctrl:'vDYNAMICFILTERSOPERATOR3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'this.DDO_ESTADOPROYECTOIDContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SortedStatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTOIDContainer.FilteredTextTo_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.FilteredText_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'this.DDO_ESTADOPROYECTONOMBREContainer.SelectedValue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS1","Visible")',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS1","Visible")',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("ADDDYNAMICFILTERS2","Visible")',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("REMOVEDYNAMICFILTERS2","Visible")',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("JSDYNAMICFILTERS","Caption")',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE1","Visible")',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE2","Visible")',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vESTADOPROYECTONOMBRE3","Visible")',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]];
   this.setVCMap("AV43ColumnsSelector", "vCOLUMNSSELECTOR", 0, "WWPBaseObjects\WWPColumnsSelector", 0, 0);
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV10GridState", "vGRIDSTATE", 0, "WWPBaseObjects\WWPGridState", 0, 0);
   this.setVCMap("AV28DynamicFiltersIgnoreFirst", "vDYNAMICFILTERSIGNOREFIRST", 0, "boolean", 4, 0);
   this.setVCMap("AV27DynamicFiltersRemoving", "vDYNAMICFILTERSREMOVING", 0, "boolean", 4, 0);
   this.setVCMap("AV43ColumnsSelector", "vCOLUMNSSELECTOR", 0, "WWPBaseObjects\WWPColumnsSelector", 0, 0);
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV10GridState", "vGRIDSTATE", 0, "WWPBaseObjects\WWPGridState", 0, 0);
   this.setVCMap("AV28DynamicFiltersIgnoreFirst", "vDYNAMICFILTERSIGNOREFIRST", 0, "boolean", 4, 0);
   this.setVCMap("AV27DynamicFiltersRemoving", "vDYNAMICFILTERSREMOVING", 0, "boolean", 4, 0);
   this.setVCMap("AV43ColumnsSelector", "vCOLUMNSSELECTOR", 0, "WWPBaseObjects\WWPColumnsSelector", 0, 0);
   this.setVCMap("AV88Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV10GridState", "vGRIDSTATE", 0, "WWPBaseObjects\WWPGridState", 0, 0);
   this.setVCMap("AV28DynamicFiltersIgnoreFirst", "vDYNAMICFILTERSIGNOREFIRST", 0, "boolean", 4, 0);
   this.setVCMap("AV27DynamicFiltersRemoving", "vDYNAMICFILTERSREMOVING", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[56]);
   GridContainer.addRefreshingVar(this.GXValidFnc[69]);
   GridContainer.addRefreshingVar(this.GXValidFnc[77]);
   GridContainer.addRefreshingVar(this.GXValidFnc[80]);
   GridContainer.addRefreshingVar(this.GXValidFnc[93]);
   GridContainer.addRefreshingVar(this.GXValidFnc[101]);
   GridContainer.addRefreshingVar(this.GXValidFnc[104]);
   GridContainer.addRefreshingVar(this.GXValidFnc[138]);
   GridContainer.addRefreshingVar(this.GXValidFnc[139]);
   GridContainer.addRefreshingVar(this.GXValidFnc[140]);
   GridContainer.addRefreshingVar(this.GXValidFnc[141]);
   GridContainer.addRefreshingVar(this.GXValidFnc[143]);
   GridContainer.addRefreshingVar(this.GXValidFnc[144]);
   GridContainer.addRefreshingVar(this.GXValidFnc[145]);
   GridContainer.addRefreshingVar(this.GXValidFnc[146]);
   GridContainer.addRefreshingVar(this.GXValidFnc[142]);
   GridContainer.addRefreshingVar({rfrVar:"AV43ColumnsSelector"});
   GridContainer.addRefreshingVar(this.GXValidFnc[132]);
   GridContainer.addRefreshingVar(this.GXValidFnc[134]);
   GridContainer.addRefreshingVar({rfrVar:"AV88Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV10GridState"});
   GridContainer.addRefreshingVar({rfrVar:"AV28DynamicFiltersIgnoreFirst"});
   GridContainer.addRefreshingVar({rfrVar:"AV27DynamicFiltersRemoving"});
   GridContainer.addRefreshingParm(this.GXValidFnc[45]);
   GridContainer.addRefreshingParm(this.GXValidFnc[53]);
   GridContainer.addRefreshingParm(this.GXValidFnc[56]);
   GridContainer.addRefreshingParm(this.GXValidFnc[69]);
   GridContainer.addRefreshingParm(this.GXValidFnc[77]);
   GridContainer.addRefreshingParm(this.GXValidFnc[80]);
   GridContainer.addRefreshingParm(this.GXValidFnc[93]);
   GridContainer.addRefreshingParm(this.GXValidFnc[101]);
   GridContainer.addRefreshingParm(this.GXValidFnc[104]);
   GridContainer.addRefreshingParm(this.GXValidFnc[138]);
   GridContainer.addRefreshingParm(this.GXValidFnc[139]);
   GridContainer.addRefreshingParm(this.GXValidFnc[140]);
   GridContainer.addRefreshingParm(this.GXValidFnc[141]);
   GridContainer.addRefreshingParm(this.GXValidFnc[143]);
   GridContainer.addRefreshingParm(this.GXValidFnc[144]);
   GridContainer.addRefreshingParm(this.GXValidFnc[145]);
   GridContainer.addRefreshingParm(this.GXValidFnc[146]);
   GridContainer.addRefreshingParm(this.GXValidFnc[142]);
   GridContainer.addRefreshingParm({rfrVar:"AV43ColumnsSelector"});
   GridContainer.addRefreshingParm(this.GXValidFnc[132]);
   GridContainer.addRefreshingParm(this.GXValidFnc[134]);
   GridContainer.addRefreshingParm({rfrVar:"AV88Pgmname"});
   GridContainer.addRefreshingParm({rfrVar:"AV10GridState"});
   GridContainer.addRefreshingParm({rfrVar:"AV28DynamicFiltersIgnoreFirst"});
   GridContainer.addRefreshingParm({rfrVar:"AV27DynamicFiltersRemoving"});
   this.Initialize( );
});
gx.wi( function() { gx.createParentObj(estadoproyectoww);});
