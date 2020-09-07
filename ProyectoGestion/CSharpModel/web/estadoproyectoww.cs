/*
               File: EstadoProyectoWW
        Description:  Estado Proyecto
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/25/2020 17:59:58.19
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estadoproyectoww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public estadoproyectoww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public estadoproyectoww( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavDynamicfiltersselector1 = new GXCombobox();
         cmbavDynamicfiltersoperator1 = new GXCombobox();
         cmbavDynamicfiltersselector2 = new GXCombobox();
         cmbavDynamicfiltersoperator2 = new GXCombobox();
         cmbavDynamicfiltersselector3 = new GXCombobox();
         cmbavDynamicfiltersoperator3 = new GXCombobox();
         chkavDynamicfiltersenabled2 = new GXCheckbox();
         chkavDynamicfiltersenabled3 = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_118 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_118_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_118_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV16DynamicFiltersSelector1 = GetNextPar( );
               AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18EstadoProyectoNombre1 = GetNextPar( );
               AV20DynamicFiltersSelector2 = GetNextPar( );
               AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV22EstadoProyectoNombre2 = GetNextPar( );
               AV24DynamicFiltersSelector3 = GetNextPar( );
               AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26EstadoProyectoNombre3 = GetNextPar( );
               AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV58TFEstadoProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV59TFEstadoProyectoID_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV62TFEstadoProyectoNombre = GetNextPar( );
               AV63TFEstadoProyectoNombre_Sel = GetNextPar( );
               AV51ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV43ColumnsSelector);
               AV60ddo_EstadoProyectoIDTitleControlIdToReplace = GetNextPar( );
               AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = GetNextPar( );
               AV88Pgmname = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV10GridState);
               AV28DynamicFiltersIgnoreFirst = StringUtil.StrToBool( GetNextPar( ));
               AV27DynamicFiltersRemoving = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               send_integrity_footer_hashes( ) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               AddString( context.getJSONResponse( )) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA1F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1F2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202082517595864", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("Window/InNewWindowRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("estadoproyectoww.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV88Pgmname, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR1", AV16DynamicFiltersSelector1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17DynamicFiltersOperator1), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vESTADOPROYECTONOMBRE1", StringUtil.RTrim( AV18EstadoProyectoNombre1));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV20DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21DynamicFiltersOperator2), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vESTADOPROYECTONOMBRE2", StringUtil.RTrim( AV22EstadoProyectoNombre2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV24DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25DynamicFiltersOperator3), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vESTADOPROYECTONOMBRE3", StringUtil.RTrim( AV26EstadoProyectoNombre3));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV19DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV23DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFESTADOPROYECTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV58TFEstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFESTADOPROYECTOID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFEstadoProyectoID_To), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFESTADOPROYECTONOMBRE", StringUtil.RTrim( AV62TFEstadoProyectoNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vTFESTADOPROYECTONOMBRE_SEL", StringUtil.RTrim( AV63TFEstadoProyectoNombre_Sel));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_118", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_118), 8, 0, context.GetLanguageProperty( "decimal_point"), "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV55ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV55ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV67GridCurrentPage), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV68GridPageCount), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV65DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV65DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vESTADOPROYECTOIDTITLEFILTERDATA", AV57EstadoProyectoIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vESTADOPROYECTOIDTITLEFILTERDATA", AV57EstadoProyectoIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vESTADOPROYECTONOMBRETITLEFILTERDATA", AV61EstadoProyectoNombreTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vESTADOPROYECTONOMBRETITLEFILTERDATA", AV61EstadoProyectoNombreTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV43ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV43ColumnsSelector);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV88Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV88Pgmname, "")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATE", AV10GridState);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATE", AV10GridState);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSIGNOREFIRST", AV28DynamicFiltersIgnoreFirst);
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSREMOVING", AV27DynamicFiltersRemoving);
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Icon", StringUtil.RTrim( Ddo_managefilters_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Caption", StringUtil.RTrim( Ddo_managefilters_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Tooltip", StringUtil.RTrim( Ddo_managefilters_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Cls", StringUtil.RTrim( Ddo_managefilters_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Caption", StringUtil.RTrim( Ddo_estadoproyectoid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Tooltip", StringUtil.RTrim( Ddo_estadoproyectoid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Cls", StringUtil.RTrim( Ddo_estadoproyectoid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtext_set", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtextto_set", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_estadoproyectoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_estadoproyectoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Includesortasc", StringUtil.BoolToStr( Ddo_estadoproyectoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Includesortdsc", StringUtil.BoolToStr( Ddo_estadoproyectoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Sortedstatus", StringUtil.RTrim( Ddo_estadoproyectoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Includefilter", StringUtil.BoolToStr( Ddo_estadoproyectoid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filtertype", StringUtil.RTrim( Ddo_estadoproyectoid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filterisrange", StringUtil.BoolToStr( Ddo_estadoproyectoid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Includedatalist", StringUtil.BoolToStr( Ddo_estadoproyectoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Sortasc", StringUtil.RTrim( Ddo_estadoproyectoid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Sortdsc", StringUtil.RTrim( Ddo_estadoproyectoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Cleanfilter", StringUtil.RTrim( Ddo_estadoproyectoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Rangefilterfrom", StringUtil.RTrim( Ddo_estadoproyectoid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Rangefilterto", StringUtil.RTrim( Ddo_estadoproyectoid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Searchbuttontext", StringUtil.RTrim( Ddo_estadoproyectoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Caption", StringUtil.RTrim( Ddo_estadoproyectonombre_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Tooltip", StringUtil.RTrim( Ddo_estadoproyectonombre_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Cls", StringUtil.RTrim( Ddo_estadoproyectonombre_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Filteredtext_set", StringUtil.RTrim( Ddo_estadoproyectonombre_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Selectedvalue_set", StringUtil.RTrim( Ddo_estadoproyectonombre_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Dropdownoptionstype", StringUtil.RTrim( Ddo_estadoproyectonombre_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_estadoproyectonombre_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Includesortasc", StringUtil.BoolToStr( Ddo_estadoproyectonombre_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Includesortdsc", StringUtil.BoolToStr( Ddo_estadoproyectonombre_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Sortedstatus", StringUtil.RTrim( Ddo_estadoproyectonombre_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Includefilter", StringUtil.BoolToStr( Ddo_estadoproyectonombre_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Filtertype", StringUtil.RTrim( Ddo_estadoproyectonombre_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Filterisrange", StringUtil.BoolToStr( Ddo_estadoproyectonombre_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Includedatalist", StringUtil.BoolToStr( Ddo_estadoproyectonombre_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Datalisttype", StringUtil.RTrim( Ddo_estadoproyectonombre_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Datalistproc", StringUtil.RTrim( Ddo_estadoproyectonombre_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_estadoproyectonombre_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Sortasc", StringUtil.RTrim( Ddo_estadoproyectonombre_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Sortdsc", StringUtil.RTrim( Ddo_estadoproyectonombre_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Loadingdata", StringUtil.RTrim( Ddo_estadoproyectonombre_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Cleanfilter", StringUtil.RTrim( Ddo_estadoproyectonombre_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Noresultsfound", StringUtil.RTrim( Ddo_estadoproyectonombre_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Searchbuttontext", StringUtil.RTrim( Ddo_estadoproyectonombre_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Width", StringUtil.RTrim( Innewwindow1_Width));
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Height", StringUtil.RTrim( Innewwindow1_Height));
         GxWebStd.gx_hidden_field( context, "INNEWWINDOW1_Target", StringUtil.RTrim( Innewwindow1_Target));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Activeeventkey", StringUtil.RTrim( Ddo_estadoproyectoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtext_get", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtextto_get", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Activeeventkey", StringUtil.RTrim( Ddo_estadoproyectonombre_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Filteredtext_get", StringUtil.RTrim( Ddo_estadoproyectonombre_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Selectedvalue_get", StringUtil.RTrim( Ddo_estadoproyectonombre_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Activeeventkey", StringUtil.RTrim( Ddo_estadoproyectoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtext_get", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTOID_Filteredtextto_get", StringUtil.RTrim( Ddo_estadoproyectoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Activeeventkey", StringUtil.RTrim( Ddo_estadoproyectonombre_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Filteredtext_get", StringUtil.RTrim( Ddo_estadoproyectonombre_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_ESTADOPROYECTONOMBRE_Selectedvalue_get", StringUtil.RTrim( Ddo_estadoproyectonombre_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
         context.WriteHtmlText( "<script type=\"text/javascript\">") ;
         context.WriteHtmlText( "gx.setLanguageCode(\""+context.GetLanguageProperty( "code")+"\");") ;
         if ( ! context.isSpaRequest( ) )
         {
            context.WriteHtmlText( "gx.setDateFormat(\""+context.GetLanguageProperty( "date_fmt")+"\");") ;
            context.WriteHtmlText( "gx.setTimeFormat("+context.GetLanguageProperty( "time_fmt")+");") ;
            context.WriteHtmlText( "gx.setCenturyFirstYear("+40+");") ;
            context.WriteHtmlText( "gx.setDecimalPoint(\""+context.GetLanguageProperty( "decimal_point")+"\");") ;
            context.WriteHtmlText( "gx.setThousandSeparator(\""+context.GetLanguageProperty( "thousand_sep")+"\");") ;
            context.WriteHtmlText( "gx.StorageTimeZone = "+1+";") ;
         }
         context.WriteHtmlText( "</script>") ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1F2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1F2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("estadoproyectoww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "EstadoProyectoWW" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( " Estado Proyecto", "") ;
      }

      protected void WB1F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableheader.SetProperty("Width", Dvpanel_tableheader_Width);
            ucDvpanel_tableheader.SetProperty("AutoWidth", Dvpanel_tableheader_Autowidth);
            ucDvpanel_tableheader.SetProperty("AutoHeight", Dvpanel_tableheader_Autoheight);
            ucDvpanel_tableheader.SetProperty("Cls", Dvpanel_tableheader_Cls);
            ucDvpanel_tableheader.SetProperty("Title", Dvpanel_tableheader_Title);
            ucDvpanel_tableheader.SetProperty("Collapsible", Dvpanel_tableheader_Collapsible);
            ucDvpanel_tableheader.SetProperty("Collapsed", Dvpanel_tableheader_Collapsed);
            ucDvpanel_tableheader.SetProperty("ShowCollapseIcon", Dvpanel_tableheader_Showcollapseicon);
            ucDvpanel_tableheader.SetProperty("IconPosition", Dvpanel_tableheader_Iconposition);
            ucDvpanel_tableheader.SetProperty("AutoScroll", Dvpanel_tableheader_Autoscroll);
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupGrouped", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(118), 3, 0)+","+"null"+");", context.GetMessage( "GXM_insert", ""), bttBtninsert_Jsonclick, 5, context.GetMessage( "GXM_insert", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnexport_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(118), 3, 0)+","+"null"+");", context.GetMessage( "WWP_ExportCaption", ""), bttBtnexport_Jsonclick, 5, context.GetMessage( "WWP_ExportTooltip", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOEXPORT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnexportreport_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(118), 3, 0)+","+"null"+");", context.GetMessage( "WWP_ExportReportCaption", ""), bttBtnexportreport_Jsonclick, 5, context.GetMessage( "WWP_ExportReportTooltip", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOEXPORTREPORT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(118), 3, 0)+","+"null"+");", context.GetMessage( "WWP_EditColumnsCaption", ""), bttBtneditcolumns_Jsonclick, 0, context.GetMessage( "WWP_EditColumnsTooltip", ""), "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_30_1F2( true) ;
         }
         else
         {
            wb_table1_30_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_30_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid GridNoBorderCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"118\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridNoBorder WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtEstadoProyectoID_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtEstadoProyectoID_Titleformat == 0 )
               {
                  context.SendWebValue( edtEstadoProyectoID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtEstadoProyectoID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtEstadoProyectoNombre_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtEstadoProyectoNombre_Titleformat == 0 )
               {
                  context.SendWebValue( edtEstadoProyectoNombre_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtEstadoProyectoNombre_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridNoBorder WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV69Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV70Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EstadoProyectoID), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtEstadoProyectoID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstadoProyectoID_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstadoProyectoID_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A34EstadoProyectoNombre));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtEstadoProyectoNombre_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstadoProyectoNombre_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtEstadoProyectoNombre_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstadoProyectoNombre_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 118 )
         {
            wbEnd = 0;
            nRC_GXsfl_118 = (int)(nGXsfl_118_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucGridpaginationbar.SetProperty("Class", Gridpaginationbar_Class);
            ucGridpaginationbar.SetProperty("ShowFirst", Gridpaginationbar_Showfirst);
            ucGridpaginationbar.SetProperty("ShowPrevious", Gridpaginationbar_Showprevious);
            ucGridpaginationbar.SetProperty("ShowNext", Gridpaginationbar_Shownext);
            ucGridpaginationbar.SetProperty("ShowLast", Gridpaginationbar_Showlast);
            ucGridpaginationbar.SetProperty("PagesToShow", Gridpaginationbar_Pagestoshow);
            ucGridpaginationbar.SetProperty("PagingButtonsPosition", Gridpaginationbar_Pagingbuttonsposition);
            ucGridpaginationbar.SetProperty("PagingCaptionPosition", Gridpaginationbar_Pagingcaptionposition);
            ucGridpaginationbar.SetProperty("EmptyGridClass", Gridpaginationbar_Emptygridclass);
            ucGridpaginationbar.SetProperty("RowsPerPageSelector", Gridpaginationbar_Rowsperpageselector);
            ucGridpaginationbar.SetProperty("RowsPerPageOptions", Gridpaginationbar_Rowsperpageoptions);
            ucGridpaginationbar.SetProperty("Previous", Gridpaginationbar_Previous);
            ucGridpaginationbar.SetProperty("Next", Gridpaginationbar_Next);
            ucGridpaginationbar.SetProperty("Caption", Gridpaginationbar_Caption);
            ucGridpaginationbar.SetProperty("EmptyGridCaption", Gridpaginationbar_Emptygridcaption);
            ucGridpaginationbar.SetProperty("RowsPerPageCaption", Gridpaginationbar_Rowsperpagecaption);
            ucGridpaginationbar.SetProperty("CurrentPage", AV67GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV68GridPageCount);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_EstadoProyectoWW.htm");
            /* User Defined Control */
            ucDdo_estadoproyectoid.SetProperty("Caption", Ddo_estadoproyectoid_Caption);
            ucDdo_estadoproyectoid.SetProperty("Tooltip", Ddo_estadoproyectoid_Tooltip);
            ucDdo_estadoproyectoid.SetProperty("Cls", Ddo_estadoproyectoid_Cls);
            ucDdo_estadoproyectoid.SetProperty("DropDownOptionsType", Ddo_estadoproyectoid_Dropdownoptionstype);
            ucDdo_estadoproyectoid.SetProperty("IncludeSortASC", Ddo_estadoproyectoid_Includesortasc);
            ucDdo_estadoproyectoid.SetProperty("IncludeSortDSC", Ddo_estadoproyectoid_Includesortdsc);
            ucDdo_estadoproyectoid.SetProperty("IncludeFilter", Ddo_estadoproyectoid_Includefilter);
            ucDdo_estadoproyectoid.SetProperty("FilterType", Ddo_estadoproyectoid_Filtertype);
            ucDdo_estadoproyectoid.SetProperty("FilterIsRange", Ddo_estadoproyectoid_Filterisrange);
            ucDdo_estadoproyectoid.SetProperty("IncludeDataList", Ddo_estadoproyectoid_Includedatalist);
            ucDdo_estadoproyectoid.SetProperty("SortASC", Ddo_estadoproyectoid_Sortasc);
            ucDdo_estadoproyectoid.SetProperty("SortDSC", Ddo_estadoproyectoid_Sortdsc);
            ucDdo_estadoproyectoid.SetProperty("CleanFilter", Ddo_estadoproyectoid_Cleanfilter);
            ucDdo_estadoproyectoid.SetProperty("RangeFilterFrom", Ddo_estadoproyectoid_Rangefilterfrom);
            ucDdo_estadoproyectoid.SetProperty("RangeFilterTo", Ddo_estadoproyectoid_Rangefilterto);
            ucDdo_estadoproyectoid.SetProperty("SearchButtonText", Ddo_estadoproyectoid_Searchbuttontext);
            ucDdo_estadoproyectoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV65DDO_TitleSettingsIcons);
            ucDdo_estadoproyectoid.SetProperty("DropDownOptionsData", AV57EstadoProyectoIDTitleFilterData);
            ucDdo_estadoproyectoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_estadoproyectoid_Internalname, "DDO_ESTADOPROYECTOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'" + sGXsfl_118_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Internalname, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,132);\"", 0, edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_EstadoProyectoWW.htm");
            /* User Defined Control */
            ucDdo_estadoproyectonombre.SetProperty("Caption", Ddo_estadoproyectonombre_Caption);
            ucDdo_estadoproyectonombre.SetProperty("Tooltip", Ddo_estadoproyectonombre_Tooltip);
            ucDdo_estadoproyectonombre.SetProperty("Cls", Ddo_estadoproyectonombre_Cls);
            ucDdo_estadoproyectonombre.SetProperty("DropDownOptionsType", Ddo_estadoproyectonombre_Dropdownoptionstype);
            ucDdo_estadoproyectonombre.SetProperty("IncludeSortASC", Ddo_estadoproyectonombre_Includesortasc);
            ucDdo_estadoproyectonombre.SetProperty("IncludeSortDSC", Ddo_estadoproyectonombre_Includesortdsc);
            ucDdo_estadoproyectonombre.SetProperty("IncludeFilter", Ddo_estadoproyectonombre_Includefilter);
            ucDdo_estadoproyectonombre.SetProperty("FilterType", Ddo_estadoproyectonombre_Filtertype);
            ucDdo_estadoproyectonombre.SetProperty("FilterIsRange", Ddo_estadoproyectonombre_Filterisrange);
            ucDdo_estadoproyectonombre.SetProperty("IncludeDataList", Ddo_estadoproyectonombre_Includedatalist);
            ucDdo_estadoproyectonombre.SetProperty("DataListType", Ddo_estadoproyectonombre_Datalisttype);
            ucDdo_estadoproyectonombre.SetProperty("DataListProc", Ddo_estadoproyectonombre_Datalistproc);
            ucDdo_estadoproyectonombre.SetProperty("DataListUpdateMinimumCharacters", Ddo_estadoproyectonombre_Datalistupdateminimumcharacters);
            ucDdo_estadoproyectonombre.SetProperty("SortASC", Ddo_estadoproyectonombre_Sortasc);
            ucDdo_estadoproyectonombre.SetProperty("SortDSC", Ddo_estadoproyectonombre_Sortdsc);
            ucDdo_estadoproyectonombre.SetProperty("LoadingData", Ddo_estadoproyectonombre_Loadingdata);
            ucDdo_estadoproyectonombre.SetProperty("CleanFilter", Ddo_estadoproyectonombre_Cleanfilter);
            ucDdo_estadoproyectonombre.SetProperty("NoResultsFound", Ddo_estadoproyectonombre_Noresultsfound);
            ucDdo_estadoproyectonombre.SetProperty("SearchButtonText", Ddo_estadoproyectonombre_Searchbuttontext);
            ucDdo_estadoproyectonombre.SetProperty("DropDownOptionsTitleSettingsIcons", AV65DDO_TitleSettingsIcons);
            ucDdo_estadoproyectonombre.SetProperty("DropDownOptionsData", AV61EstadoProyectoNombreTitleFilterData);
            ucDdo_estadoproyectonombre.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_estadoproyectonombre_Internalname, "DDO_ESTADOPROYECTONOMBREContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'" + sGXsfl_118_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Internalname, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,134);\"", 0, edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_EstadoProyectoWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucInnewwindow1.Render(context, "innewwindow", Innewwindow1_Internalname, "INNEWWINDOW1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV65DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV43ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'" + sGXsfl_118_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV19DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(138, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,138);\"");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'" + sGXsfl_118_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV23DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick="+"\"gx.fn.checkboxClick(139, this, 'true', 'false',"+"''"+");"+"gx.evt.onchange(this, event);\""+" onblur=\""+""+";gx.evt.onblur(this,139);\"");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,140);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,141);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV51ManageFiltersExecutionStep), 1, 0, context.GetLanguageProperty( "decimal_point"), "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV51ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfestadoproyectoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV58TFEstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV58TFEstadoProyectoID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,143);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfestadoproyectoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfestadoproyectoid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfestadoproyectoid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFEstadoProyectoID_To), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV59TFEstadoProyectoID_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfestadoproyectoid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfestadoproyectoid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfestadoproyectonombre_Internalname, StringUtil.RTrim( AV62TFEstadoProyectoNombre), StringUtil.RTrim( context.localUtil.Format( AV62TFEstadoProyectoNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,145);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfestadoproyectonombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfestadoproyectonombre_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_EstadoProyectoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 146,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfestadoproyectonombre_sel_Internalname, StringUtil.RTrim( AV63TFEstadoProyectoNombre_Sel), StringUtil.RTrim( context.localUtil.Format( AV63TFEstadoProyectoNombre_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,146);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfestadoproyectonombre_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfestadoproyectonombre_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 118 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", context.GetMessage( " Estado Proyecto", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1F0( ) ;
      }

      protected void WS1F2( )
      {
         START1F2( ) ;
         EVT1F2( ) ;
      }

      protected void EVT1F2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_MANAGEFILTERS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E111F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E121F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E131F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_ESTADOPROYECTOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E141F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E151F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E161F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E171F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E181F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E191F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E201F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOEXPORT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoExport' */
                              E211F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOEXPORTREPORT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoExportReport' */
                              E221F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E231F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E241F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E251F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E261F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E271F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_118_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_118_idx), 4, 0), 4, "0");
                              SubsflControlProps_1182( ) ;
                              AV69Update = cgiGet( edtavUpdate_Internalname);
                              AssignAttri("", false, edtavUpdate_Internalname, AV69Update);
                              AV70Delete = cgiGet( edtavDelete_Internalname);
                              AssignAttri("", false, edtavDelete_Internalname, AV70Delete);
                              A7EstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( edtEstadoProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              A34EstadoProyectoNombre = cgiGet( edtEstadoProyectoNombre_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E281F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E291F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E301F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Dynamicfiltersselector1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV16DynamicFiltersSelector1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV17DynamicFiltersOperator1 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Estadoproyectonombre1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE1"), AV18EstadoProyectoNombre1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV20DynamicFiltersSelector2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV21DynamicFiltersOperator2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Estadoproyectonombre2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE2"), AV22EstadoProyectoNombre2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV24DynamicFiltersSelector3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV25DynamicFiltersOperator3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Estadoproyectonombre3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE3"), AV26EstadoProyectoNombre3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled2 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV19DynamicFiltersEnabled2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled3 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV23DynamicFiltersEnabled3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfestadoproyectoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFESTADOPROYECTOID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV58TFEstadoProyectoID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfestadoproyectoid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFESTADOPROYECTOID_TO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV59TFEstadoProyectoID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfestadoproyectonombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFESTADOPROYECTONOMBRE"), AV62TFEstadoProyectoNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfestadoproyectonombre_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFESTADOPROYECTONOMBRE_SEL"), AV63TFEstadoProyectoNombre_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1F2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavDynamicfiltersselector1_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_1182( ) ;
         while ( nGXsfl_118_idx <= nRC_GXsfl_118 )
         {
            sendrow_1182( ) ;
            nGXsfl_118_idx = ((subGrid_Islastpage==1)&&(nGXsfl_118_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_118_idx+1);
            sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_118_idx), 4, 0), 4, "0");
            SubsflControlProps_1182( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridContainer)) ;
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV16DynamicFiltersSelector1 ,
                                       short AV17DynamicFiltersOperator1 ,
                                       String AV18EstadoProyectoNombre1 ,
                                       String AV20DynamicFiltersSelector2 ,
                                       short AV21DynamicFiltersOperator2 ,
                                       String AV22EstadoProyectoNombre2 ,
                                       String AV24DynamicFiltersSelector3 ,
                                       short AV25DynamicFiltersOperator3 ,
                                       String AV26EstadoProyectoNombre3 ,
                                       bool AV19DynamicFiltersEnabled2 ,
                                       bool AV23DynamicFiltersEnabled3 ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       short AV58TFEstadoProyectoID ,
                                       short AV59TFEstadoProyectoID_To ,
                                       String AV62TFEstadoProyectoNombre ,
                                       String AV63TFEstadoProyectoNombre_Sel ,
                                       short AV51ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV43ColumnsSelector ,
                                       String AV60ddo_EstadoProyectoIDTitleControlIdToReplace ,
                                       String AV64ddo_EstadoProyectoNombreTitleControlIdToReplace ,
                                       String AV88Pgmname ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ,
                                       bool AV28DynamicFiltersIgnoreFirst ,
                                       bool AV27DynamicFiltersRemoving )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID_nCurrentRecord = 0;
         RF1F2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ESTADOPROYECTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ESTADOPROYECTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EstadoProyectoID), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV16DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV16DynamicFiltersSelector1);
            AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
            AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0))), "."));
            AssignAttri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrimStr( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV20DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV20DynamicFiltersSelector2);
            AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
            AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0))), "."));
            AssignAttri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrimStr( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV24DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV24DynamicFiltersSelector3);
            AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
            AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0))), "."));
            AssignAttri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrimStr( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         }
         AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( StringUtil.BoolToStr( AV19DynamicFiltersEnabled2));
         AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( StringUtil.BoolToStr( AV23DynamicFiltersEnabled3));
         AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV88Pgmname = "EstadoProyectoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_118_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_118_Refreshing);
      }

      protected void RF1F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 118;
         /* Execute user event: Refresh */
         E291F2 ();
         nGXsfl_118_idx = 1;
         sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_118_idx), 4, 0), 4, "0");
         SubsflControlProps_1182( ) ;
         bGXsfl_118_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridNoBorder WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_1182( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                                 AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                                 AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                                 AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                                 AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                                 AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                                 AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                                 AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                                 AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                                 AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                                 AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                                 AV84EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                                 AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                                 AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                                 AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                                 A34EstadoProyectoNombre ,
                                                 A7EstadoProyectoID ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
            lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
            lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
            lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
            lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
            lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
            lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = StringUtil.PadR( StringUtil.RTrim( AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre), 40, "%");
            /* Using cursor H001F2 */
            pr_default.execute(0, new Object[] {lV75EstadoProyectoWWDS_3_Estadoproyectonombre1, lV75EstadoProyectoWWDS_3_Estadoproyectonombre1, lV79EstadoProyectoWWDS_7_Estadoproyectonombre2, lV79EstadoProyectoWWDS_7_Estadoproyectonombre2, lV83EstadoProyectoWWDS_11_Estadoproyectonombre3, lV83EstadoProyectoWWDS_11_Estadoproyectonombre3, AV84EstadoProyectoWWDS_12_Tfestadoproyectoid, AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to, lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre, AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_118_idx = 1;
            sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_118_idx), 4, 0), 4, "0");
            SubsflControlProps_1182( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_fnc_Recordsperpage( ) ) ) ) )
            {
               A34EstadoProyectoNombre = H001F2_A34EstadoProyectoNombre[0];
               A7EstadoProyectoID = H001F2_A7EstadoProyectoID[0];
               E301F2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 118;
            WB1F0( ) ;
         }
         bGXsfl_118_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1F2( )
      {
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV88Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV88Pgmname, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ESTADOPROYECTOID"+"_"+sGXsfl_118_idx, GetSecureSignedToken( sGXsfl_118_idx, context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9"), context));
      }

      protected int subGrid_fnc_Pagecount( )
      {
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_fnc_Recordcount( )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                              AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                              AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                              AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                              AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                              AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                              AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                              AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                              AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                              AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                              AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                              AV84EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                              AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                              AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                              AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                              A34EstadoProyectoNombre ,
                                              A7EstadoProyectoID ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = StringUtil.PadR( StringUtil.RTrim( AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre), 40, "%");
         /* Using cursor H001F3 */
         pr_default.execute(1, new Object[] {lV75EstadoProyectoWWDS_3_Estadoproyectonombre1, lV75EstadoProyectoWWDS_3_Estadoproyectonombre1, lV79EstadoProyectoWWDS_7_Estadoproyectonombre2, lV79EstadoProyectoWWDS_7_Estadoproyectonombre2, lV83EstadoProyectoWWDS_11_Estadoproyectonombre3, lV83EstadoProyectoWWDS_11_Estadoproyectonombre3, AV84EstadoProyectoWWDS_12_Tfestadoproyectoid, AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to, lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre, AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel});
         GRID_nRecordCount = H001F3_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_fnc_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_fnc_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         if ( GRID_nFirstRecordOnPage >= subGrid_fnc_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( GRID_nRecordCount > subGrid_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_fnc_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1F0( )
      {
         /* Before Start, stand alone formulas. */
         AV88Pgmname = "EstadoProyectoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_118_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_118_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E281F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV55ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV65DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vESTADOPROYECTOIDTITLEFILTERDATA"), AV57EstadoProyectoIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vESTADOPROYECTONOMBRETITLEFILTERDATA"), AV61EstadoProyectoNombreTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV43ColumnsSelector);
            /* Read saved values. */
            nRC_GXsfl_118 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_118"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV67GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV68GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Ddo_managefilters_Icon = cgiGet( "DDO_MANAGEFILTERS_Icon");
            Ddo_managefilters_Caption = cgiGet( "DDO_MANAGEFILTERS_Caption");
            Ddo_managefilters_Tooltip = cgiGet( "DDO_MANAGEFILTERS_Tooltip");
            Ddo_managefilters_Cls = cgiGet( "DDO_MANAGEFILTERS_Cls");
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_estadoproyectoid_Caption = cgiGet( "DDO_ESTADOPROYECTOID_Caption");
            Ddo_estadoproyectoid_Tooltip = cgiGet( "DDO_ESTADOPROYECTOID_Tooltip");
            Ddo_estadoproyectoid_Cls = cgiGet( "DDO_ESTADOPROYECTOID_Cls");
            Ddo_estadoproyectoid_Filteredtext_set = cgiGet( "DDO_ESTADOPROYECTOID_Filteredtext_set");
            Ddo_estadoproyectoid_Filteredtextto_set = cgiGet( "DDO_ESTADOPROYECTOID_Filteredtextto_set");
            Ddo_estadoproyectoid_Dropdownoptionstype = cgiGet( "DDO_ESTADOPROYECTOID_Dropdownoptionstype");
            Ddo_estadoproyectoid_Titlecontrolidtoreplace = cgiGet( "DDO_ESTADOPROYECTOID_Titlecontrolidtoreplace");
            Ddo_estadoproyectoid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTOID_Includesortasc"));
            Ddo_estadoproyectoid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTOID_Includesortdsc"));
            Ddo_estadoproyectoid_Sortedstatus = cgiGet( "DDO_ESTADOPROYECTOID_Sortedstatus");
            Ddo_estadoproyectoid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTOID_Includefilter"));
            Ddo_estadoproyectoid_Filtertype = cgiGet( "DDO_ESTADOPROYECTOID_Filtertype");
            Ddo_estadoproyectoid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTOID_Filterisrange"));
            Ddo_estadoproyectoid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTOID_Includedatalist"));
            Ddo_estadoproyectoid_Sortasc = cgiGet( "DDO_ESTADOPROYECTOID_Sortasc");
            Ddo_estadoproyectoid_Sortdsc = cgiGet( "DDO_ESTADOPROYECTOID_Sortdsc");
            Ddo_estadoproyectoid_Cleanfilter = cgiGet( "DDO_ESTADOPROYECTOID_Cleanfilter");
            Ddo_estadoproyectoid_Rangefilterfrom = cgiGet( "DDO_ESTADOPROYECTOID_Rangefilterfrom");
            Ddo_estadoproyectoid_Rangefilterto = cgiGet( "DDO_ESTADOPROYECTOID_Rangefilterto");
            Ddo_estadoproyectoid_Searchbuttontext = cgiGet( "DDO_ESTADOPROYECTOID_Searchbuttontext");
            Ddo_estadoproyectonombre_Caption = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Caption");
            Ddo_estadoproyectonombre_Tooltip = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Tooltip");
            Ddo_estadoproyectonombre_Cls = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Cls");
            Ddo_estadoproyectonombre_Filteredtext_set = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Filteredtext_set");
            Ddo_estadoproyectonombre_Selectedvalue_set = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Selectedvalue_set");
            Ddo_estadoproyectonombre_Dropdownoptionstype = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Dropdownoptionstype");
            Ddo_estadoproyectonombre_Titlecontrolidtoreplace = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Titlecontrolidtoreplace");
            Ddo_estadoproyectonombre_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Includesortasc"));
            Ddo_estadoproyectonombre_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Includesortdsc"));
            Ddo_estadoproyectonombre_Sortedstatus = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Sortedstatus");
            Ddo_estadoproyectonombre_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Includefilter"));
            Ddo_estadoproyectonombre_Filtertype = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Filtertype");
            Ddo_estadoproyectonombre_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Filterisrange"));
            Ddo_estadoproyectonombre_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Includedatalist"));
            Ddo_estadoproyectonombre_Datalisttype = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Datalisttype");
            Ddo_estadoproyectonombre_Datalistproc = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Datalistproc");
            Ddo_estadoproyectonombre_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_ESTADOPROYECTONOMBRE_Datalistupdateminimumcharacters"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Ddo_estadoproyectonombre_Sortasc = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Sortasc");
            Ddo_estadoproyectonombre_Sortdsc = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Sortdsc");
            Ddo_estadoproyectonombre_Loadingdata = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Loadingdata");
            Ddo_estadoproyectonombre_Cleanfilter = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Cleanfilter");
            Ddo_estadoproyectonombre_Noresultsfound = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Noresultsfound");
            Ddo_estadoproyectonombre_Searchbuttontext = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Searchbuttontext");
            Innewwindow1_Width = cgiGet( "INNEWWINDOW1_Width");
            Innewwindow1_Height = cgiGet( "INNEWWINDOW1_Height");
            Innewwindow1_Target = cgiGet( "INNEWWINDOW1_Target");
            Ddo_gridcolumnsselector_Caption = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Caption");
            Ddo_gridcolumnsselector_Tooltip = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Tooltip");
            Ddo_gridcolumnsselector_Cls = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Cls");
            Ddo_gridcolumnsselector_Dropdownoptionstype = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype");
            Ddo_gridcolumnsselector_Titlecontrolidtoreplace = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace");
            Ddo_gridcolumnsselector_Updatebuttontext = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Ddo_estadoproyectoid_Activeeventkey = cgiGet( "DDO_ESTADOPROYECTOID_Activeeventkey");
            Ddo_estadoproyectoid_Filteredtext_get = cgiGet( "DDO_ESTADOPROYECTOID_Filteredtext_get");
            Ddo_estadoproyectoid_Filteredtextto_get = cgiGet( "DDO_ESTADOPROYECTOID_Filteredtextto_get");
            Ddo_estadoproyectonombre_Activeeventkey = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Activeeventkey");
            Ddo_estadoproyectonombre_Filteredtext_get = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Filteredtext_get");
            Ddo_estadoproyectonombre_Selectedvalue_get = cgiGet( "DDO_ESTADOPROYECTONOMBRE_Selectedvalue_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            Ddo_managefilters_Activeeventkey = cgiGet( "DDO_MANAGEFILTERS_Activeeventkey");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV16DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            AssignAttri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrimStr( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            AV18EstadoProyectoNombre1 = cgiGet( edtavEstadoproyectonombre1_Internalname);
            AssignAttri("", false, "AV18EstadoProyectoNombre1", AV18EstadoProyectoNombre1);
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV20DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            AssignAttri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrimStr( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
            AV22EstadoProyectoNombre2 = cgiGet( edtavEstadoproyectonombre2_Internalname);
            AssignAttri("", false, "AV22EstadoProyectoNombre2", AV22EstadoProyectoNombre2);
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV24DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            AssignAttri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrimStr( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
            AV26EstadoProyectoNombre3 = cgiGet( edtavEstadoproyectonombre3_Internalname);
            AssignAttri("", false, "AV26EstadoProyectoNombre3", AV26EstadoProyectoNombre3);
            AV60ddo_EstadoProyectoIDTitleControlIdToReplace = cgiGet( edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Internalname);
            AssignAttri("", false, "AV60ddo_EstadoProyectoIDTitleControlIdToReplace", AV60ddo_EstadoProyectoIDTitleControlIdToReplace);
            AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = cgiGet( edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Internalname);
            AssignAttri("", false, "AV64ddo_EstadoProyectoNombreTitleControlIdToReplace", AV64ddo_EstadoProyectoNombreTitleControlIdToReplace);
            AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled2_Internalname));
            AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
            AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled3_Internalname));
            AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMANAGEFILTERSEXECUTIONSTEP");
               GX_FocusControl = edtavManagefiltersexecutionstep_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV51ManageFiltersExecutionStep = 0;
               AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
            }
            else
            {
               AV51ManageFiltersExecutionStep = (short)(context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFESTADOPROYECTOID");
               GX_FocusControl = edtavTfestadoproyectoid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV58TFEstadoProyectoID = 0;
               AssignAttri("", false, "AV58TFEstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV58TFEstadoProyectoID), 4, 0));
            }
            else
            {
               AV58TFEstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "AV58TFEstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV58TFEstadoProyectoID), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_to_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_to_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFESTADOPROYECTOID_TO");
               GX_FocusControl = edtavTfestadoproyectoid_to_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV59TFEstadoProyectoID_To = 0;
               AssignAttri("", false, "AV59TFEstadoProyectoID_To", StringUtil.LTrimStr( (decimal)(AV59TFEstadoProyectoID_To), 4, 0));
            }
            else
            {
               AV59TFEstadoProyectoID_To = (short)(context.localUtil.CToN( cgiGet( edtavTfestadoproyectoid_to_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "AV59TFEstadoProyectoID_To", StringUtil.LTrimStr( (decimal)(AV59TFEstadoProyectoID_To), 4, 0));
            }
            AV62TFEstadoProyectoNombre = cgiGet( edtavTfestadoproyectonombre_Internalname);
            AssignAttri("", false, "AV62TFEstadoProyectoNombre", AV62TFEstadoProyectoNombre);
            AV63TFEstadoProyectoNombre_Sel = cgiGet( edtavTfestadoproyectonombre_sel_Internalname);
            AssignAttri("", false, "AV63TFEstadoProyectoNombre_Sel", AV63TFEstadoProyectoNombre_Sel);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV16DynamicFiltersSelector1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV17DynamicFiltersOperator1 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE1"), AV18EstadoProyectoNombre1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV20DynamicFiltersSelector2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV21DynamicFiltersOperator2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE2"), AV22EstadoProyectoNombre2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV24DynamicFiltersSelector3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV25DynamicFiltersOperator3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vESTADOPROYECTONOMBRE3"), AV26EstadoProyectoNombre3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV19DynamicFiltersEnabled2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV23DynamicFiltersEnabled3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFESTADOPROYECTOID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV58TFEstadoProyectoID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFESTADOPROYECTOID_TO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV59TFEstadoProyectoID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFESTADOPROYECTONOMBRE"), AV62TFEstadoProyectoNombre) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFESTADOPROYECTONOMBRE_SEL"), AV63TFEstadoProyectoNombre_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E281F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E281F2( )
      {
         /* Start Routine */
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            /* Execute user subroutine: 'LOADSAVEDFILTERS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            edtavManagefiltersexecutionstep_Visible = 0;
            AssignProp("", false, edtavManagefiltersexecutionstep_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavManagefiltersexecutionstep_Visible), 5, 0), true);
         }
         lblJsdynamicfilters_Caption = "";
         AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         chkavDynamicfiltersenabled2.Visible = 0;
         AssignProp("", false, chkavDynamicfiltersenabled2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(chkavDynamicfiltersenabled2.Visible), 5, 0), true);
         chkavDynamicfiltersenabled3.Visible = 0;
         AssignProp("", false, chkavDynamicfiltersenabled3_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(chkavDynamicfiltersenabled3.Visible), 5, 0), true);
         AV16DynamicFiltersSelector1 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV20DynamicFiltersSelector2 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV24DynamicFiltersSelector3 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         imgAdddynamicfilters1_Jsonclick = StringUtil.Format( "WWPDynFilterShow_AL('%1', 2, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AssignProp("", false, imgAdddynamicfilters1_Internalname, "Jsonclick", imgAdddynamicfilters1_Jsonclick, true);
         imgRemovedynamicfilters1_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AssignProp("", false, imgRemovedynamicfilters1_Internalname, "Jsonclick", imgRemovedynamicfilters1_Jsonclick, true);
         imgAdddynamicfilters2_Jsonclick = StringUtil.Format( "WWPDynFilterShow_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AssignProp("", false, imgAdddynamicfilters2_Internalname, "Jsonclick", imgAdddynamicfilters2_Jsonclick, true);
         imgRemovedynamicfilters2_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AssignProp("", false, imgRemovedynamicfilters2_Internalname, "Jsonclick", imgRemovedynamicfilters2_Jsonclick, true);
         imgRemovedynamicfilters3_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AssignProp("", false, imgRemovedynamicfilters3_Internalname, "Jsonclick", imgRemovedynamicfilters3_Jsonclick, true);
         edtavTfestadoproyectoid_Visible = 0;
         AssignProp("", false, edtavTfestadoproyectoid_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavTfestadoproyectoid_Visible), 5, 0), true);
         edtavTfestadoproyectoid_to_Visible = 0;
         AssignProp("", false, edtavTfestadoproyectoid_to_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavTfestadoproyectoid_to_Visible), 5, 0), true);
         edtavTfestadoproyectonombre_Visible = 0;
         AssignProp("", false, edtavTfestadoproyectonombre_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavTfestadoproyectonombre_Visible), 5, 0), true);
         edtavTfestadoproyectonombre_sel_Visible = 0;
         AssignProp("", false, edtavTfestadoproyectonombre_sel_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavTfestadoproyectonombre_sel_Visible), 5, 0), true);
         Ddo_estadoproyectoid_Titlecontrolidtoreplace = subGrid_Internalname+"_EstadoProyectoID";
         ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "TitleControlIdToReplace", Ddo_estadoproyectoid_Titlecontrolidtoreplace);
         AV60ddo_EstadoProyectoIDTitleControlIdToReplace = Ddo_estadoproyectoid_Titlecontrolidtoreplace;
         AssignAttri("", false, "AV60ddo_EstadoProyectoIDTitleControlIdToReplace", AV60ddo_EstadoProyectoIDTitleControlIdToReplace);
         edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Visible = 0;
         AssignProp("", false, edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Visible), 5, 0), true);
         Ddo_estadoproyectonombre_Titlecontrolidtoreplace = subGrid_Internalname+"_EstadoProyectoNombre";
         ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "TitleControlIdToReplace", Ddo_estadoproyectonombre_Titlecontrolidtoreplace);
         AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = Ddo_estadoproyectonombre_Titlecontrolidtoreplace;
         AssignAttri("", false, "AV64ddo_EstadoProyectoNombreTitleControlIdToReplace", AV64ddo_EstadoProyectoNombreTitleControlIdToReplace);
         edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Visible = 0;
         AssignProp("", false, edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Visible), 5, 0), true);
         Form.Caption = context.GetMessage( " Estado Proyecto", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         AssignProp("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavOrderedby_Visible), 5, 0), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         AssignProp("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavOrdereddsc_Visible), 5, 0), true);
         Ddo_managefilters_Icon = context.convertURL( (String)(context.GetImagePath( "5efb9e2b-46db-43f4-8f74-dd3f5818d30e", "", context.GetTheme( ))));
         ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "Icon", Ddo_managefilters_Icon);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV65DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV65DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrimStr( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0));
      }

      protected void E291F2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV57EstadoProyectoIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV61EstadoProyectoNombreTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         if ( AV51ManageFiltersExecutionStep == 1 )
         {
            AV51ManageFiltersExecutionStep = 2;
            AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
         }
         else if ( AV51ManageFiltersExecutionStep == 2 )
         {
            AV51ManageFiltersExecutionStep = 0;
            AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
            /* Execute user subroutine: 'LOADSAVEDFILTERS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV50Session.Get("EstadoProyectoWWColumnsSelector"), "") != 0 )
         {
            AV31ColumnsSelectorXML = AV50Session.Get("EstadoProyectoWWColumnsSelector");
            AV43ColumnsSelector.FromXml(AV31ColumnsSelectorXML, null, "WWPColumnsSelector", "IS2");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtEstadoProyectoID_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV43ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         AssignProp("", false, edtEstadoProyectoID_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoID_Visible), 5, 0), !bGXsfl_118_Refreshing);
         edtEstadoProyectoNombre_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV43ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         AssignProp("", false, edtEstadoProyectoNombre_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoNombre_Visible), 5, 0), !bGXsfl_118_Refreshing);
         edtEstadoProyectoID_Titleformat = 2;
         edtEstadoProyectoID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer'><span>%1</span><div id='%2'></div>", context.GetMessage( "Proyecto ID", ""), AV60ddo_EstadoProyectoIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         AssignProp("", false, edtEstadoProyectoID_Internalname, "Title", edtEstadoProyectoID_Title, !bGXsfl_118_Refreshing);
         edtEstadoProyectoNombre_Titleformat = 2;
         edtEstadoProyectoNombre_Title = StringUtil.Format( "<div class='ColumnSettingsContainer'><span>%1</span><div id='%2'></div>", context.GetMessage( "Proyecto Nombre", ""), AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, "", "", "", "", "", "", "");
         AssignProp("", false, edtEstadoProyectoNombre_Internalname, "Title", edtEstadoProyectoNombre_Title, !bGXsfl_118_Refreshing);
         AV67GridCurrentPage = subGrid_fnc_Currentpage( );
         AssignAttri("", false, "AV67GridCurrentPage", StringUtil.LTrimStr( (decimal)(AV67GridCurrentPage), 10, 0));
         AV68GridPageCount = subGrid_fnc_Pagecount( );
         AssignAttri("", false, "AV68GridPageCount", StringUtil.LTrimStr( (decimal)(AV68GridPageCount), 10, 0));
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV18EstadoProyectoNombre1;
         AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV22EstadoProyectoNombre2;
         AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV26EstadoProyectoNombre3;
         AV84EstadoProyectoWWDS_12_Tfestadoproyectoid = AV58TFEstadoProyectoID;
         AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV59TFEstadoProyectoID_To;
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV62TFEstadoProyectoNombre;
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV63TFEstadoProyectoNombre_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E121F2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            subgrid_nextpage( ) ;
         }
         else
         {
            AV66PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV66PageToGo) ;
         }
      }

      protected void E131F2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E141F2( )
      {
         /* Ddo_estadoproyectoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_estadoproyectoid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            AV14OrderedDsc = false;
            AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_estadoproyectoid_Sortedstatus = "ASC";
            ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "SortedStatus", Ddo_estadoproyectoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_estadoproyectoid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            AV14OrderedDsc = true;
            AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_estadoproyectoid_Sortedstatus = "DSC";
            ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "SortedStatus", Ddo_estadoproyectoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_estadoproyectoid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV58TFEstadoProyectoID = (short)(NumberUtil.Val( Ddo_estadoproyectoid_Filteredtext_get, "."));
            AssignAttri("", false, "AV58TFEstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV58TFEstadoProyectoID), 4, 0));
            AV59TFEstadoProyectoID_To = (short)(NumberUtil.Val( Ddo_estadoproyectoid_Filteredtextto_get, "."));
            AssignAttri("", false, "AV59TFEstadoProyectoID_To", StringUtil.LTrimStr( (decimal)(AV59TFEstadoProyectoID_To), 4, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E151F2( )
      {
         /* Ddo_estadoproyectonombre_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_estadoproyectonombre_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            AV14OrderedDsc = false;
            AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_estadoproyectonombre_Sortedstatus = "ASC";
            ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SortedStatus", Ddo_estadoproyectonombre_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_estadoproyectonombre_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
            AV14OrderedDsc = true;
            AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_estadoproyectonombre_Sortedstatus = "DSC";
            ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SortedStatus", Ddo_estadoproyectonombre_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_estadoproyectonombre_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV62TFEstadoProyectoNombre = Ddo_estadoproyectonombre_Filteredtext_get;
            AssignAttri("", false, "AV62TFEstadoProyectoNombre", AV62TFEstadoProyectoNombre);
            AV63TFEstadoProyectoNombre_Sel = Ddo_estadoproyectonombre_Selectedvalue_get;
            AssignAttri("", false, "AV63TFEstadoProyectoNombre_Sel", AV63TFEstadoProyectoNombre_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      private void E301F2( )
      {
         /* Grid_Load Routine */
         AV69Update = "<i class=\"fa fa-pen\"></i>";
         AssignAttri("", false, edtavUpdate_Internalname, AV69Update);
         edtavUpdate_Link = formatLink("estadoproyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A7EstadoProyectoID);
         AV70Delete = "<i class=\"fa fa-times\"></i>";
         AssignAttri("", false, edtavDelete_Internalname, AV70Delete);
         edtavDelete_Link = formatLink("estadoproyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A7EstadoProyectoID);
         edtEstadoProyectoNombre_Link = formatLink("estadoproyectoview.aspx") + "?" + UrlEncode("" +A7EstadoProyectoID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 118;
         }
         sendrow_1182( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_118_Refreshing )
         {
            context.DoAjaxLoad(118, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E161F2( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV31ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV43ColumnsSelector.FromJSonString(AV31ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "EstadoProyectoWWColumnsSelector",  AV43ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "IS2")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E231F2( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV19DynamicFiltersEnabled2 = true;
         AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         AssignProp("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters1_Visible), 5, 0), true);
         imgRemovedynamicfilters1_Visible = 1;
         AssignProp("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0), true);
         /*  Sending Event outputs  */
      }

      protected void E171F2( )
      {
         /* 'RemoveDynamicFilters1' Routine */
         AV27DynamicFiltersRemoving = true;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = true;
         AssignAttri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = false;
         AssignAttri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
      }

      protected void E241F2( )
      {
         /* Dynamicfiltersselector1_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E251F2( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV23DynamicFiltersEnabled3 = true;
         AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         AssignProp("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters2_Visible), 5, 0), true);
         imgRemovedynamicfilters2_Visible = 1;
         AssignProp("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0), true);
         /*  Sending Event outputs  */
      }

      protected void E181F2( )
      {
         /* 'RemoveDynamicFilters2' Routine */
         AV27DynamicFiltersRemoving = true;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV19DynamicFiltersEnabled2 = false;
         AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
      }

      protected void E261F2( )
      {
         /* Dynamicfiltersselector2_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E191F2( )
      {
         /* 'RemoveDynamicFilters3' Routine */
         AV27DynamicFiltersRemoving = true;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV23DynamicFiltersEnabled3 = false;
         AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         AssignAttri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18EstadoProyectoNombre1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22EstadoProyectoNombre2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26EstadoProyectoNombre3, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV58TFEstadoProyectoID, AV59TFEstadoProyectoID_To, AV62TFEstadoProyectoNombre, AV63TFEstadoProyectoNombre_Sel, AV51ManageFiltersExecutionStep, AV43ColumnsSelector, AV60ddo_EstadoProyectoIDTitleControlIdToReplace, AV64ddo_EstadoProyectoNombreTitleControlIdToReplace, AV88Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
      }

      protected void E271F2( )
      {
         /* Dynamicfiltersselector3_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E111F2( )
      {
         /* Ddo_managefilters_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Clean#>") == 0 )
         {
            /* Execute user subroutine: 'CLEANFILTERS' */
            S242 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Save#>") == 0 )
         {
            /* Execute user subroutine: 'SAVEGRIDSTATE' */
            S182 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("EstadoProyectoWWFilters")) + "," + UrlEncode(StringUtil.RTrim(AV88Pgmname+"GridState")), new Object[] {});
            AV51ManageFiltersExecutionStep = 2;
            AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("EstadoProyectoWWFilters")), new Object[] {});
            AV51ManageFiltersExecutionStep = 2;
            AssignAttri("", false, "AV51ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV51ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV52ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "EstadoProyectoWWFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
            ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "ActiveEventKey", Ddo_managefilters_Activeeventkey);
            AV52ManageFiltersXml = GXt_char2;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52ManageFiltersXml)) )
            {
               GX_msglist.addItem(context.GetMessage( "WWP_FilterNotExist", ""));
            }
            else
            {
               /* Execute user subroutine: 'CLEANFILTERS' */
               S242 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV88Pgmname+"GridState",  AV52ManageFiltersXml) ;
               AV10GridState.FromXml(AV52ManageFiltersXml, null, "WWPGridState", "IS2");
               AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
               AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
               AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
               AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
               /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
               S172 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
               S252 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
               S232 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               subgrid_firstpage( ) ;
               context.DoAjaxRefresh();
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57EstadoProyectoIDTitleFilterData", AV57EstadoProyectoIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61EstadoProyectoNombreTitleFilterData", AV61EstadoProyectoNombreTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43ColumnsSelector", AV43ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ManageFiltersData", AV55ManageFiltersData);
      }

      protected void E201F2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("estadoproyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void E211F2( )
      {
         /* 'DoExport' Routine */
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         new estadoproyectowwexport(context ).execute( out  AV29ExcelFilename, out  AV30ErrorMessage) ;
         if ( StringUtil.StrCmp(AV29ExcelFilename, "") != 0 )
         {
            CallWebObject(formatLink(AV29ExcelFilename) );
            context.wjLocDisableFrm = 0;
         }
         else
         {
            GX_msglist.addItem(AV30ErrorMessage);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E221F2( )
      {
         /* 'DoExportReport' Routine */
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         Innewwindow1_Target = formatLink("estadoproyectowwexportreport.aspx") ;
         ucInnewwindow1.SendProperty(context, "", false, Innewwindow1_Internalname, "Target", Innewwindow1_Target);
         Innewwindow1_Height = "600";
         ucInnewwindow1.SendProperty(context, "", false, Innewwindow1_Internalname, "Height", Innewwindow1_Height);
         Innewwindow1_Width = "800";
         ucInnewwindow1.SendProperty(context, "", false, Innewwindow1_Internalname, "Width", Innewwindow1_Width);
         this.executeUsercontrolMethod("", false, "INNEWWINDOW1Container", "OpenWindow", "", new Object[] {});
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void S202( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_estadoproyectoid_Sortedstatus = "";
         ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "SortedStatus", Ddo_estadoproyectoid_Sortedstatus);
         Ddo_estadoproyectonombre_Sortedstatus = "";
         ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SortedStatus", Ddo_estadoproyectonombre_Sortedstatus);
      }

      protected void S172( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S202 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 2 )
         {
            Ddo_estadoproyectoid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "SortedStatus", Ddo_estadoproyectoid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 1 )
         {
            Ddo_estadoproyectonombre_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SortedStatus", Ddo_estadoproyectonombre_Sortedstatus);
         }
      }

      protected void S192( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV43ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV43ColumnsSelector,  "Proyecto ID",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV43ColumnsSelector,  "Proyecto Nombre",  true) ;
         GXt_char2 = AV38UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "EstadoProyectoWWColumnsSelector", out  GXt_char2) ;
         AV38UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV38UserCustomValue)) ) )
         {
            AV44ColumnsSelectorAux.FromXml(AV38UserCustomValue, null, "WWPColumnsSelector", "IS2");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV44ColumnsSelectorAux, ref  AV43ColumnsSelector) ;
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         edtavEstadoproyectonombre1_Visible = 0;
         AssignProp("", false, edtavEstadoproyectonombre1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre1_Visible), 5, 0), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0), true);
         if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 )
         {
            edtavEstadoproyectonombre1_Visible = 1;
            AssignProp("", false, edtavEstadoproyectonombre1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre1_Visible), 5, 0), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0), true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         edtavEstadoproyectonombre2_Visible = 0;
         AssignProp("", false, edtavEstadoproyectonombre2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre2_Visible), 5, 0), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0), true);
         if ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 )
         {
            edtavEstadoproyectonombre2_Visible = 1;
            AssignProp("", false, edtavEstadoproyectonombre2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre2_Visible), 5, 0), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0), true);
         }
      }

      protected void S142( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         edtavEstadoproyectonombre3_Visible = 0;
         AssignProp("", false, edtavEstadoproyectonombre3_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre3_Visible), 5, 0), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0), true);
         if ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 )
         {
            edtavEstadoproyectonombre3_Visible = 1;
            AssignProp("", false, edtavEstadoproyectonombre3_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtavEstadoproyectonombre3_Visible), 5, 0), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0), true);
         }
      }

      protected void S222( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV19DynamicFiltersEnabled2 = false;
         AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         AV20DynamicFiltersSelector2 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         AV21DynamicFiltersOperator2 = 0;
         AssignAttri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrimStr( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         AV22EstadoProyectoNombre2 = "";
         AssignAttri("", false, "AV22EstadoProyectoNombre2", AV22EstadoProyectoNombre2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV23DynamicFiltersEnabled3 = false;
         AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         AV24DynamicFiltersSelector3 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         AV25DynamicFiltersOperator3 = 0;
         AssignAttri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrimStr( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         AV26EstadoProyectoNombre3 = "";
         AssignAttri("", false, "AV26EstadoProyectoNombre3", AV26EstadoProyectoNombre3);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S112( )
      {
         /* 'LOADSAVEDFILTERS' Routine */
         AV55ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV56ManageFiltersDataItem.gxTpr_Title = context.GetMessage( "WWP_CleanFiltersCaption", "");
         AV56ManageFiltersDataItem.gxTpr_Eventkey = "<#Clean#>";
         AV56ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV56ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "63d2ae92-4e43-4a70-af61-0943e39ea422", "", context.GetTheme( ))));
         AV56ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
         AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV56ManageFiltersDataItem.gxTpr_Title = context.GetMessage( "WWP_SaveFilterAsOption", "");
         AV56ManageFiltersDataItem.gxTpr_Eventkey = "<#Save#>";
         AV56ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV56ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "6eee63e8-73c7-4738-beee-f98e3a8d2841", "", context.GetTheme( ))));
         AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
         AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV56ManageFiltersDataItem.gxTpr_Isdivider = true;
         AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
         AV53ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "EstadoProyectoWWFilters"), null, "Items", "");
         AV89GXV1 = 1;
         while ( AV89GXV1 <= AV53ManageFiltersItems.Count )
         {
            AV54ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV53ManageFiltersItems.Item(AV89GXV1));
            AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV56ManageFiltersDataItem.gxTpr_Title = AV54ManageFiltersItem.gxTpr_Title;
            AV56ManageFiltersDataItem.gxTpr_Eventkey = AV54ManageFiltersItem.gxTpr_Title;
            AV56ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV56ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
            AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
            if ( AV55ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV89GXV1 = (int)(AV89GXV1+1);
         }
         if ( AV55ManageFiltersData.Count > 3 )
         {
            AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV56ManageFiltersDataItem.gxTpr_Isdivider = true;
            AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
            AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV56ManageFiltersDataItem.gxTpr_Title = context.GetMessage( "WWP_ManageFiltersOption", "");
            AV56ManageFiltersDataItem.gxTpr_Eventkey = "<#Manage#>";
            AV56ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV56ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "653f6166-5d82-407a-af84-19e0dde65efd", "", context.GetTheme( ))));
            AV56ManageFiltersDataItem.gxTpr_Jsonclickevent = "";
            AV55ManageFiltersData.Add(AV56ManageFiltersDataItem, 0);
         }
      }

      protected void S242( )
      {
         /* 'CLEANFILTERS' Routine */
         AV58TFEstadoProyectoID = 0;
         AssignAttri("", false, "AV58TFEstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV58TFEstadoProyectoID), 4, 0));
         Ddo_estadoproyectoid_Filteredtext_set = "";
         ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "FilteredText_set", Ddo_estadoproyectoid_Filteredtext_set);
         AV59TFEstadoProyectoID_To = 0;
         AssignAttri("", false, "AV59TFEstadoProyectoID_To", StringUtil.LTrimStr( (decimal)(AV59TFEstadoProyectoID_To), 4, 0));
         Ddo_estadoproyectoid_Filteredtextto_set = "";
         ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "FilteredTextTo_set", Ddo_estadoproyectoid_Filteredtextto_set);
         AV62TFEstadoProyectoNombre = "";
         AssignAttri("", false, "AV62TFEstadoProyectoNombre", AV62TFEstadoProyectoNombre);
         Ddo_estadoproyectonombre_Filteredtext_set = "";
         ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "FilteredText_set", Ddo_estadoproyectonombre_Filteredtext_set);
         AV63TFEstadoProyectoNombre_Sel = "";
         AssignAttri("", false, "AV63TFEstadoProyectoNombre_Sel", AV63TFEstadoProyectoNombre_Sel);
         Ddo_estadoproyectonombre_Selectedvalue_set = "";
         ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SelectedValue_set", Ddo_estadoproyectonombre_Selectedvalue_set);
         AV16DynamicFiltersSelector1 = "ESTADOPROYECTONOMBRE";
         AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         AV17DynamicFiltersOperator1 = 0;
         AssignAttri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrimStr( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         AV18EstadoProyectoNombre1 = "";
         AssignAttri("", false, "AV18EstadoProyectoNombre1", AV18EstadoProyectoNombre1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV10GridState.gxTpr_Dynamicfilters.Clear();
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S162( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV50Session.Get(AV88Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV88Pgmname+"GridState"), null, "WWPGridState", "IS2");
         }
         else
         {
            AV10GridState.FromXml(AV50Session.Get(AV88Pgmname+"GridState"), null, "WWPGridState", "IS2");
         }
         AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
         AssignAttri("", false, "AV13OrderedBy", StringUtil.LTrimStr( (decimal)(AV13OrderedBy), 4, 0));
         AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
         AssignAttri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
         S252 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV10GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV10GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV10GridState.gxTpr_Currentpage) ;
      }

      protected void S252( )
      {
         /* 'LOADREGFILTERSSTATE' Routine */
         AV90GXV2 = 1;
         while ( AV90GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV90GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTOID") == 0 )
            {
               AV58TFEstadoProyectoID = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               AssignAttri("", false, "AV58TFEstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV58TFEstadoProyectoID), 4, 0));
               AV59TFEstadoProyectoID_To = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, "."));
               AssignAttri("", false, "AV59TFEstadoProyectoID_To", StringUtil.LTrimStr( (decimal)(AV59TFEstadoProyectoID_To), 4, 0));
               if ( ! (0==AV58TFEstadoProyectoID) )
               {
                  Ddo_estadoproyectoid_Filteredtext_set = StringUtil.Str( (decimal)(AV58TFEstadoProyectoID), 4, 0);
                  ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "FilteredText_set", Ddo_estadoproyectoid_Filteredtext_set);
               }
               if ( ! (0==AV59TFEstadoProyectoID_To) )
               {
                  Ddo_estadoproyectoid_Filteredtextto_set = StringUtil.Str( (decimal)(AV59TFEstadoProyectoID_To), 4, 0);
                  ucDdo_estadoproyectoid.SendProperty(context, "", false, Ddo_estadoproyectoid_Internalname, "FilteredTextTo_set", Ddo_estadoproyectoid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE") == 0 )
            {
               AV62TFEstadoProyectoNombre = AV11GridStateFilterValue.gxTpr_Value;
               AssignAttri("", false, "AV62TFEstadoProyectoNombre", AV62TFEstadoProyectoNombre);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62TFEstadoProyectoNombre)) )
               {
                  Ddo_estadoproyectonombre_Filteredtext_set = AV62TFEstadoProyectoNombre;
                  ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "FilteredText_set", Ddo_estadoproyectonombre_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE_SEL") == 0 )
            {
               AV63TFEstadoProyectoNombre_Sel = AV11GridStateFilterValue.gxTpr_Value;
               AssignAttri("", false, "AV63TFEstadoProyectoNombre_Sel", AV63TFEstadoProyectoNombre_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63TFEstadoProyectoNombre_Sel)) )
               {
                  Ddo_estadoproyectonombre_Selectedvalue_set = AV63TFEstadoProyectoNombre_Sel;
                  ucDdo_estadoproyectonombre.SendProperty(context, "", false, Ddo_estadoproyectonombre_Internalname, "SelectedValue_set", Ddo_estadoproyectonombre_Selectedvalue_set);
               }
            }
            AV90GXV2 = (int)(AV90GXV2+1);
         }
      }

      protected void S232( )
      {
         /* 'LOADDYNFILTERSSTATE' Routine */
         imgAdddynamicfilters1_Visible = 1;
         AssignProp("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters1_Visible), 5, 0), true);
         imgRemovedynamicfilters1_Visible = 0;
         AssignProp("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0), true);
         imgAdddynamicfilters2_Visible = 1;
         AssignProp("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters2_Visible), 5, 0), true);
         imgRemovedynamicfilters2_Visible = 0;
         AssignProp("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0), true);
         if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(1));
            AV16DynamicFiltersSelector1 = AV12GridStateDynamicFilter.gxTpr_Selected;
            AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
            if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 )
            {
               AV17DynamicFiltersOperator1 = AV12GridStateDynamicFilter.gxTpr_Operator;
               AssignAttri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrimStr( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
               AV18EstadoProyectoNombre1 = AV12GridStateDynamicFilter.gxTpr_Value;
               AssignAttri("", false, "AV18EstadoProyectoNombre1", AV18EstadoProyectoNombre1);
            }
            /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               lblJsdynamicfilters_Caption = "<script type=\"text/javascript\">";
               AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 2, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
               AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               imgAdddynamicfilters1_Visible = 0;
               AssignProp("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters1_Visible), 5, 0), true);
               imgRemovedynamicfilters1_Visible = 1;
               AssignProp("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0), true);
               AV19DynamicFiltersEnabled2 = true;
               AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
               AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(2));
               AV20DynamicFiltersSelector2 = AV12GridStateDynamicFilter.gxTpr_Selected;
               AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
               if ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 )
               {
                  AV21DynamicFiltersOperator2 = AV12GridStateDynamicFilter.gxTpr_Operator;
                  AssignAttri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrimStr( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
                  AV22EstadoProyectoNombre2 = AV12GridStateDynamicFilter.gxTpr_Value;
                  AssignAttri("", false, "AV22EstadoProyectoNombre2", AV22EstadoProyectoNombre2);
               }
               /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
               S132 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 3, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
                  AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
                  imgAdddynamicfilters2_Visible = 0;
                  AssignProp("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgAdddynamicfilters2_Visible), 5, 0), true);
                  imgRemovedynamicfilters2_Visible = 1;
                  AssignProp("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0), true);
                  AV23DynamicFiltersEnabled3 = true;
                  AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
                  AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(3));
                  AV24DynamicFiltersSelector3 = AV12GridStateDynamicFilter.gxTpr_Selected;
                  AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
                  if ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 )
                  {
                     AV25DynamicFiltersOperator3 = AV12GridStateDynamicFilter.gxTpr_Operator;
                     AssignAttri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrimStr( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
                     AV26EstadoProyectoNombre3 = AV12GridStateDynamicFilter.gxTpr_Value;
                     AssignAttri("", false, "AV26EstadoProyectoNombre3", AV26EstadoProyectoNombre3);
                  }
                  /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
                  S142 ();
                  if ( returnInSub )
                  {
                     returnInSub = true;
                     if (true) return;
                  }
               }
               lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+"</script>";
               AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
            }
         }
         if ( AV27DynamicFiltersRemoving )
         {
            lblJsdynamicfilters_Caption = "";
            AssignProp("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         }
      }

      protected void S182( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV50Session.Get(AV88Pgmname+"GridState"), null, "WWPGridState", "IS2");
         AV10GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV58TFEstadoProyectoID) && (0==AV59TFEstadoProyectoID_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFESTADOPROYECTOID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV58TFEstadoProyectoID), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV59TFEstadoProyectoID_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62TFEstadoProyectoNombre)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFESTADOPROYECTONOMBRE";
            AV11GridStateFilterValue.gxTpr_Value = AV62TFEstadoProyectoNombre;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63TFEstadoProyectoNombre_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFESTADOPROYECTONOMBRE_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV63TFEstadoProyectoNombre_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV10GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV10GridState.gxTpr_Currentpage = (short)(subGrid_fnc_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV88Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "IS2")) ;
      }

      protected void S212( )
      {
         /* 'SAVEDYNFILTERSSTATE' Routine */
         AV10GridState.gxTpr_Dynamicfilters.Clear();
         if ( ! AV28DynamicFiltersIgnoreFirst )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV16DynamicFiltersSelector1;
            if ( ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18EstadoProyectoNombre1)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV18EstadoProyectoNombre1;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV17DynamicFiltersOperator1;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV19DynamicFiltersEnabled2 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV20DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV22EstadoProyectoNombre2)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV22EstadoProyectoNombre2;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV21DynamicFiltersOperator2;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV23DynamicFiltersEnabled3 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV24DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV26EstadoProyectoNombre3)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV26EstadoProyectoNombre3;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV25DynamicFiltersOperator3;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
      }

      protected void S152( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV88Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "EstadoProyecto";
         AV50Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "IS2"));
      }

      protected void wb_table1_30_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablerightheader_Internalname, tblTablerightheader_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellAlignTopPaddingTop2'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_managefilters_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_managefilters.SetProperty("Caption", Ddo_managefilters_Caption);
            ucDdo_managefilters.SetProperty("Tooltip", Ddo_managefilters_Tooltip);
            ucDdo_managefilters.SetProperty("Cls", Ddo_managefilters_Cls);
            ucDdo_managefilters.SetProperty("DropDownOptionsData", AV55ManageFiltersData);
            ucDdo_managefilters.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_managefilters_Internalname, "DDO_MANAGEFILTERSContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_36_1F2( true) ;
         }
         else
         {
            wb_table2_36_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_36_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_30_1F2e( true) ;
         }
         else
         {
            wb_table1_30_1F2e( false) ;
         }
      }

      protected void wb_table2_36_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_39_1F2( true) ;
         }
         else
         {
            wb_table3_39_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_39_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_36_1F2e( true) ;
         }
         else
         {
            wb_table2_36_1F2e( false) ;
         }
      }

      protected void wb_table3_39_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, context.GetMessage( "WWP_DynFilterPrefix", ""), "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, context.GetMessage( "Dynamic Filters Selector1", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV16DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,45);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
            AssignProp("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, context.GetMessage( "WWP_DynFilterMiddle", ""), "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_49_1F2( true) ;
         }
         else
         {
            wb_table4_49_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table4_49_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_58_1F2( true) ;
         }
         else
         {
            wb_table5_58_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table5_58_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, context.GetMessage( "WWP_DynFilterPrefix", ""), "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, context.GetMessage( "Dynamic Filters Selector2", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV20DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,69);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
            AssignProp("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, context.GetMessage( "WWP_DynFilterMiddle", ""), "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_73_1F2( true) ;
         }
         else
         {
            wb_table6_73_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table6_73_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_82_1F2( true) ;
         }
         else
         {
            wb_table7_82_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table7_82_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, context.GetMessage( "WWP_DynFilterPrefix", ""), "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, context.GetMessage( "Dynamic Filters Selector3", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV24DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,93);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
            AssignProp("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, context.GetMessage( "WWP_DynFilterMiddle", ""), "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_97_1F2( true) ;
         }
         else
         {
            wb_table8_97_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table8_97_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table9_106_1F2( true) ;
         }
         else
         {
            wb_table9_106_1F2( false) ;
         }
         return  ;
      }

      protected void wb_table9_106_1F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_39_1F2e( true) ;
         }
         else
         {
            wb_table3_39_1F2e( false) ;
         }
      }

      protected void wb_table9_106_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", context.GetMessage( "WWP_DynFilterRemoveTooltip", ""), 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_106_1F2e( true) ;
         }
         else
         {
            wb_table9_106_1F2e( false) ;
         }
      }

      protected void wb_table8_97_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters3_Internalname, tblTablemergeddynamicfilters3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator3_Internalname, context.GetMessage( "Dynamic Filters Operator3", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,101);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_estadoproyectonombre3_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEstadoproyectonombre3_Internalname, context.GetMessage( "Estado Proyecto Nombre3", ""), "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEstadoproyectonombre3_Internalname, StringUtil.RTrim( AV26EstadoProyectoNombre3), StringUtil.RTrim( context.localUtil.Format( AV26EstadoProyectoNombre3, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEstadoproyectonombre3_Jsonclick, 0, "Attribute", "", "", "", "", edtavEstadoproyectonombre3_Visible, edtavEstadoproyectonombre3_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_97_1F2e( true) ;
         }
         else
         {
            wb_table8_97_1F2e( false) ;
         }
      }

      protected void wb_table7_82_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", context.GetMessage( "WWP_DynFilterAddTooltip", ""), 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", context.GetMessage( "WWP_DynFilterRemoveTooltip", ""), 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_82_1F2e( true) ;
         }
         else
         {
            wb_table7_82_1F2e( false) ;
         }
      }

      protected void wb_table6_73_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters2_Internalname, tblTablemergeddynamicfilters2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator2_Internalname, context.GetMessage( "Dynamic Filters Operator2", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,77);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_estadoproyectonombre2_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEstadoproyectonombre2_Internalname, context.GetMessage( "Estado Proyecto Nombre2", ""), "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEstadoproyectonombre2_Internalname, StringUtil.RTrim( AV22EstadoProyectoNombre2), StringUtil.RTrim( context.localUtil.Format( AV22EstadoProyectoNombre2, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEstadoproyectonombre2_Jsonclick, 0, "Attribute", "", "", "", "", edtavEstadoproyectonombre2_Visible, edtavEstadoproyectonombre2_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_73_1F2e( true) ;
         }
         else
         {
            wb_table6_73_1F2e( false) ;
         }
      }

      protected void wb_table5_58_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", context.GetMessage( "WWP_DynFilterAddTooltip", ""), 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", context.GetMessage( "WWP_DynFilterRemoveTooltip", ""), 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_EstadoProyectoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_58_1F2e( true) ;
         }
         else
         {
            wb_table5_58_1F2e( false) ;
         }
      }

      protected void wb_table4_49_1F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters1_Internalname, tblTablemergeddynamicfilters1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator1_Internalname, context.GetMessage( "Dynamic Filters Operator1", ""), "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_118_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", "", true, "HLP_EstadoProyectoWW.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            AssignProp("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_estadoproyectonombre1_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEstadoproyectonombre1_Internalname, context.GetMessage( "Estado Proyecto Nombre1", ""), "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_118_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEstadoproyectonombre1_Internalname, StringUtil.RTrim( AV18EstadoProyectoNombre1), StringUtil.RTrim( context.localUtil.Format( AV18EstadoProyectoNombre1, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEstadoproyectonombre1_Jsonclick, 0, "Attribute", "", "", "", "", edtavEstadoproyectonombre1_Visible, edtavEstadoproyectonombre1_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_EstadoProyectoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_49_1F2e( true) ;
         }
         else
         {
            wb_table4_49_1F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA1F2( ) ;
         WS1F2( ) ;
         WE1F2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome_v5/css/font-awesome.min.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020825180331", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("estadoproyectoww.js", "?2020825180332", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("Window/InNewWindowRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1182( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_118_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_118_idx;
         edtEstadoProyectoID_Internalname = "ESTADOPROYECTOID_"+sGXsfl_118_idx;
         edtEstadoProyectoNombre_Internalname = "ESTADOPROYECTONOMBRE_"+sGXsfl_118_idx;
      }

      protected void SubsflControlProps_fel_1182( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_118_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_118_fel_idx;
         edtEstadoProyectoID_Internalname = "ESTADOPROYECTOID_"+sGXsfl_118_fel_idx;
         edtEstadoProyectoNombre_Internalname = "ESTADOPROYECTONOMBRE_"+sGXsfl_118_fel_idx;
      }

      protected void sendrow_1182( )
      {
         SubsflControlProps_1182( ) ;
         WB1F0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_118_idx <= subGrid_fnc_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)((nGXsfl_118_idx) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridNoBorder WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_118_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV69Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",context.GetMessage( "GXM_update", ""),(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)118,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV70Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",context.GetMessage( "GX_BtnDelete", ""),(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)118,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtEstadoProyectoID_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEstadoProyectoID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEstadoProyectoID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtEstadoProyectoID_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)118,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtEstadoProyectoNombre_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEstadoProyectoNombre_Internalname,StringUtil.RTrim( A34EstadoProyectoNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtEstadoProyectoNombre_Link,(String)"",(String)"",(String)"",(String)edtEstadoProyectoNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtEstadoProyectoNombre_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)118,(short)1,(short)-1,(short)-1,(bool)true,(String)"Name",(String)"left",(bool)true,(String)""});
            send_integrity_lvl_hashes1F2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_118_idx = ((subGrid_Islastpage==1)&&(nGXsfl_118_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_118_idx+1);
            sGXsfl_118_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_118_idx), 4, 0), 4, "0");
            SubsflControlProps_1182( ) ;
         }
         /* End function sendrow_1182 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("ESTADOPROYECTONOMBRE", context.GetMessage( "Proyecto Nombre", ""), 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV16DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV16DynamicFiltersSelector1);
            AssignAttri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", context.GetMessage( "WWP_FilterLike", ""), 0);
         cmbavDynamicfiltersoperator1.addItem("1", context.GetMessage( "WWP_FilterContains", ""), 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0))), "."));
            AssignAttri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrimStr( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("ESTADOPROYECTONOMBRE", context.GetMessage( "Proyecto Nombre", ""), 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV20DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV20DynamicFiltersSelector2);
            AssignAttri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", context.GetMessage( "WWP_FilterLike", ""), 0);
         cmbavDynamicfiltersoperator2.addItem("1", context.GetMessage( "WWP_FilterContains", ""), 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0))), "."));
            AssignAttri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrimStr( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("ESTADOPROYECTONOMBRE", context.GetMessage( "Proyecto Nombre", ""), 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV24DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV24DynamicFiltersSelector3);
            AssignAttri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", context.GetMessage( "WWP_FilterLike", ""), 0);
         cmbavDynamicfiltersoperator3.addItem("1", context.GetMessage( "WWP_FilterContains", ""), 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0))), "."));
            AssignAttri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrimStr( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         }
         chkavDynamicfiltersenabled2.Name = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled2.WebTags = "";
         chkavDynamicfiltersenabled2.Caption = "";
         AssignProp("", false, chkavDynamicfiltersenabled2_Internalname, "TitleCaption", chkavDynamicfiltersenabled2.Caption, true);
         chkavDynamicfiltersenabled2.CheckedValue = "false";
         AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( StringUtil.BoolToStr( AV19DynamicFiltersEnabled2));
         AssignAttri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         chkavDynamicfiltersenabled3.Name = "vDYNAMICFILTERSENABLED3";
         chkavDynamicfiltersenabled3.WebTags = "";
         chkavDynamicfiltersenabled3.Caption = "";
         AssignProp("", false, chkavDynamicfiltersenabled3_Internalname, "TitleCaption", chkavDynamicfiltersenabled3.Caption, true);
         chkavDynamicfiltersenabled3.CheckedValue = "false";
         AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( StringUtil.BoolToStr( AV23DynamicFiltersEnabled3));
         AssignAttri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtnexport_Internalname = "BTNEXPORT";
         bttBtnexportreport_Internalname = "BTNEXPORTREPORT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         Ddo_managefilters_Internalname = "DDO_MANAGEFILTERS";
         divHtml_managefilters_Internalname = "HTML_MANAGEFILTERS";
         lblDynamicfiltersprefix1_Internalname = "DYNAMICFILTERSPREFIX1";
         cmbavDynamicfiltersselector1_Internalname = "vDYNAMICFILTERSSELECTOR1";
         lblDynamicfiltersmiddle1_Internalname = "DYNAMICFILTERSMIDDLE1";
         cmbavDynamicfiltersoperator1_Internalname = "vDYNAMICFILTERSOPERATOR1";
         edtavEstadoproyectonombre1_Internalname = "vESTADOPROYECTONOMBRE1";
         cellFilter_estadoproyectonombre1_cell_Internalname = "FILTER_ESTADOPROYECTONOMBRE1_CELL";
         tblTablemergeddynamicfilters1_Internalname = "TABLEMERGEDDYNAMICFILTERS1";
         imgAdddynamicfilters1_Internalname = "ADDDYNAMICFILTERS1";
         cellDynamicfilters_addfilter1_cell_Internalname = "DYNAMICFILTERS_ADDFILTER1_CELL";
         imgRemovedynamicfilters1_Internalname = "REMOVEDYNAMICFILTERS1";
         cellDynamicfilters_removefilter1_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER1_CELL";
         tblUnnamedtabledynamicfilters_1_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_1";
         lblDynamicfiltersprefix2_Internalname = "DYNAMICFILTERSPREFIX2";
         cmbavDynamicfiltersselector2_Internalname = "vDYNAMICFILTERSSELECTOR2";
         lblDynamicfiltersmiddle2_Internalname = "DYNAMICFILTERSMIDDLE2";
         cmbavDynamicfiltersoperator2_Internalname = "vDYNAMICFILTERSOPERATOR2";
         edtavEstadoproyectonombre2_Internalname = "vESTADOPROYECTONOMBRE2";
         cellFilter_estadoproyectonombre2_cell_Internalname = "FILTER_ESTADOPROYECTONOMBRE2_CELL";
         tblTablemergeddynamicfilters2_Internalname = "TABLEMERGEDDYNAMICFILTERS2";
         imgAdddynamicfilters2_Internalname = "ADDDYNAMICFILTERS2";
         cellDynamicfilters_addfilter2_cell_Internalname = "DYNAMICFILTERS_ADDFILTER2_CELL";
         imgRemovedynamicfilters2_Internalname = "REMOVEDYNAMICFILTERS2";
         cellDynamicfilters_removefilter2_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER2_CELL";
         tblUnnamedtabledynamicfilters_2_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_2";
         lblDynamicfiltersprefix3_Internalname = "DYNAMICFILTERSPREFIX3";
         cmbavDynamicfiltersselector3_Internalname = "vDYNAMICFILTERSSELECTOR3";
         lblDynamicfiltersmiddle3_Internalname = "DYNAMICFILTERSMIDDLE3";
         cmbavDynamicfiltersoperator3_Internalname = "vDYNAMICFILTERSOPERATOR3";
         edtavEstadoproyectonombre3_Internalname = "vESTADOPROYECTONOMBRE3";
         cellFilter_estadoproyectonombre3_cell_Internalname = "FILTER_ESTADOPROYECTONOMBRE3_CELL";
         tblTablemergeddynamicfilters3_Internalname = "TABLEMERGEDDYNAMICFILTERS3";
         imgRemovedynamicfilters3_Internalname = "REMOVEDYNAMICFILTERS3";
         cellDynamicfilters_removefilter3_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER3_CELL";
         tblUnnamedtabledynamicfilters_3_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_3";
         tblTabledynamicfilters_Internalname = "TABLEDYNAMICFILTERS";
         tblTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtEstadoProyectoID_Internalname = "ESTADOPROYECTOID";
         edtEstadoProyectoNombre_Internalname = "ESTADOPROYECTONOMBRE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         lblJsdynamicfilters_Internalname = "JSDYNAMICFILTERS";
         Ddo_estadoproyectoid_Internalname = "DDO_ESTADOPROYECTOID";
         edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Internalname = "vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE";
         Ddo_estadoproyectonombre_Internalname = "DDO_ESTADOPROYECTONOMBRE";
         edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Internalname = "vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Innewwindow1_Internalname = "INNEWWINDOW1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         chkavDynamicfiltersenabled2_Internalname = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled3_Internalname = "vDYNAMICFILTERSENABLED3";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfestadoproyectoid_Internalname = "vTFESTADOPROYECTOID";
         edtavTfestadoproyectoid_to_Internalname = "vTFESTADOPROYECTOID_TO";
         edtavTfestadoproyectonombre_Internalname = "vTFESTADOPROYECTONOMBRE";
         edtavTfestadoproyectonombre_sel_Internalname = "vTFESTADOPROYECTONOMBRE_SEL";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkavDynamicfiltersenabled3.Caption = "";
         chkavDynamicfiltersenabled2.Caption = "";
         edtEstadoProyectoNombre_Jsonclick = "";
         edtEstadoProyectoID_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtavEstadoproyectonombre1_Jsonclick = "";
         edtavEstadoproyectonombre1_Enabled = 1;
         cmbavDynamicfiltersoperator1_Jsonclick = "";
         cmbavDynamicfiltersoperator1.Enabled = 1;
         imgRemovedynamicfilters1_Visible = 1;
         imgAdddynamicfilters1_Visible = 1;
         edtavEstadoproyectonombre2_Jsonclick = "";
         edtavEstadoproyectonombre2_Enabled = 1;
         cmbavDynamicfiltersoperator2_Jsonclick = "";
         cmbavDynamicfiltersoperator2.Enabled = 1;
         imgRemovedynamicfilters2_Visible = 1;
         imgAdddynamicfilters2_Visible = 1;
         edtavEstadoproyectonombre3_Jsonclick = "";
         edtavEstadoproyectonombre3_Enabled = 1;
         cmbavDynamicfiltersoperator3_Jsonclick = "";
         cmbavDynamicfiltersoperator3.Enabled = 1;
         cmbavDynamicfiltersselector3_Jsonclick = "";
         cmbavDynamicfiltersselector3.Enabled = 1;
         cmbavDynamicfiltersselector2_Jsonclick = "";
         cmbavDynamicfiltersselector2.Enabled = 1;
         cmbavDynamicfiltersselector1_Jsonclick = "";
         cmbavDynamicfiltersselector1.Enabled = 1;
         cmbavDynamicfiltersoperator3.Visible = 1;
         edtavEstadoproyectonombre3_Visible = 1;
         cmbavDynamicfiltersoperator2.Visible = 1;
         edtavEstadoproyectonombre2_Visible = 1;
         cmbavDynamicfiltersoperator1.Visible = 1;
         edtavEstadoproyectonombre1_Visible = 1;
         edtavTfestadoproyectonombre_sel_Jsonclick = "";
         edtavTfestadoproyectonombre_sel_Visible = 1;
         edtavTfestadoproyectonombre_Jsonclick = "";
         edtavTfestadoproyectonombre_Visible = 1;
         edtavTfestadoproyectoid_to_Jsonclick = "";
         edtavTfestadoproyectoid_to_Visible = 1;
         edtavTfestadoproyectoid_Jsonclick = "";
         edtavTfestadoproyectoid_Visible = 1;
         edtavManagefiltersexecutionstep_Jsonclick = "";
         edtavManagefiltersexecutionstep_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Visible = 1;
         edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = context.GetMessage( "JSDynamicFilters", "");
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtEstadoProyectoNombre_Link = "";
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtEstadoProyectoNombre_Titleformat = 0;
         edtEstadoProyectoNombre_Title = context.GetMessage( "Proyecto Nombre", "");
         edtEstadoProyectoNombre_Visible = -1;
         edtEstadoProyectoID_Titleformat = 0;
         edtEstadoProyectoID_Title = context.GetMessage( "Proyecto ID", "");
         edtEstadoProyectoID_Visible = -1;
         edtavDelete_Enabled = 0;
         edtavUpdate_Enabled = 0;
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_gridcolumnsselector_Updatebuttontext = "WWP_ColumnsSelectorButton";
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = "";
         Ddo_gridcolumnsselector_Dropdownoptionstype = "GridColumnsSelector";
         Ddo_gridcolumnsselector_Cls = "ColumnsSelector hidden-xs";
         Ddo_gridcolumnsselector_Tooltip = "WWP_EditColumnsTooltip";
         Ddo_gridcolumnsselector_Caption = context.GetMessage( "WWP_EditColumnsCaption", "");
         Innewwindow1_Target = "";
         Innewwindow1_Height = "50";
         Innewwindow1_Width = "50";
         Ddo_estadoproyectonombre_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_estadoproyectonombre_Noresultsfound = "WWP_TSNoResults";
         Ddo_estadoproyectonombre_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_estadoproyectonombre_Loadingdata = "WWP_TSLoading";
         Ddo_estadoproyectonombre_Sortdsc = "WWP_TSSortDSC";
         Ddo_estadoproyectonombre_Sortasc = "WWP_TSSortASC";
         Ddo_estadoproyectonombre_Datalistupdateminimumcharacters = 0;
         Ddo_estadoproyectonombre_Datalistproc = "EstadoProyectoWWGetFilterData";
         Ddo_estadoproyectonombre_Datalisttype = "Dynamic";
         Ddo_estadoproyectonombre_Includedatalist = Convert.ToBoolean( -1);
         Ddo_estadoproyectonombre_Filterisrange = Convert.ToBoolean( 0);
         Ddo_estadoproyectonombre_Filtertype = "Character";
         Ddo_estadoproyectonombre_Includefilter = Convert.ToBoolean( -1);
         Ddo_estadoproyectonombre_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_estadoproyectonombre_Includesortasc = Convert.ToBoolean( -1);
         Ddo_estadoproyectonombre_Titlecontrolidtoreplace = "";
         Ddo_estadoproyectonombre_Dropdownoptionstype = "GridTitleSettings";
         Ddo_estadoproyectonombre_Cls = "ColumnSettings";
         Ddo_estadoproyectonombre_Tooltip = "WWP_TSColumnOptions";
         Ddo_estadoproyectonombre_Caption = "";
         Ddo_estadoproyectoid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_estadoproyectoid_Rangefilterto = "WWP_TSTo";
         Ddo_estadoproyectoid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_estadoproyectoid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_estadoproyectoid_Sortdsc = "WWP_TSSortDSC";
         Ddo_estadoproyectoid_Sortasc = "WWP_TSSortASC";
         Ddo_estadoproyectoid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_estadoproyectoid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_estadoproyectoid_Filtertype = "Numeric";
         Ddo_estadoproyectoid_Includefilter = Convert.ToBoolean( -1);
         Ddo_estadoproyectoid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_estadoproyectoid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_estadoproyectoid_Titlecontrolidtoreplace = "";
         Ddo_estadoproyectoid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_estadoproyectoid_Cls = "ColumnSettings";
         Ddo_estadoproyectoid_Tooltip = "WWP_TSColumnOptions";
         Ddo_estadoproyectoid_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Caption = context.GetMessage( "WWP_PagingCaption", "");
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "right";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = context.GetMessage( "WWP_FilterOptions", "");
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Width = "100%";
         Ddo_managefilters_Cls = "ManageFilters";
         Ddo_managefilters_Tooltip = "WWP_ManageFiltersTooltip";
         Ddo_managefilters_Icon = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( " Estado Proyecto", "");
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E121F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E131F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("DDO_ESTADOPROYECTOID.ONOPTIONCLICKED","{handler:'E141F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_estadoproyectoid_Activeeventkey',ctrl:'DDO_ESTADOPROYECTOID',prop:'ActiveEventKey'},{av:'Ddo_estadoproyectoid_Filteredtext_get',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_get'},{av:'Ddo_estadoproyectoid_Filteredtextto_get',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_get'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("DDO_ESTADOPROYECTOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_estadoproyectoid_Sortedstatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'Ddo_estadoproyectonombre_Sortedstatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED","{handler:'E151F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_estadoproyectonombre_Activeeventkey',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'ActiveEventKey'},{av:'Ddo_estadoproyectonombre_Filteredtext_get',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_get'},{av:'Ddo_estadoproyectonombre_Selectedvalue_get',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_get'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("DDO_ESTADOPROYECTONOMBRE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_estadoproyectonombre_Sortedstatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'Ddo_estadoproyectoid_Sortedstatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E301F2',iparms:[{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV69Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV70Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtEstadoProyectoNombre_Link',ctrl:'ESTADOPROYECTONOMBRE',prop:'Link'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E161F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E231F2',iparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E171F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E241F2',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E251F2',iparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E181F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E261F2',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E191F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E271F2',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E111F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'Ddo_estadoproyectoid_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'Ddo_estadoproyectoid_Filteredtextto_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'Ddo_estadoproyectonombre_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'Ddo_estadoproyectonombre_Selectedvalue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'Ddo_estadoproyectoid_Sortedstatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'Ddo_estadoproyectonombre_Sortedstatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV57EstadoProyectoIDTitleFilterData',fld:'vESTADOPROYECTOIDTITLEFILTERDATA',pic:''},{av:'AV61EstadoProyectoNombreTitleFilterData',fld:'vESTADOPROYECTONOMBRETITLEFILTERDATA',pic:''},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtEstadoProyectoID_Visible',ctrl:'ESTADOPROYECTOID',prop:'Visible'},{av:'edtEstadoProyectoNombre_Visible',ctrl:'ESTADOPROYECTONOMBRE',prop:'Visible'},{av:'edtEstadoProyectoID_Titleformat',ctrl:'ESTADOPROYECTOID',prop:'Titleformat'},{av:'edtEstadoProyectoID_Title',ctrl:'ESTADOPROYECTOID',prop:'Title'},{av:'edtEstadoProyectoNombre_Titleformat',ctrl:'ESTADOPROYECTONOMBRE',prop:'Titleformat'},{av:'edtEstadoProyectoNombre_Title',ctrl:'ESTADOPROYECTONOMBRE',prop:'Title'},{av:'AV67GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV68GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV55ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E201F2',iparms:[{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'DOINSERT'",",oparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'DOEXPORT'","{handler:'E211F2',iparms:[{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'DOEXPORT'",",oparms:[{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_estadoproyectoid_Sortedstatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'Ddo_estadoproyectonombre_Sortedstatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'Ddo_estadoproyectoid_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'Ddo_estadoproyectoid_Filteredtextto_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'Ddo_estadoproyectonombre_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'Ddo_estadoproyectonombre_Selectedvalue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("'DOEXPORTREPORT'","{handler:'E221F2',iparms:[{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("'DOEXPORTREPORT'",",oparms:[{av:'Innewwindow1_Target',ctrl:'INNEWWINDOW1',prop:'Target'},{av:'Innewwindow1_Height',ctrl:'INNEWWINDOW1',prop:'Height'},{av:'Innewwindow1_Width',ctrl:'INNEWWINDOW1',prop:'Width'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18EstadoProyectoNombre1',fld:'vESTADOPROYECTONOMBRE1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22EstadoProyectoNombre2',fld:'vESTADOPROYECTONOMBRE2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26EstadoProyectoNombre3',fld:'vESTADOPROYECTONOMBRE3',pic:''},{av:'AV58TFEstadoProyectoID',fld:'vTFESTADOPROYECTOID',pic:'ZZZ9'},{av:'AV59TFEstadoProyectoID_To',fld:'vTFESTADOPROYECTOID_TO',pic:'ZZZ9'},{av:'AV62TFEstadoProyectoNombre',fld:'vTFESTADOPROYECTONOMBRE',pic:''},{av:'AV63TFEstadoProyectoNombre_Sel',fld:'vTFESTADOPROYECTONOMBRE_SEL',pic:''},{av:'AV51ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV43ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV60ddo_EstadoProyectoIDTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV64ddo_EstadoProyectoNombreTitleControlIdToReplace',fld:'vDDO_ESTADOPROYECTONOMBRETITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_estadoproyectoid_Sortedstatus',ctrl:'DDO_ESTADOPROYECTOID',prop:'SortedStatus'},{av:'Ddo_estadoproyectonombre_Sortedstatus',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SortedStatus'},{av:'Ddo_estadoproyectoid_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredText_set'},{av:'Ddo_estadoproyectoid_Filteredtextto_set',ctrl:'DDO_ESTADOPROYECTOID',prop:'FilteredTextTo_set'},{av:'Ddo_estadoproyectonombre_Filteredtext_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'FilteredText_set'},{av:'Ddo_estadoproyectonombre_Selectedvalue_set',ctrl:'DDO_ESTADOPROYECTONOMBRE',prop:'SelectedValue_set'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavEstadoproyectonombre1_Visible',ctrl:'vESTADOPROYECTONOMBRE1',prop:'Visible'},{av:'edtavEstadoproyectonombre2_Visible',ctrl:'vESTADOPROYECTONOMBRE2',prop:'Visible'},{av:'edtavEstadoproyectonombre3_Visible',ctrl:'vESTADOPROYECTONOMBRE3',prop:'Visible'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         setEventMetadata("NULL","{handler:'Valid_Estadoproyectonombre',iparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]");
         setEventMetadata("NULL",",oparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''}]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Gridpaginationbar_Selectedpage = "";
         Ddo_estadoproyectoid_Activeeventkey = "";
         Ddo_estadoproyectoid_Filteredtext_get = "";
         Ddo_estadoproyectoid_Filteredtextto_get = "";
         Ddo_estadoproyectonombre_Activeeventkey = "";
         Ddo_estadoproyectonombre_Filteredtext_get = "";
         Ddo_estadoproyectonombre_Selectedvalue_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         Ddo_managefilters_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16DynamicFiltersSelector1 = "";
         AV18EstadoProyectoNombre1 = "";
         AV20DynamicFiltersSelector2 = "";
         AV22EstadoProyectoNombre2 = "";
         AV24DynamicFiltersSelector3 = "";
         AV26EstadoProyectoNombre3 = "";
         AV62TFEstadoProyectoNombre = "";
         AV63TFEstadoProyectoNombre_Sel = "";
         AV43ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV60ddo_EstadoProyectoIDTitleControlIdToReplace = "";
         AV64ddo_EstadoProyectoNombreTitleControlIdToReplace = "";
         AV88Pgmname = "";
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV55ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV65DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV57EstadoProyectoIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV61EstadoProyectoNombreTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_managefilters_Caption = "";
         Ddo_estadoproyectoid_Filteredtext_set = "";
         Ddo_estadoproyectoid_Filteredtextto_set = "";
         Ddo_estadoproyectoid_Sortedstatus = "";
         Ddo_estadoproyectonombre_Filteredtext_set = "";
         Ddo_estadoproyectonombre_Selectedvalue_set = "";
         Ddo_estadoproyectonombre_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         bttBtnexport_Jsonclick = "";
         bttBtnexportreport_Jsonclick = "";
         bttBtneditcolumns_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV69Update = "";
         AV70Delete = "";
         A34EstadoProyectoNombre = "";
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_estadoproyectoid = new GXUserControl();
         ucDdo_estadoproyectonombre = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucInnewwindow1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 = "";
         AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 = "";
         AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 = "";
         AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = "";
         AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         H001F2_A34EstadoProyectoNombre = new String[] {""} ;
         H001F2_A7EstadoProyectoID = new short[1] ;
         H001F3_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         imgAdddynamicfilters1_Jsonclick = "";
         imgRemovedynamicfilters1_Jsonclick = "";
         imgAdddynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters3_Jsonclick = "";
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV50Session = context.GetSession();
         AV31ColumnsSelectorXML = "";
         GridRow = new GXWebRow();
         AV52ManageFiltersXml = "";
         AV29ExcelFilename = "";
         AV30ErrorMessage = "";
         AV38UserCustomValue = "";
         GXt_char2 = "";
         AV44ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV56ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV53ManageFiltersItems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         AV54ManageFiltersItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         lblDynamicfiltersprefix1_Jsonclick = "";
         lblDynamicfiltersmiddle1_Jsonclick = "";
         lblDynamicfiltersprefix2_Jsonclick = "";
         lblDynamicfiltersmiddle2_Jsonclick = "";
         lblDynamicfiltersprefix3_Jsonclick = "";
         lblDynamicfiltersmiddle3_Jsonclick = "";
         sImgUrl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estadoproyectoww__default(),
            new Object[][] {
                new Object[] {
               H001F2_A34EstadoProyectoNombre, H001F2_A7EstadoProyectoID
               }
               , new Object[] {
               H001F3_AGRID_nRecordCount
               }
            }
         );
         AV88Pgmname = "EstadoProyectoWW";
         /* GeneXus formulas. */
         AV88Pgmname = "EstadoProyectoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short GRID_nEOF ;
      private short AV17DynamicFiltersOperator1 ;
      private short AV21DynamicFiltersOperator2 ;
      private short AV25DynamicFiltersOperator3 ;
      private short AV13OrderedBy ;
      private short AV58TFEstadoProyectoID ;
      private short AV59TFEstadoProyectoID_To ;
      private short AV51ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtEstadoProyectoID_Titleformat ;
      private short edtEstadoProyectoNombre_Titleformat ;
      private short subGrid_Sortable ;
      private short A7EstadoProyectoID ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ;
      private short AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ;
      private short AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ;
      private short AV84EstadoProyectoWWDS_12_Tfestadoproyectoid ;
      private short AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int nRC_GXsfl_118 ;
      private int nGXsfl_118_idx=1 ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_estadoproyectonombre_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtEstadoProyectoID_Visible ;
      private int edtEstadoProyectoNombre_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavManagefiltersexecutionstep_Visible ;
      private int edtavTfestadoproyectoid_Visible ;
      private int edtavTfestadoproyectoid_to_Visible ;
      private int edtavTfestadoproyectonombre_Visible ;
      private int edtavTfestadoproyectonombre_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV66PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int edtavEstadoproyectonombre1_Visible ;
      private int edtavEstadoproyectonombre2_Visible ;
      private int edtavEstadoproyectonombre3_Visible ;
      private int AV89GXV1 ;
      private int AV90GXV2 ;
      private int edtavEstadoproyectonombre3_Enabled ;
      private int edtavEstadoproyectonombre2_Enabled ;
      private int edtavEstadoproyectonombre1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV67GridCurrentPage ;
      private long AV68GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_estadoproyectoid_Activeeventkey ;
      private String Ddo_estadoproyectoid_Filteredtext_get ;
      private String Ddo_estadoproyectoid_Filteredtextto_get ;
      private String Ddo_estadoproyectonombre_Activeeventkey ;
      private String Ddo_estadoproyectonombre_Filteredtext_get ;
      private String Ddo_estadoproyectonombre_Selectedvalue_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String Ddo_managefilters_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_118_idx="0001" ;
      private String AV18EstadoProyectoNombre1 ;
      private String AV22EstadoProyectoNombre2 ;
      private String AV26EstadoProyectoNombre3 ;
      private String AV62TFEstadoProyectoNombre ;
      private String AV63TFEstadoProyectoNombre_Sel ;
      private String AV88Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Ddo_managefilters_Icon ;
      private String Ddo_managefilters_Caption ;
      private String Ddo_managefilters_Tooltip ;
      private String Ddo_managefilters_Cls ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_estadoproyectoid_Caption ;
      private String Ddo_estadoproyectoid_Tooltip ;
      private String Ddo_estadoproyectoid_Cls ;
      private String Ddo_estadoproyectoid_Filteredtext_set ;
      private String Ddo_estadoproyectoid_Filteredtextto_set ;
      private String Ddo_estadoproyectoid_Dropdownoptionstype ;
      private String Ddo_estadoproyectoid_Titlecontrolidtoreplace ;
      private String Ddo_estadoproyectoid_Sortedstatus ;
      private String Ddo_estadoproyectoid_Filtertype ;
      private String Ddo_estadoproyectoid_Sortasc ;
      private String Ddo_estadoproyectoid_Sortdsc ;
      private String Ddo_estadoproyectoid_Cleanfilter ;
      private String Ddo_estadoproyectoid_Rangefilterfrom ;
      private String Ddo_estadoproyectoid_Rangefilterto ;
      private String Ddo_estadoproyectoid_Searchbuttontext ;
      private String Ddo_estadoproyectonombre_Caption ;
      private String Ddo_estadoproyectonombre_Tooltip ;
      private String Ddo_estadoproyectonombre_Cls ;
      private String Ddo_estadoproyectonombre_Filteredtext_set ;
      private String Ddo_estadoproyectonombre_Selectedvalue_set ;
      private String Ddo_estadoproyectonombre_Dropdownoptionstype ;
      private String Ddo_estadoproyectonombre_Titlecontrolidtoreplace ;
      private String Ddo_estadoproyectonombre_Sortedstatus ;
      private String Ddo_estadoproyectonombre_Filtertype ;
      private String Ddo_estadoproyectonombre_Datalisttype ;
      private String Ddo_estadoproyectonombre_Datalistproc ;
      private String Ddo_estadoproyectonombre_Sortasc ;
      private String Ddo_estadoproyectonombre_Sortdsc ;
      private String Ddo_estadoproyectonombre_Loadingdata ;
      private String Ddo_estadoproyectonombre_Cleanfilter ;
      private String Ddo_estadoproyectonombre_Noresultsfound ;
      private String Ddo_estadoproyectonombre_Searchbuttontext ;
      private String Innewwindow1_Width ;
      private String Innewwindow1_Height ;
      private String Innewwindow1_Target ;
      private String Ddo_gridcolumnsselector_Caption ;
      private String Ddo_gridcolumnsselector_Tooltip ;
      private String Ddo_gridcolumnsselector_Cls ;
      private String Ddo_gridcolumnsselector_Dropdownoptionstype ;
      private String Ddo_gridcolumnsselector_Titlecontrolidtoreplace ;
      private String Ddo_gridcolumnsselector_Updatebuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String bttBtnexport_Internalname ;
      private String bttBtnexport_Jsonclick ;
      private String bttBtnexportreport_Internalname ;
      private String bttBtnexportreport_Jsonclick ;
      private String bttBtneditcolumns_Internalname ;
      private String bttBtneditcolumns_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtEstadoProyectoID_Title ;
      private String edtEstadoProyectoNombre_Title ;
      private String subGrid_Header ;
      private String AV69Update ;
      private String edtavUpdate_Link ;
      private String AV70Delete ;
      private String edtavDelete_Link ;
      private String A34EstadoProyectoNombre ;
      private String edtEstadoProyectoNombre_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_estadoproyectoid_Internalname ;
      private String edtavDdo_estadoproyectoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_estadoproyectonombre_Internalname ;
      private String edtavDdo_estadoproyectonombretitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String Innewwindow1_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String chkavDynamicfiltersenabled2_Internalname ;
      private String chkavDynamicfiltersenabled3_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavManagefiltersexecutionstep_Internalname ;
      private String edtavManagefiltersexecutionstep_Jsonclick ;
      private String edtavTfestadoproyectoid_Internalname ;
      private String edtavTfestadoproyectoid_Jsonclick ;
      private String edtavTfestadoproyectoid_to_Internalname ;
      private String edtavTfestadoproyectoid_to_Jsonclick ;
      private String edtavTfestadoproyectonombre_Internalname ;
      private String edtavTfestadoproyectonombre_Jsonclick ;
      private String edtavTfestadoproyectonombre_sel_Internalname ;
      private String edtavTfestadoproyectonombre_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtEstadoProyectoID_Internalname ;
      private String edtEstadoProyectoNombre_Internalname ;
      private String cmbavDynamicfiltersselector1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Internalname ;
      private String cmbavDynamicfiltersselector2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Internalname ;
      private String cmbavDynamicfiltersselector3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Internalname ;
      private String scmdbuf ;
      private String lV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String lV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String lV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ;
      private String AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String edtavEstadoproyectonombre1_Internalname ;
      private String edtavEstadoproyectonombre2_Internalname ;
      private String edtavEstadoproyectonombre3_Internalname ;
      private String imgAdddynamicfilters1_Jsonclick ;
      private String tblTabledynamicfilters_Internalname ;
      private String imgAdddynamicfilters1_Internalname ;
      private String imgRemovedynamicfilters1_Jsonclick ;
      private String imgRemovedynamicfilters1_Internalname ;
      private String imgAdddynamicfilters2_Jsonclick ;
      private String imgAdddynamicfilters2_Internalname ;
      private String imgRemovedynamicfilters2_Jsonclick ;
      private String imgRemovedynamicfilters2_Internalname ;
      private String imgRemovedynamicfilters3_Jsonclick ;
      private String imgRemovedynamicfilters3_Internalname ;
      private String Ddo_managefilters_Internalname ;
      private String GXt_char2 ;
      private String tblTablerightheader_Internalname ;
      private String divHtml_managefilters_Internalname ;
      private String tblTablefilters_Internalname ;
      private String lblDynamicfiltersprefix1_Internalname ;
      private String lblDynamicfiltersprefix1_Jsonclick ;
      private String cmbavDynamicfiltersselector1_Jsonclick ;
      private String lblDynamicfiltersmiddle1_Internalname ;
      private String lblDynamicfiltersmiddle1_Jsonclick ;
      private String lblDynamicfiltersprefix2_Internalname ;
      private String lblDynamicfiltersprefix2_Jsonclick ;
      private String cmbavDynamicfiltersselector2_Jsonclick ;
      private String lblDynamicfiltersmiddle2_Internalname ;
      private String lblDynamicfiltersmiddle2_Jsonclick ;
      private String lblDynamicfiltersprefix3_Internalname ;
      private String lblDynamicfiltersprefix3_Jsonclick ;
      private String cmbavDynamicfiltersselector3_Jsonclick ;
      private String lblDynamicfiltersmiddle3_Internalname ;
      private String lblDynamicfiltersmiddle3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_3_Internalname ;
      private String cellDynamicfilters_removefilter3_cell_Internalname ;
      private String sImgUrl ;
      private String tblTablemergeddynamicfilters3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Jsonclick ;
      private String cellFilter_estadoproyectonombre3_cell_Internalname ;
      private String edtavEstadoproyectonombre3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_2_Internalname ;
      private String cellDynamicfilters_addfilter2_cell_Internalname ;
      private String cellDynamicfilters_removefilter2_cell_Internalname ;
      private String tblTablemergeddynamicfilters2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Jsonclick ;
      private String cellFilter_estadoproyectonombre2_cell_Internalname ;
      private String edtavEstadoproyectonombre2_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_1_Internalname ;
      private String cellDynamicfilters_addfilter1_cell_Internalname ;
      private String cellDynamicfilters_removefilter1_cell_Internalname ;
      private String tblTablemergeddynamicfilters1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Jsonclick ;
      private String cellFilter_estadoproyectonombre1_cell_Internalname ;
      private String edtavEstadoproyectonombre1_Jsonclick ;
      private String sGXsfl_118_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtEstadoProyectoID_Jsonclick ;
      private String edtEstadoProyectoNombre_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV19DynamicFiltersEnabled2 ;
      private bool AV23DynamicFiltersEnabled3 ;
      private bool AV14OrderedDsc ;
      private bool AV28DynamicFiltersIgnoreFirst ;
      private bool AV27DynamicFiltersRemoving ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_estadoproyectoid_Includesortasc ;
      private bool Ddo_estadoproyectoid_Includesortdsc ;
      private bool Ddo_estadoproyectoid_Includefilter ;
      private bool Ddo_estadoproyectoid_Filterisrange ;
      private bool Ddo_estadoproyectoid_Includedatalist ;
      private bool Ddo_estadoproyectonombre_Includesortasc ;
      private bool Ddo_estadoproyectonombre_Includesortdsc ;
      private bool Ddo_estadoproyectonombre_Includefilter ;
      private bool Ddo_estadoproyectonombre_Filterisrange ;
      private bool Ddo_estadoproyectonombre_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_118_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ;
      private bool AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV31ColumnsSelectorXML ;
      private String AV52ManageFiltersXml ;
      private String AV38UserCustomValue ;
      private String AV16DynamicFiltersSelector1 ;
      private String AV20DynamicFiltersSelector2 ;
      private String AV24DynamicFiltersSelector3 ;
      private String AV60ddo_EstadoProyectoIDTitleControlIdToReplace ;
      private String AV64ddo_EstadoProyectoNombreTitleControlIdToReplace ;
      private String AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 ;
      private String AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 ;
      private String AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 ;
      private String AV29ExcelFilename ;
      private String AV30ErrorMessage ;
      private IGxSession AV50Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_estadoproyectoid ;
      private GXUserControl ucDdo_estadoproyectonombre ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucInnewwindow1 ;
      private GXUserControl ucDdo_gridcolumnsselector ;
      private GXUserControl ucDdo_managefilters ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavDynamicfiltersselector1 ;
      private GXCombobox cmbavDynamicfiltersoperator1 ;
      private GXCombobox cmbavDynamicfiltersselector2 ;
      private GXCombobox cmbavDynamicfiltersoperator2 ;
      private GXCombobox cmbavDynamicfiltersselector3 ;
      private GXCombobox cmbavDynamicfiltersoperator3 ;
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private String[] H001F2_A34EstadoProyectoNombre ;
      private short[] H001F2_A7EstadoProyectoID ;
      private long[] H001F3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV53ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV55ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV57EstadoProyectoIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV61EstadoProyectoNombreTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV12GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV43ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV54ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV56ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV65DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class estadoproyectoww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001F2( IGxContext context ,
                                             String AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                             short AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                             String AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                             bool AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                             String AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                             short AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                             String AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                             bool AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                             String AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                             short AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                             String AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                             short AV84EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                             short AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                             String AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                             String AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                             String A34EstadoProyectoNombre ,
                                             short A7EstadoProyectoID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [13] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [EstadoProyectoNombre], [EstadoProyectoID]";
         sFromString = " FROM [EstadoProyecto]";
         sOrderString = "";
         if ( ( StringUtil.StrCmp(AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV84EstadoProyectoWWDS_12_Tfestadoproyectoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] >= @AV84EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] >= @AV84EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (0==AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] <= @AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] <= @AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] = @AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] = @AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [EstadoProyectoNombre]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [EstadoProyectoNombre] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [EstadoProyectoID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [EstadoProyectoID] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [EstadoProyectoID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H001F3( IGxContext context ,
                                             String AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                             short AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                             String AV75EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                             bool AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                             String AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                             short AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                             String AV79EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                             bool AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                             String AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                             short AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                             String AV83EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                             short AV84EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                             short AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                             String AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                             String AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                             String A34EstadoProyectoNombre ,
                                             short A7EstadoProyectoID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [10] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [EstadoProyecto]";
         if ( ( StringUtil.StrCmp(AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV73EstadoProyectoWWDS_1_Dynamicfiltersselector1, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV74EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV75EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( AV76EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV77EstadoProyectoWWDS_5_Dynamicfiltersselector2, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV78EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV79EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( AV80EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV81EstadoProyectoWWDS_9_Dynamicfiltersselector3, "ESTADOPROYECTONOMBRE") == 0 ) && ( AV82EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV83EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV84EstadoProyectoWWDS_12_Tfestadoproyectoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] >= @AV84EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] >= @AV84EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (0==AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] <= @AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] <= @AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] = @AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] = @AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001F2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (bool)dynConstraints[18] );
               case 1 :
                     return conditional_H001F3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (bool)dynConstraints[18] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001F2 ;
          prmH001F2 = new Object[] {
          new Object[] {"@lV75EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV75EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV79EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV79EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV83EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV83EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV84EstadoProyectoWWDS_12_Tfestadoproyectoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel",SqlDbType.NChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001F3 ;
          prmH001F3 = new Object[] {
          new Object[] {"@lV75EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV75EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV79EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV79EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV83EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV83EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV84EstadoProyectoWWDS_12_Tfestadoproyectoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV85EstadoProyectoWWDS_13_Tfestadoproyectoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV86EstadoProyectoWWDS_14_Tfestadoproyectonombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV87EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel",SqlDbType.NChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H001F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F3,1, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
       }
    }

 }

}
