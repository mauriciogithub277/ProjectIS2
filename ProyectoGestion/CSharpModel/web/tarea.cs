/*
               File: Tarea
        Description: Tarea
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 3/22/2020 21:2:7.3
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
   public class tarea : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7TareaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7TareaID", StringUtil.LTrimStr( (decimal)(AV7TareaID), 4, 0));
               AssignAttri("", false, "gxhash_vTAREAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7TareaID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Tarea", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public tarea( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tarea( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_TareaID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7TareaID = aP1_TareaID;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Tarea", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Tarea.htm");
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
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtTareaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TareaID), 4, 0, ".", "")), ((edtTareaID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A23TareaID), "ZZZ9")) : context.localUtil.Format( (decimal)(A23TareaID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaName_Internalname, StringUtil.RTrim( A24TareaName), StringUtil.RTrim( context.localUtil.Format( A24TareaName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Name", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaVersion_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaVersion_Internalname, "Version", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaVersion_Internalname, StringUtil.RTrim( A25TareaVersion), StringUtil.RTrim( context.localUtil.Format( A25TareaVersion, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaVersion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaVersion_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaPrioridad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaPrioridad_Internalname, "Prioridad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaPrioridad_Internalname, StringUtil.RTrim( A26TareaPrioridad), StringUtil.RTrim( context.localUtil.Format( A26TareaPrioridad, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaPrioridad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaPrioridad_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaEstado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaEstado_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaEstado_Internalname, StringUtil.RTrim( A27TareaEstado), StringUtil.RTrim( context.localUtil.Format( A27TareaEstado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaEstado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaEstado_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaDescripcion_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaDescripcion_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtTareaDescripcion_Internalname, A28TareaDescripcion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A28TareaDescripcion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,58);\"", 0, 1, edtTareaDescripcion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaObersvacion_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaObersvacion_Internalname, "Obersvacion", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtTareaObersvacion_Internalname, A29TareaObersvacion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A29TareaObersvacion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,63);\"", 0, 1, edtTareaObersvacion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Tarea.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
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
         E11082 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z23TareaID = (short)(context.localUtil.CToN( cgiGet( "Z23TareaID"), ".", ","));
               Z24TareaName = cgiGet( "Z24TareaName");
               Z25TareaVersion = cgiGet( "Z25TareaVersion");
               Z26TareaPrioridad = cgiGet( "Z26TareaPrioridad");
               Z27TareaEstado = cgiGet( "Z27TareaEstado");
               Z28TareaDescripcion = cgiGet( "Z28TareaDescripcion");
               Z29TareaObersvacion = cgiGet( "Z29TareaObersvacion");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7TareaID = (short)(context.localUtil.CToN( cgiGet( "vTAREAID"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               A23TareaID = (short)(context.localUtil.CToN( cgiGet( edtTareaID_Internalname), ".", ","));
               AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
               A24TareaName = cgiGet( edtTareaName_Internalname);
               AssignAttri("", false, "A24TareaName", A24TareaName);
               A25TareaVersion = cgiGet( edtTareaVersion_Internalname);
               AssignAttri("", false, "A25TareaVersion", A25TareaVersion);
               A26TareaPrioridad = cgiGet( edtTareaPrioridad_Internalname);
               AssignAttri("", false, "A26TareaPrioridad", A26TareaPrioridad);
               A27TareaEstado = cgiGet( edtTareaEstado_Internalname);
               AssignAttri("", false, "A27TareaEstado", A27TareaEstado);
               A28TareaDescripcion = cgiGet( edtTareaDescripcion_Internalname);
               AssignAttri("", false, "A28TareaDescripcion", A28TareaDescripcion);
               A29TareaObersvacion = cgiGet( edtTareaObersvacion_Internalname);
               AssignAttri("", false, "A29TareaObersvacion", A29TareaObersvacion);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Tarea");
               A23TareaID = (short)(context.localUtil.CToN( cgiGet( edtTareaID_Internalname), ".", ","));
               AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
               forbiddenHiddens.Add("TareaID", context.localUtil.Format( (decimal)(A23TareaID), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A23TareaID != Z23TareaID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("tarea:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
                  A23TareaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
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
                     sMode8 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode8;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound8 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_080( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "TAREAID");
                        AnyError = 1;
                        GX_FocusControl = edtTareaID_Internalname;
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
                           E11082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12082 ();
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
            E12082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll088( ) ;
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
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         if ( IsDsp( ) || IsDlt( ) )
         {
            bttBtn_delete_Visible = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
            if ( IsDsp( ) )
            {
               bttBtn_enter_Visible = 0;
               AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
            }
            DisableAttributes088( ) ;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls088( ) ;
            }
            else
            {
               CheckExtendedTable088( ) ;
               CloseExtendedTableCursors088( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ProyectoGestion");
      }

      protected void E12082( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwtarea.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM088( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z24TareaName = T00083_A24TareaName[0];
               Z25TareaVersion = T00083_A25TareaVersion[0];
               Z26TareaPrioridad = T00083_A26TareaPrioridad[0];
               Z27TareaEstado = T00083_A27TareaEstado[0];
               Z28TareaDescripcion = T00083_A28TareaDescripcion[0];
               Z29TareaObersvacion = T00083_A29TareaObersvacion[0];
            }
            else
            {
               Z24TareaName = A24TareaName;
               Z25TareaVersion = A25TareaVersion;
               Z26TareaPrioridad = A26TareaPrioridad;
               Z27TareaEstado = A27TareaEstado;
               Z28TareaDescripcion = A28TareaDescripcion;
               Z29TareaObersvacion = A29TareaObersvacion;
            }
         }
         if ( GX_JID == -3 )
         {
            Z23TareaID = A23TareaID;
            Z24TareaName = A24TareaName;
            Z25TareaVersion = A25TareaVersion;
            Z26TareaPrioridad = A26TareaPrioridad;
            Z27TareaEstado = A27TareaEstado;
            Z28TareaDescripcion = A28TareaDescripcion;
            Z29TareaObersvacion = A29TareaObersvacion;
         }
      }

      protected void standaloneNotModal( )
      {
         edtTareaID_Enabled = 0;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), true);
         edtTareaID_Enabled = 0;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7TareaID) )
         {
            A23TareaID = AV7TareaID;
            AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
      }

      protected void Load088( )
      {
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A23TareaID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound8 = 1;
            A24TareaName = T00084_A24TareaName[0];
            AssignAttri("", false, "A24TareaName", A24TareaName);
            A25TareaVersion = T00084_A25TareaVersion[0];
            AssignAttri("", false, "A25TareaVersion", A25TareaVersion);
            A26TareaPrioridad = T00084_A26TareaPrioridad[0];
            AssignAttri("", false, "A26TareaPrioridad", A26TareaPrioridad);
            A27TareaEstado = T00084_A27TareaEstado[0];
            AssignAttri("", false, "A27TareaEstado", A27TareaEstado);
            A28TareaDescripcion = T00084_A28TareaDescripcion[0];
            AssignAttri("", false, "A28TareaDescripcion", A28TareaDescripcion);
            A29TareaObersvacion = T00084_A29TareaObersvacion[0];
            AssignAttri("", false, "A29TareaObersvacion", A29TareaObersvacion);
            ZM088( -3) ;
         }
         pr_default.close(2);
         OnLoadActions088( ) ;
      }

      protected void OnLoadActions088( )
      {
         AV11Pgmname = "Tarea";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable088( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Tarea";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors088( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey088( )
      {
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A23TareaID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A23TareaID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM088( 3) ;
            RcdFound8 = 1;
            A23TareaID = T00083_A23TareaID[0];
            AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
            A24TareaName = T00083_A24TareaName[0];
            AssignAttri("", false, "A24TareaName", A24TareaName);
            A25TareaVersion = T00083_A25TareaVersion[0];
            AssignAttri("", false, "A25TareaVersion", A25TareaVersion);
            A26TareaPrioridad = T00083_A26TareaPrioridad[0];
            AssignAttri("", false, "A26TareaPrioridad", A26TareaPrioridad);
            A27TareaEstado = T00083_A27TareaEstado[0];
            AssignAttri("", false, "A27TareaEstado", A27TareaEstado);
            A28TareaDescripcion = T00083_A28TareaDescripcion[0];
            AssignAttri("", false, "A28TareaDescripcion", A28TareaDescripcion);
            A29TareaObersvacion = T00083_A29TareaObersvacion[0];
            AssignAttri("", false, "A29TareaObersvacion", A29TareaObersvacion);
            Z23TareaID = A23TareaID;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load088( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey088( ) ;
            }
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey088( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey088( ) ;
         if ( RcdFound8 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound8 = 0;
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A23TareaID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00086_A23TareaID[0] < A23TareaID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00086_A23TareaID[0] > A23TareaID ) ) )
            {
               A23TareaID = T00086_A23TareaID[0];
               AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A23TareaID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00087_A23TareaID[0] > A23TareaID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00087_A23TareaID[0] < A23TareaID ) ) )
            {
               A23TareaID = T00087_A23TareaID[0];
               AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey088( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtTareaName_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert088( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A23TareaID != Z23TareaID )
               {
                  A23TareaID = Z23TareaID;
                  AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "TAREAID");
                  AnyError = 1;
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtTareaName_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update088( ) ;
                  GX_FocusControl = edtTareaName_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A23TareaID != Z23TareaID )
               {
                  /* Insert record */
                  GX_FocusControl = edtTareaName_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert088( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "TAREAID");
                     AnyError = 1;
                     GX_FocusControl = edtTareaID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtTareaName_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert088( ) ;
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
         if ( A23TareaID != Z23TareaID )
         {
            A23TareaID = Z23TareaID;
            AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "TAREAID");
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTareaName_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency088( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A23TareaID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z24TareaName, T00082_A24TareaName[0]) != 0 ) || ( StringUtil.StrCmp(Z25TareaVersion, T00082_A25TareaVersion[0]) != 0 ) || ( StringUtil.StrCmp(Z26TareaPrioridad, T00082_A26TareaPrioridad[0]) != 0 ) || ( StringUtil.StrCmp(Z27TareaEstado, T00082_A27TareaEstado[0]) != 0 ) || ( StringUtil.StrCmp(Z28TareaDescripcion, T00082_A28TareaDescripcion[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z29TareaObersvacion, T00082_A29TareaObersvacion[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z24TareaName, T00082_A24TareaName[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaName");
                  GXUtil.WriteLogRaw("Old: ",Z24TareaName);
                  GXUtil.WriteLogRaw("Current: ",T00082_A24TareaName[0]);
               }
               if ( StringUtil.StrCmp(Z25TareaVersion, T00082_A25TareaVersion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaVersion");
                  GXUtil.WriteLogRaw("Old: ",Z25TareaVersion);
                  GXUtil.WriteLogRaw("Current: ",T00082_A25TareaVersion[0]);
               }
               if ( StringUtil.StrCmp(Z26TareaPrioridad, T00082_A26TareaPrioridad[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaPrioridad");
                  GXUtil.WriteLogRaw("Old: ",Z26TareaPrioridad);
                  GXUtil.WriteLogRaw("Current: ",T00082_A26TareaPrioridad[0]);
               }
               if ( StringUtil.StrCmp(Z27TareaEstado, T00082_A27TareaEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaEstado");
                  GXUtil.WriteLogRaw("Old: ",Z27TareaEstado);
                  GXUtil.WriteLogRaw("Current: ",T00082_A27TareaEstado[0]);
               }
               if ( StringUtil.StrCmp(Z28TareaDescripcion, T00082_A28TareaDescripcion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaDescripcion");
                  GXUtil.WriteLogRaw("Old: ",Z28TareaDescripcion);
                  GXUtil.WriteLogRaw("Current: ",T00082_A28TareaDescripcion[0]);
               }
               if ( StringUtil.StrCmp(Z29TareaObersvacion, T00082_A29TareaObersvacion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaObersvacion");
                  GXUtil.WriteLogRaw("Old: ",Z29TareaObersvacion);
                  GXUtil.WriteLogRaw("Current: ",T00082_A29TareaObersvacion[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Tarea"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM088( 0) ;
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00088 */
                     pr_default.execute(6, new Object[] {A24TareaName, A25TareaVersion, A26TareaPrioridad, A27TareaEstado, A28TareaDescripcion, A29TareaObersvacion});
                     A23TareaID = T00088_A23TareaID[0];
                     AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption080( ) ;
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
               Load088( ) ;
            }
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void Update088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00089 */
                     pr_default.execute(7, new Object[] {A24TareaName, A25TareaVersion, A26TareaPrioridad, A27TareaEstado, A28TareaDescripcion, A29TareaObersvacion, A23TareaID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate088( ) ;
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
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void DeferredUpdate088( )
      {
      }

      protected void delete( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls088( ) ;
            AfterConfirm088( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete088( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000810 */
                  pr_default.execute(8, new Object[] {A23TareaID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel088( ) ;
         Gx_mode = sMode8;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls088( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Tarea";
            AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void EndLevel088( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete088( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("tarea",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("tarea",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart088( )
      {
         /* Scan By routine */
         /* Using cursor T000811 */
         pr_default.execute(9);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound8 = 1;
            A23TareaID = T000811_A23TareaID[0];
            AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext088( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound8 = 1;
            A23TareaID = T000811_A23TareaID[0];
            AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
         }
      }

      protected void ScanEnd088( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm088( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert088( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate088( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete088( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete088( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate088( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes088( )
      {
         edtTareaID_Enabled = 0;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), true);
         edtTareaName_Enabled = 0;
         AssignProp("", false, edtTareaName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaName_Enabled), 5, 0), true);
         edtTareaVersion_Enabled = 0;
         AssignProp("", false, edtTareaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaVersion_Enabled), 5, 0), true);
         edtTareaPrioridad_Enabled = 0;
         AssignProp("", false, edtTareaPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaPrioridad_Enabled), 5, 0), true);
         edtTareaEstado_Enabled = 0;
         AssignProp("", false, edtTareaEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaEstado_Enabled), 5, 0), true);
         edtTareaDescripcion_Enabled = 0;
         AssignProp("", false, edtTareaDescripcion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaDescripcion_Enabled), 5, 0), true);
         edtTareaObersvacion_Enabled = 0;
         AssignProp("", false, edtTareaObersvacion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaObersvacion_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes088( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020322212761", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tarea.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7TareaID)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Tarea");
         forbiddenHiddens.Add("TareaID", context.localUtil.Format( (decimal)(A23TareaID), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("tarea:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z23TareaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23TareaID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24TareaName", StringUtil.RTrim( Z24TareaName));
         GxWebStd.gx_hidden_field( context, "Z25TareaVersion", StringUtil.RTrim( Z25TareaVersion));
         GxWebStd.gx_hidden_field( context, "Z26TareaPrioridad", StringUtil.RTrim( Z26TareaPrioridad));
         GxWebStd.gx_hidden_field( context, "Z27TareaEstado", StringUtil.RTrim( Z27TareaEstado));
         GxWebStd.gx_hidden_field( context, "Z28TareaDescripcion", Z28TareaDescripcion);
         GxWebStd.gx_hidden_field( context, "Z29TareaObersvacion", Z29TareaObersvacion);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vTAREAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TareaID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vTAREAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7TareaID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         return formatLink("tarea.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7TareaID) ;
      }

      public override String GetPgmname( )
      {
         return "Tarea" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tarea" ;
      }

      protected void InitializeNonKey088( )
      {
         A24TareaName = "";
         AssignAttri("", false, "A24TareaName", A24TareaName);
         A25TareaVersion = "";
         AssignAttri("", false, "A25TareaVersion", A25TareaVersion);
         A26TareaPrioridad = "";
         AssignAttri("", false, "A26TareaPrioridad", A26TareaPrioridad);
         A27TareaEstado = "";
         AssignAttri("", false, "A27TareaEstado", A27TareaEstado);
         A28TareaDescripcion = "";
         AssignAttri("", false, "A28TareaDescripcion", A28TareaDescripcion);
         A29TareaObersvacion = "";
         AssignAttri("", false, "A29TareaObersvacion", A29TareaObersvacion);
         Z24TareaName = "";
         Z25TareaVersion = "";
         Z26TareaPrioridad = "";
         Z27TareaEstado = "";
         Z28TareaDescripcion = "";
         Z29TareaObersvacion = "";
      }

      protected void InitAll088( )
      {
         A23TareaID = 0;
         AssignAttri("", false, "A23TareaID", StringUtil.LTrimStr( (decimal)(A23TareaID), 4, 0));
         InitializeNonKey088( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020322212767", true, true);
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
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("tarea.js", "?2020322212767", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtTareaID_Internalname = "TAREAID";
         edtTareaName_Internalname = "TAREANAME";
         edtTareaVersion_Internalname = "TAREAVERSION";
         edtTareaPrioridad_Internalname = "TAREAPRIORIDAD";
         edtTareaEstado_Internalname = "TAREAESTADO";
         edtTareaDescripcion_Internalname = "TAREADESCRIPCION";
         edtTareaObersvacion_Internalname = "TAREAOBERSVACION";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Tarea";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtTareaObersvacion_Enabled = 1;
         edtTareaDescripcion_Enabled = 1;
         edtTareaEstado_Jsonclick = "";
         edtTareaEstado_Enabled = 1;
         edtTareaPrioridad_Jsonclick = "";
         edtTareaPrioridad_Enabled = 1;
         edtTareaVersion_Jsonclick = "";
         edtTareaVersion_Enabled = 1;
         edtTareaName_Jsonclick = "";
         edtTareaName_Enabled = 1;
         edtTareaID_Jsonclick = "";
         edtTareaID_Enabled = 0;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7TareaID',fld:'vTAREAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7TareaID',fld:'vTAREAID',pic:'ZZZ9',hsh:true},{av:'A23TareaID',fld:'TAREAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12082',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_TAREAID","{handler:'Valid_Tareaid',iparms:[]");
         setEventMetadata("VALID_TAREAID",",oparms:[]}");
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
         Z24TareaName = "";
         Z25TareaVersion = "";
         Z26TareaPrioridad = "";
         Z27TareaEstado = "";
         Z28TareaDescripcion = "";
         Z29TareaObersvacion = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A24TareaName = "";
         A25TareaVersion = "";
         A26TareaPrioridad = "";
         A27TareaEstado = "";
         A28TareaDescripcion = "";
         A29TareaObersvacion = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV11Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode8 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00084_A23TareaID = new short[1] ;
         T00084_A24TareaName = new String[] {""} ;
         T00084_A25TareaVersion = new String[] {""} ;
         T00084_A26TareaPrioridad = new String[] {""} ;
         T00084_A27TareaEstado = new String[] {""} ;
         T00084_A28TareaDescripcion = new String[] {""} ;
         T00084_A29TareaObersvacion = new String[] {""} ;
         T00085_A23TareaID = new short[1] ;
         T00083_A23TareaID = new short[1] ;
         T00083_A24TareaName = new String[] {""} ;
         T00083_A25TareaVersion = new String[] {""} ;
         T00083_A26TareaPrioridad = new String[] {""} ;
         T00083_A27TareaEstado = new String[] {""} ;
         T00083_A28TareaDescripcion = new String[] {""} ;
         T00083_A29TareaObersvacion = new String[] {""} ;
         T00086_A23TareaID = new short[1] ;
         T00087_A23TareaID = new short[1] ;
         T00082_A23TareaID = new short[1] ;
         T00082_A24TareaName = new String[] {""} ;
         T00082_A25TareaVersion = new String[] {""} ;
         T00082_A26TareaPrioridad = new String[] {""} ;
         T00082_A27TareaEstado = new String[] {""} ;
         T00082_A28TareaDescripcion = new String[] {""} ;
         T00082_A29TareaObersvacion = new String[] {""} ;
         T00088_A23TareaID = new short[1] ;
         T000811_A23TareaID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tarea__default(),
            new Object[][] {
                new Object[] {
               T00082_A23TareaID, T00082_A24TareaName, T00082_A25TareaVersion, T00082_A26TareaPrioridad, T00082_A27TareaEstado, T00082_A28TareaDescripcion, T00082_A29TareaObersvacion
               }
               , new Object[] {
               T00083_A23TareaID, T00083_A24TareaName, T00083_A25TareaVersion, T00083_A26TareaPrioridad, T00083_A27TareaEstado, T00083_A28TareaDescripcion, T00083_A29TareaObersvacion
               }
               , new Object[] {
               T00084_A23TareaID, T00084_A24TareaName, T00084_A25TareaVersion, T00084_A26TareaPrioridad, T00084_A27TareaEstado, T00084_A28TareaDescripcion, T00084_A29TareaObersvacion
               }
               , new Object[] {
               T00085_A23TareaID
               }
               , new Object[] {
               T00086_A23TareaID
               }
               , new Object[] {
               T00087_A23TareaID
               }
               , new Object[] {
               T00088_A23TareaID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000811_A23TareaID
               }
            }
         );
         AV11Pgmname = "Tarea";
      }

      private short wcpOAV7TareaID ;
      private short Z23TareaID ;
      private short GxWebError ;
      private short AV7TareaID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A23TareaID ;
      private short RcdFound8 ;
      private short GX_JID ;
      private short nIsDirty_8 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtTareaID_Enabled ;
      private int edtTareaName_Enabled ;
      private int edtTareaVersion_Enabled ;
      private int edtTareaPrioridad_Enabled ;
      private int edtTareaEstado_Enabled ;
      private int edtTareaDescripcion_Enabled ;
      private int edtTareaObersvacion_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z24TareaName ;
      private String Z25TareaVersion ;
      private String Z26TareaPrioridad ;
      private String Z27TareaEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTareaName_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtTareaID_Internalname ;
      private String edtTareaID_Jsonclick ;
      private String A24TareaName ;
      private String edtTareaName_Jsonclick ;
      private String edtTareaVersion_Internalname ;
      private String A25TareaVersion ;
      private String edtTareaVersion_Jsonclick ;
      private String edtTareaPrioridad_Internalname ;
      private String A26TareaPrioridad ;
      private String edtTareaPrioridad_Jsonclick ;
      private String edtTareaEstado_Internalname ;
      private String A27TareaEstado ;
      private String edtTareaEstado_Jsonclick ;
      private String edtTareaDescripcion_Internalname ;
      private String edtTareaObersvacion_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV11Pgmname ;
      private String hsh ;
      private String sMode8 ;
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
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z28TareaDescripcion ;
      private String Z29TareaObersvacion ;
      private String A28TareaDescripcion ;
      private String A29TareaObersvacion ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00084_A23TareaID ;
      private String[] T00084_A24TareaName ;
      private String[] T00084_A25TareaVersion ;
      private String[] T00084_A26TareaPrioridad ;
      private String[] T00084_A27TareaEstado ;
      private String[] T00084_A28TareaDescripcion ;
      private String[] T00084_A29TareaObersvacion ;
      private short[] T00085_A23TareaID ;
      private short[] T00083_A23TareaID ;
      private String[] T00083_A24TareaName ;
      private String[] T00083_A25TareaVersion ;
      private String[] T00083_A26TareaPrioridad ;
      private String[] T00083_A27TareaEstado ;
      private String[] T00083_A28TareaDescripcion ;
      private String[] T00083_A29TareaObersvacion ;
      private short[] T00086_A23TareaID ;
      private short[] T00087_A23TareaID ;
      private short[] T00082_A23TareaID ;
      private String[] T00082_A24TareaName ;
      private String[] T00082_A25TareaVersion ;
      private String[] T00082_A26TareaPrioridad ;
      private String[] T00082_A27TareaEstado ;
      private String[] T00082_A28TareaDescripcion ;
      private String[] T00082_A29TareaObersvacion ;
      private short[] T00088_A23TareaID ;
      private short[] T000811_A23TareaID ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class tarea__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@TareaName",SqlDbType.NChar,40,0} ,
          new Object[] {"@TareaVersion",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaPrioridad",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaEstado",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaDescripcion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaObersvacion",SqlDbType.NVarChar,1024,0}
          } ;
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          new Object[] {"@TareaName",SqlDbType.NChar,40,0} ,
          new Object[] {"@TareaVersion",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaPrioridad",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaEstado",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaDescripcion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaObersvacion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [TareaID], [TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion] FROM [Tarea] WITH (UPDLOCK) WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00083", "SELECT [TareaID], [TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion] FROM [Tarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00084", "SELECT TM1.[TareaID], TM1.[TareaName], TM1.[TareaVersion], TM1.[TareaPrioridad], TM1.[TareaEstado], TM1.[TareaDescripcion], TM1.[TareaObersvacion] FROM [Tarea] TM1 WHERE TM1.[TareaID] = @TareaID ORDER BY TM1.[TareaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00085", "SELECT [TareaID] FROM [Tarea] WHERE [TareaID] = @TareaID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00086", "SELECT TOP 1 [TareaID] FROM [Tarea] WHERE ( [TareaID] > @TareaID) ORDER BY [TareaID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00087", "SELECT TOP 1 [TareaID] FROM [Tarea] WHERE ( [TareaID] < @TareaID) ORDER BY [TareaID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00088", "INSERT INTO [Tarea]([TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion]) VALUES(@TareaName, @TareaVersion, @TareaPrioridad, @TareaEstado, @TareaDescripcion, @TareaObersvacion); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00088)
             ,new CursorDef("T00089", "UPDATE [Tarea] SET [TareaName]=@TareaName, [TareaVersion]=@TareaVersion, [TareaPrioridad]=@TareaPrioridad, [TareaEstado]=@TareaEstado, [TareaDescripcion]=@TareaDescripcion, [TareaObersvacion]=@TareaObersvacion  WHERE [TareaID] = @TareaID", GxErrorMask.GX_NOMASK,prmT00089)
             ,new CursorDef("T000810", "DELETE FROM [Tarea]  WHERE [TareaID] = @TareaID", GxErrorMask.GX_NOMASK,prmT000810)
             ,new CursorDef("T000811", "SELECT [TareaID] FROM [Tarea] ORDER BY [TareaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
