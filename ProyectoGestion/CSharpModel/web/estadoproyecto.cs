/*
               File: EstadoProyecto
        Description: Estado Proyecto
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/25/2020 18:0:1.74
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estadoproyecto : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7EstadoProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(AV7EstadoProyectoID), 4, 0));
               AssignAttri("", false, "gxhash_vESTADOPROYECTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstadoProyectoID), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Estado Proyecto", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEstadoProyectoNombre_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public estadoproyecto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public estadoproyecto( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EstadoProyectoID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EstadoProyectoID = aP1_EstadoProyectoID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
         /* User Defined Control */
         ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
         ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
         ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
         ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
         ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
         ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
         ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
         ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
         ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
         ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
         ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
         context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
         /* Div Control */
         GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstadoProyectoID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEstadoProyectoID_Internalname, context.GetMessage( "Proyecto ID", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEstadoProyectoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7EstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtEstadoProyectoID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9")) : context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstadoProyectoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstadoProyectoID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_EstadoProyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstadoProyectoNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEstadoProyectoNombre_Internalname, context.GetMessage( "Proyecto Nombre", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEstadoProyectoNombre_Internalname, StringUtil.RTrim( A34EstadoProyectoNombre), StringUtil.RTrim( context.localUtil.Format( A34EstadoProyectoNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstadoProyectoNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstadoProyectoNombre_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Name", "left", true, "", "HLP_EstadoProyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         context.WriteHtmlText( "</div>") ;
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
         ClassString = "ButtonMaterial";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtntrn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
         ClassString = "ButtonMaterialDefault";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtntrn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         ClassString = "ButtonMaterialDefault";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtntrn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_EstadoProyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11072 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z7EstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( "Z7EstadoProyectoID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z34EstadoProyectoNombre = cgiGet( "Z34EstadoProyectoNombre");
               Z40EstadoProyectoApellido = (short)(context.localUtil.CToN( cgiGet( "Z40EstadoProyectoApellido"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z41EstadoProyectoDireccion = (short)(context.localUtil.CToN( cgiGet( "Z41EstadoProyectoDireccion"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z42EstadoProyectoLugarNacimeinto = (short)(context.localUtil.CToN( cgiGet( "Z42EstadoProyectoLugarNacimeinto"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A40EstadoProyectoApellido = (short)(context.localUtil.CToN( cgiGet( "Z40EstadoProyectoApellido"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A41EstadoProyectoDireccion = (short)(context.localUtil.CToN( cgiGet( "Z41EstadoProyectoDireccion"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A42EstadoProyectoLugarNacimeinto = (short)(context.localUtil.CToN( cgiGet( "Z42EstadoProyectoLugarNacimeinto"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Gx_mode = cgiGet( "Mode");
               AV7EstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( "vESTADOPROYECTOID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A40EstadoProyectoApellido = (short)(context.localUtil.CToN( cgiGet( "ESTADOPROYECTOAPELLIDO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A41EstadoProyectoDireccion = (short)(context.localUtil.CToN( cgiGet( "ESTADOPROYECTODIRECCION"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               A42EstadoProyectoLugarNacimeinto = (short)(context.localUtil.CToN( cgiGet( "ESTADOPROYECTOLUGARNACIMEINTO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read variables values. */
               A7EstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( edtEstadoProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
               A34EstadoProyectoNombre = cgiGet( edtEstadoProyectoNombre_Internalname);
               AssignAttri("", false, "A34EstadoProyectoNombre", A34EstadoProyectoNombre);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"EstadoProyecto");
               A7EstadoProyectoID = (short)(context.localUtil.CToN( cgiGet( edtEstadoProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
               forbiddenHiddens.Add("EstadoProyectoID", context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               forbiddenHiddens.Add("EstadoProyectoApellido", context.localUtil.Format( (decimal)(A40EstadoProyectoApellido), "ZZZ9"));
               forbiddenHiddens.Add("EstadoProyectoDireccion", context.localUtil.Format( (decimal)(A41EstadoProyectoDireccion), "ZZZ9"));
               forbiddenHiddens.Add("EstadoProyectoLugarNacimeinto", context.localUtil.Format( (decimal)(A42EstadoProyectoLugarNacimeinto), "ZZZ9"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A7EstadoProyectoID != Z7EstadoProyectoID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("estadoproyecto:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A7EstadoProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( IsDsp( ) )
                  {
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode6;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ESTADOPROYECTOID");
                        AnyError = 1;
                        GX_FocusControl = edtEstadoProyectoID_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! IsDsp( ) )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12072 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll076( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         AssignProp("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtntrn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) || IsDlt( ) )
         {
            bttBtntrn_delete_Visible = 0;
            AssignProp("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtntrn_delete_Visible), 5, 0), true);
            if ( IsDsp( ) )
            {
               bttBtntrn_enter_Visible = 0;
               AssignProp("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtntrn_enter_Visible), 5, 0), true);
            }
            DisableAttributes076( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_070( )
      {
         BeforeValidate076( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls076( ) ;
            }
            else
            {
               CheckExtendedTable076( ) ;
               CloseExtendedTableCursors076( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption070( )
      {
      }

      protected void E11072( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "IS2");
         if ( ! new GeneXus.Programs.wwpbaseobjects.isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "IS2");
      }

      protected void E12072( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("estadoproyectoww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwestadoproyecto.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM076( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z34EstadoProyectoNombre = T00073_A34EstadoProyectoNombre[0];
               Z40EstadoProyectoApellido = T00073_A40EstadoProyectoApellido[0];
               Z41EstadoProyectoDireccion = T00073_A41EstadoProyectoDireccion[0];
               Z42EstadoProyectoLugarNacimeinto = T00073_A42EstadoProyectoLugarNacimeinto[0];
            }
            else
            {
               Z34EstadoProyectoNombre = A34EstadoProyectoNombre;
               Z40EstadoProyectoApellido = A40EstadoProyectoApellido;
               Z41EstadoProyectoDireccion = A41EstadoProyectoDireccion;
               Z42EstadoProyectoLugarNacimeinto = A42EstadoProyectoLugarNacimeinto;
            }
         }
         if ( GX_JID == -3 )
         {
            Z7EstadoProyectoID = A7EstadoProyectoID;
            Z34EstadoProyectoNombre = A34EstadoProyectoNombre;
            Z40EstadoProyectoApellido = A40EstadoProyectoApellido;
            Z41EstadoProyectoDireccion = A41EstadoProyectoDireccion;
            Z42EstadoProyectoLugarNacimeinto = A42EstadoProyectoLugarNacimeinto;
         }
      }

      protected void standaloneNotModal( )
      {
         edtEstadoProyectoID_Enabled = 0;
         AssignProp("", false, edtEstadoProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoID_Enabled), 5, 0), true);
         edtEstadoProyectoID_Enabled = 0;
         AssignProp("", false, edtEstadoProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoID_Enabled), 5, 0), true);
         bttBtntrn_delete_Enabled = 0;
         AssignProp("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtntrn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7EstadoProyectoID) )
         {
            A7EstadoProyectoID = AV7EstadoProyectoID;
            AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            AssignProp("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtntrn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            AssignProp("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtntrn_enter_Enabled), 5, 0), true);
         }
      }

      protected void Load076( )
      {
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A7EstadoProyectoID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1;
            A34EstadoProyectoNombre = T00074_A34EstadoProyectoNombre[0];
            AssignAttri("", false, "A34EstadoProyectoNombre", A34EstadoProyectoNombre);
            A40EstadoProyectoApellido = T00074_A40EstadoProyectoApellido[0];
            A41EstadoProyectoDireccion = T00074_A41EstadoProyectoDireccion[0];
            A42EstadoProyectoLugarNacimeinto = T00074_A42EstadoProyectoLugarNacimeinto[0];
            ZM076( -3) ;
         }
         pr_default.close(2);
         OnLoadActions076( ) ;
      }

      protected void OnLoadActions076( )
      {
         AV12Pgmname = "EstadoProyecto";
         AssignAttri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable076( )
      {
         nIsDirty_6 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "EstadoProyecto";
         AssignAttri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CloseExtendedTableCursors076( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey076( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A7EstadoProyectoID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A7EstadoProyectoID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM076( 3) ;
            RcdFound6 = 1;
            A7EstadoProyectoID = T00073_A7EstadoProyectoID[0];
            AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
            A34EstadoProyectoNombre = T00073_A34EstadoProyectoNombre[0];
            AssignAttri("", false, "A34EstadoProyectoNombre", A34EstadoProyectoNombre);
            A40EstadoProyectoApellido = T00073_A40EstadoProyectoApellido[0];
            A41EstadoProyectoDireccion = T00073_A41EstadoProyectoDireccion[0];
            A42EstadoProyectoLugarNacimeinto = T00073_A42EstadoProyectoLugarNacimeinto[0];
            Z7EstadoProyectoID = A7EstadoProyectoID;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load076( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey076( ) ;
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey076( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey076( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A7EstadoProyectoID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00076_A7EstadoProyectoID[0] < A7EstadoProyectoID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00076_A7EstadoProyectoID[0] > A7EstadoProyectoID ) ) )
            {
               A7EstadoProyectoID = T00076_A7EstadoProyectoID[0];
               AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A7EstadoProyectoID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00077_A7EstadoProyectoID[0] > A7EstadoProyectoID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00077_A7EstadoProyectoID[0] < A7EstadoProyectoID ) ) )
            {
               A7EstadoProyectoID = T00077_A7EstadoProyectoID[0];
               AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
               RcdFound6 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey076( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtEstadoProyectoNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert076( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A7EstadoProyectoID != Z7EstadoProyectoID )
               {
                  A7EstadoProyectoID = Z7EstadoProyectoID;
                  AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ESTADOPROYECTOID");
                  AnyError = 1;
                  GX_FocusControl = edtEstadoProyectoID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEstadoProyectoNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update076( ) ;
                  GX_FocusControl = edtEstadoProyectoNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A7EstadoProyectoID != Z7EstadoProyectoID )
               {
                  /* Insert record */
                  GX_FocusControl = edtEstadoProyectoNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert076( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ESTADOPROYECTOID");
                     AnyError = 1;
                     GX_FocusControl = edtEstadoProyectoID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEstadoProyectoNombre_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert076( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( IsUpd( ) || IsDlt( ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A7EstadoProyectoID != Z7EstadoProyectoID )
         {
            A7EstadoProyectoID = Z7EstadoProyectoID;
            AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ESTADOPROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtEstadoProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEstadoProyectoNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency076( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A7EstadoProyectoID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EstadoProyecto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z34EstadoProyectoNombre, T00072_A34EstadoProyectoNombre[0]) != 0 ) || ( Z40EstadoProyectoApellido != T00072_A40EstadoProyectoApellido[0] ) || ( Z41EstadoProyectoDireccion != T00072_A41EstadoProyectoDireccion[0] ) || ( Z42EstadoProyectoLugarNacimeinto != T00072_A42EstadoProyectoLugarNacimeinto[0] ) )
            {
               if ( StringUtil.StrCmp(Z34EstadoProyectoNombre, T00072_A34EstadoProyectoNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("estadoproyecto:[seudo value changed for attri]"+"EstadoProyectoNombre");
                  GXUtil.WriteLogRaw("Old: ",Z34EstadoProyectoNombre);
                  GXUtil.WriteLogRaw("Current: ",T00072_A34EstadoProyectoNombre[0]);
               }
               if ( Z40EstadoProyectoApellido != T00072_A40EstadoProyectoApellido[0] )
               {
                  GXUtil.WriteLog("estadoproyecto:[seudo value changed for attri]"+"EstadoProyectoApellido");
                  GXUtil.WriteLogRaw("Old: ",Z40EstadoProyectoApellido);
                  GXUtil.WriteLogRaw("Current: ",T00072_A40EstadoProyectoApellido[0]);
               }
               if ( Z41EstadoProyectoDireccion != T00072_A41EstadoProyectoDireccion[0] )
               {
                  GXUtil.WriteLog("estadoproyecto:[seudo value changed for attri]"+"EstadoProyectoDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z41EstadoProyectoDireccion);
                  GXUtil.WriteLogRaw("Current: ",T00072_A41EstadoProyectoDireccion[0]);
               }
               if ( Z42EstadoProyectoLugarNacimeinto != T00072_A42EstadoProyectoLugarNacimeinto[0] )
               {
                  GXUtil.WriteLog("estadoproyecto:[seudo value changed for attri]"+"EstadoProyectoLugarNacimeinto");
                  GXUtil.WriteLogRaw("Old: ",Z42EstadoProyectoLugarNacimeinto);
                  GXUtil.WriteLogRaw("Current: ",T00072_A42EstadoProyectoLugarNacimeinto[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EstadoProyecto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert076( )
      {
         BeforeValidate076( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable076( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM076( 0) ;
            CheckOptimisticConcurrency076( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm076( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert076( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00078 */
                     pr_default.execute(6, new Object[] {A34EstadoProyectoNombre, A40EstadoProyectoApellido, A41EstadoProyectoDireccion, A42EstadoProyectoLugarNacimeinto});
                     A7EstadoProyectoID = T00078_A7EstadoProyectoID[0];
                     AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("EstadoProyecto") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption070( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load076( ) ;
            }
            EndLevel076( ) ;
         }
         CloseExtendedTableCursors076( ) ;
      }

      protected void Update076( )
      {
         BeforeValidate076( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable076( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency076( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm076( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate076( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00079 */
                     pr_default.execute(7, new Object[] {A34EstadoProyectoNombre, A40EstadoProyectoApellido, A41EstadoProyectoDireccion, A42EstadoProyectoLugarNacimeinto, A7EstadoProyectoID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("EstadoProyecto") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EstadoProyecto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate076( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( IsUpd( ) || IsDlt( ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel076( ) ;
         }
         CloseExtendedTableCursors076( ) ;
      }

      protected void DeferredUpdate076( )
      {
      }

      protected void delete( )
      {
         BeforeValidate076( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency076( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls076( ) ;
            AfterConfirm076( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete076( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000710 */
                  pr_default.execute(8, new Object[] {A7EstadoProyectoID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("EstadoProyecto") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( IsUpd( ) || IsDlt( ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel076( ) ;
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls076( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "EstadoProyecto";
            AssignAttri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void EndLevel076( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete076( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("estadoproyecto",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("estadoproyecto",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart076( )
      {
         /* Scan By routine */
         /* Using cursor T000711 */
         pr_default.execute(9);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A7EstadoProyectoID = T000711_A7EstadoProyectoID[0];
            AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext076( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A7EstadoProyectoID = T000711_A7EstadoProyectoID[0];
            AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
         }
      }

      protected void ScanEnd076( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm076( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert076( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate076( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete076( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete076( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate076( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes076( )
      {
         edtEstadoProyectoID_Enabled = 0;
         AssignProp("", false, edtEstadoProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoID_Enabled), 5, 0), true);
         edtEstadoProyectoNombre_Enabled = 0;
         AssignProp("", false, edtEstadoProyectoNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEstadoProyectoNombre_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes076( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?2020825180254", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("estadoproyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstadoProyectoID)+"\">") ;
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
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"EstadoProyecto");
         forbiddenHiddens.Add("EstadoProyectoID", context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         forbiddenHiddens.Add("EstadoProyectoApellido", context.localUtil.Format( (decimal)(A40EstadoProyectoApellido), "ZZZ9"));
         forbiddenHiddens.Add("EstadoProyectoDireccion", context.localUtil.Format( (decimal)(A41EstadoProyectoDireccion), "ZZZ9"));
         forbiddenHiddens.Add("EstadoProyectoLugarNacimeinto", context.localUtil.Format( (decimal)(A42EstadoProyectoLugarNacimeinto), "ZZZ9"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("estadoproyecto:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z7EstadoProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7EstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z34EstadoProyectoNombre", StringUtil.RTrim( Z34EstadoProyectoNombre));
         GxWebStd.gx_hidden_field( context, "Z40EstadoProyectoApellido", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40EstadoProyectoApellido), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z41EstadoProyectoDireccion", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41EstadoProyectoDireccion), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z42EstadoProyectoLugarNacimeinto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42EstadoProyectoLugarNacimeinto), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vESTADOPROYECTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EstadoProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vESTADOPROYECTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstadoProyectoID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ESTADOPROYECTOAPELLIDO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40EstadoProyectoApellido), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ESTADOPROYECTODIRECCION", StringUtil.LTrim( StringUtil.NToC( (decimal)(A41EstadoProyectoDireccion), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ESTADOPROYECTOLUGARNACIMEINTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42EstadoProyectoLugarNacimeinto), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("estadoproyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstadoProyectoID) ;
      }

      public override String GetPgmname( )
      {
         return "EstadoProyecto" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Estado Proyecto", "") ;
      }

      protected void InitializeNonKey076( )
      {
         A34EstadoProyectoNombre = "";
         AssignAttri("", false, "A34EstadoProyectoNombre", A34EstadoProyectoNombre);
         A40EstadoProyectoApellido = 0;
         AssignAttri("", false, "A40EstadoProyectoApellido", StringUtil.LTrimStr( (decimal)(A40EstadoProyectoApellido), 4, 0));
         A41EstadoProyectoDireccion = 0;
         AssignAttri("", false, "A41EstadoProyectoDireccion", StringUtil.LTrimStr( (decimal)(A41EstadoProyectoDireccion), 4, 0));
         A42EstadoProyectoLugarNacimeinto = 0;
         AssignAttri("", false, "A42EstadoProyectoLugarNacimeinto", StringUtil.LTrimStr( (decimal)(A42EstadoProyectoLugarNacimeinto), 4, 0));
         Z34EstadoProyectoNombre = "";
         Z40EstadoProyectoApellido = 0;
         Z41EstadoProyectoDireccion = 0;
         Z42EstadoProyectoLugarNacimeinto = 0;
      }

      protected void InitAll076( )
      {
         A7EstadoProyectoID = 0;
         AssignAttri("", false, "A7EstadoProyectoID", StringUtil.LTrimStr( (decimal)(A7EstadoProyectoID), 4, 0));
         InitializeNonKey076( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020825180261", true, true);
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
         context.AddJavascriptSource("estadoproyecto.js", "?2020825180262", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtEstadoProyectoID_Internalname = "ESTADOPROYECTOID";
         edtEstadoProyectoNombre_Internalname = "ESTADOPROYECTONOMBRE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Estado Proyecto", "");
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtEstadoProyectoNombre_Jsonclick = "";
         edtEstadoProyectoNombre_Enabled = 1;
         edtEstadoProyectoID_Jsonclick = "";
         edtEstadoProyectoID_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "right";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = context.GetMessage( "WWP_TemplateDataPanelTitle", "");
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstadoProyectoID',fld:'vESTADOPROYECTOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7EstadoProyectoID',fld:'vESTADOPROYECTOID',pic:'ZZZ9',hsh:true},{av:'A7EstadoProyectoID',fld:'ESTADOPROYECTOID',pic:'ZZZ9'},{av:'A40EstadoProyectoApellido',fld:'ESTADOPROYECTOAPELLIDO',pic:'ZZZ9'},{av:'A41EstadoProyectoDireccion',fld:'ESTADOPROYECTODIRECCION',pic:'ZZZ9'},{av:'A42EstadoProyectoLugarNacimeinto',fld:'ESTADOPROYECTOLUGARNACIMEINTO',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12072',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_ESTADOPROYECTOID","{handler:'Valid_Estadoproyectoid',iparms:[]");
         setEventMetadata("VALID_ESTADOPROYECTOID",",oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z34EstadoProyectoNombre = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A34EstadoProyectoNombre = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV12Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00074_A7EstadoProyectoID = new short[1] ;
         T00074_A34EstadoProyectoNombre = new String[] {""} ;
         T00074_A40EstadoProyectoApellido = new short[1] ;
         T00074_A41EstadoProyectoDireccion = new short[1] ;
         T00074_A42EstadoProyectoLugarNacimeinto = new short[1] ;
         T00075_A7EstadoProyectoID = new short[1] ;
         T00073_A7EstadoProyectoID = new short[1] ;
         T00073_A34EstadoProyectoNombre = new String[] {""} ;
         T00073_A40EstadoProyectoApellido = new short[1] ;
         T00073_A41EstadoProyectoDireccion = new short[1] ;
         T00073_A42EstadoProyectoLugarNacimeinto = new short[1] ;
         T00076_A7EstadoProyectoID = new short[1] ;
         T00077_A7EstadoProyectoID = new short[1] ;
         T00072_A7EstadoProyectoID = new short[1] ;
         T00072_A34EstadoProyectoNombre = new String[] {""} ;
         T00072_A40EstadoProyectoApellido = new short[1] ;
         T00072_A41EstadoProyectoDireccion = new short[1] ;
         T00072_A42EstadoProyectoLugarNacimeinto = new short[1] ;
         T00078_A7EstadoProyectoID = new short[1] ;
         T000711_A7EstadoProyectoID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estadoproyecto__default(),
            new Object[][] {
                new Object[] {
               T00072_A7EstadoProyectoID, T00072_A34EstadoProyectoNombre, T00072_A40EstadoProyectoApellido, T00072_A41EstadoProyectoDireccion, T00072_A42EstadoProyectoLugarNacimeinto
               }
               , new Object[] {
               T00073_A7EstadoProyectoID, T00073_A34EstadoProyectoNombre, T00073_A40EstadoProyectoApellido, T00073_A41EstadoProyectoDireccion, T00073_A42EstadoProyectoLugarNacimeinto
               }
               , new Object[] {
               T00074_A7EstadoProyectoID, T00074_A34EstadoProyectoNombre, T00074_A40EstadoProyectoApellido, T00074_A41EstadoProyectoDireccion, T00074_A42EstadoProyectoLugarNacimeinto
               }
               , new Object[] {
               T00075_A7EstadoProyectoID
               }
               , new Object[] {
               T00076_A7EstadoProyectoID
               }
               , new Object[] {
               T00077_A7EstadoProyectoID
               }
               , new Object[] {
               T00078_A7EstadoProyectoID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000711_A7EstadoProyectoID
               }
            }
         );
         AV12Pgmname = "EstadoProyecto";
      }

      private short wcpOAV7EstadoProyectoID ;
      private short Z7EstadoProyectoID ;
      private short Z40EstadoProyectoApellido ;
      private short Z41EstadoProyectoDireccion ;
      private short Z42EstadoProyectoLugarNacimeinto ;
      private short GxWebError ;
      private short AV7EstadoProyectoID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A7EstadoProyectoID ;
      private short A40EstadoProyectoApellido ;
      private short A41EstadoProyectoDireccion ;
      private short A42EstadoProyectoLugarNacimeinto ;
      private short RcdFound6 ;
      private short GX_JID ;
      private short nIsDirty_6 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtEstadoProyectoID_Enabled ;
      private int edtEstadoProyectoNombre_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z34EstadoProyectoNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEstadoProyectoNombre_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtEstadoProyectoID_Internalname ;
      private String edtEstadoProyectoID_Jsonclick ;
      private String TempTags ;
      private String A34EstadoProyectoNombre ;
      private String edtEstadoProyectoNombre_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String AV12Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00074_A7EstadoProyectoID ;
      private String[] T00074_A34EstadoProyectoNombre ;
      private short[] T00074_A40EstadoProyectoApellido ;
      private short[] T00074_A41EstadoProyectoDireccion ;
      private short[] T00074_A42EstadoProyectoLugarNacimeinto ;
      private short[] T00075_A7EstadoProyectoID ;
      private short[] T00073_A7EstadoProyectoID ;
      private String[] T00073_A34EstadoProyectoNombre ;
      private short[] T00073_A40EstadoProyectoApellido ;
      private short[] T00073_A41EstadoProyectoDireccion ;
      private short[] T00073_A42EstadoProyectoLugarNacimeinto ;
      private short[] T00076_A7EstadoProyectoID ;
      private short[] T00077_A7EstadoProyectoID ;
      private short[] T00072_A7EstadoProyectoID ;
      private String[] T00072_A34EstadoProyectoNombre ;
      private short[] T00072_A40EstadoProyectoApellido ;
      private short[] T00072_A41EstadoProyectoDireccion ;
      private short[] T00072_A42EstadoProyectoLugarNacimeinto ;
      private short[] T00078_A7EstadoProyectoID ;
      private short[] T000711_A7EstadoProyectoID ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
   }

   public class estadoproyecto__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@EstadoProyectoNombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@EstadoProyectoApellido",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstadoProyectoDireccion",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstadoProyectoLugarNacimeinto",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@EstadoProyectoNombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@EstadoProyectoApellido",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstadoProyectoDireccion",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstadoProyectoLugarNacimeinto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@EstadoProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [EstadoProyectoID], [EstadoProyectoNombre], [EstadoProyectoApellido], [EstadoProyectoDireccion], [EstadoProyectoLugarNacimeinto] FROM [EstadoProyecto] WITH (UPDLOCK) WHERE [EstadoProyectoID] = @EstadoProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00073", "SELECT [EstadoProyectoID], [EstadoProyectoNombre], [EstadoProyectoApellido], [EstadoProyectoDireccion], [EstadoProyectoLugarNacimeinto] FROM [EstadoProyecto] WHERE [EstadoProyectoID] = @EstadoProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00074", "SELECT TM1.[EstadoProyectoID], TM1.[EstadoProyectoNombre], TM1.[EstadoProyectoApellido], TM1.[EstadoProyectoDireccion], TM1.[EstadoProyectoLugarNacimeinto] FROM [EstadoProyecto] TM1 WHERE TM1.[EstadoProyectoID] = @EstadoProyectoID ORDER BY TM1.[EstadoProyectoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00075", "SELECT [EstadoProyectoID] FROM [EstadoProyecto] WHERE [EstadoProyectoID] = @EstadoProyectoID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00076", "SELECT TOP 1 [EstadoProyectoID] FROM [EstadoProyecto] WHERE ( [EstadoProyectoID] > @EstadoProyectoID) ORDER BY [EstadoProyectoID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00077", "SELECT TOP 1 [EstadoProyectoID] FROM [EstadoProyecto] WHERE ( [EstadoProyectoID] < @EstadoProyectoID) ORDER BY [EstadoProyectoID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00078", "INSERT INTO [EstadoProyecto]([EstadoProyectoNombre], [EstadoProyectoApellido], [EstadoProyectoDireccion], [EstadoProyectoLugarNacimeinto]) VALUES(@EstadoProyectoNombre, @EstadoProyectoApellido, @EstadoProyectoDireccion, @EstadoProyectoLugarNacimeinto); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00078)
             ,new CursorDef("T00079", "UPDATE [EstadoProyecto] SET [EstadoProyectoNombre]=@EstadoProyectoNombre, [EstadoProyectoApellido]=@EstadoProyectoApellido, [EstadoProyectoDireccion]=@EstadoProyectoDireccion, [EstadoProyectoLugarNacimeinto]=@EstadoProyectoLugarNacimeinto  WHERE [EstadoProyectoID] = @EstadoProyectoID", GxErrorMask.GX_NOMASK,prmT00079)
             ,new CursorDef("T000710", "DELETE FROM [EstadoProyecto]  WHERE [EstadoProyectoID] = @EstadoProyectoID", GxErrorMask.GX_NOMASK,prmT000710)
             ,new CursorDef("T000711", "SELECT [EstadoProyectoID] FROM [EstadoProyecto] ORDER BY [EstadoProyectoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
