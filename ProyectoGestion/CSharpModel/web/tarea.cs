/*
               File: Tarea
        Description: Tarea
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/25/2020 18:0:3.0
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A6TareaPID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n6TareaPID = false;
            AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A6TareaPID) ;
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
            Form.Meta.addItem("description", context.GetMessage( "Tarea", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTareaID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
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
         context.SetDefaultTheme("WorkWithPlusTheme");
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
         cmbTareaEstado = new GXCombobox();
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
         if ( cmbTareaEstado.ItemCount > 0 )
         {
            A29TareaEstado = cmbTareaEstado.getValidValue(A29TareaEstado);
            AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbTareaEstado.CurrentValue = StringUtil.RTrim( A29TareaEstado);
            AssignProp("", false, cmbTareaEstado_Internalname, "Values", cmbTareaEstado.ToJavascriptSource(), true);
         }
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, context.GetMessage( "Tarea", ""), "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Tarea.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", context.GetMessage( "GX_BtnSelect", ""), bttBtn_select_Jsonclick, 5, context.GetMessage( "GX_BtnSelect", ""), "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtTareaID_Internalname, context.GetMessage( "ID", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtTareaID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5TareaID), "ZZZ9")) : context.localUtil.Format( (decimal)(A5TareaID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtTareaName_Internalname, context.GetMessage( "Name", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaName_Internalname, StringUtil.RTrim( A26TareaName), StringUtil.RTrim( context.localUtil.Format( A26TareaName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Name", "left", true, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtTareaVersion_Internalname, context.GetMessage( "Version", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaVersion_Internalname, StringUtil.RTrim( A27TareaVersion), StringUtil.RTrim( context.localUtil.Format( A27TareaVersion, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaVersion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaVersion_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaPrioridad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaPrioridad_Internalname, context.GetMessage( "Prioridad", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaPrioridad_Internalname, StringUtil.RTrim( A28TareaPrioridad), StringUtil.RTrim( context.localUtil.Format( A28TareaPrioridad, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaPrioridad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaPrioridad_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbTareaEstado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, cmbTareaEstado_Internalname, context.GetMessage( "Estado", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
         /* ComboBox */
         GxWebStd.gx_combobox_ctrl1( context, cmbTareaEstado, cmbTareaEstado_Internalname, StringUtil.RTrim( A29TareaEstado), 1, cmbTareaEstado_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbTareaEstado.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,53);\"", "", true, "HLP_Tarea.htm");
         cmbTareaEstado.CurrentValue = StringUtil.RTrim( A29TareaEstado);
         AssignProp("", false, cmbTareaEstado_Internalname, "Values", (String)(cmbTareaEstado.ToJavascriptSource()), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTareaPID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTareaPID_Internalname, context.GetMessage( "Tarea Padre ID", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTareaPID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TareaPID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtTareaPID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6TareaPID), "ZZZ9")) : context.localUtil.Format( (decimal)(A6TareaPID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTareaPID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTareaPID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtTareaDescripcion_Internalname, context.GetMessage( "Descripcion", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtTareaDescripcion_Internalname, A30TareaDescripcion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A30TareaDescripcion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,63);\"", 0, 1, edtTareaDescripcion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Tarea.htm");
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
         GxWebStd.gx_label_element( context, edtTareaObersvacion_Internalname, context.GetMessage( "Obersvacion", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtTareaObersvacion_Internalname, A31TareaObersvacion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A31TareaObersvacion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,68);\"", 0, 1, edtTareaObersvacion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Tarea.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Tarea.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
         ClassString = "BtnBack";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttAtras_Internalname, "", context.GetMessage( "ATRAS", ""), bttAtras_Jsonclick, 7, context.GetMessage( "ATRAS", ""), "", StyleString, ClassString, bttAtras_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11065_client"+"'", TempTags, "", 2, "HLP_Tarea.htm");
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
         E12062 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z5TareaID = (short)(context.localUtil.CToN( cgiGet( "Z5TareaID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z26TareaName = cgiGet( "Z26TareaName");
               Z27TareaVersion = cgiGet( "Z27TareaVersion");
               Z28TareaPrioridad = cgiGet( "Z28TareaPrioridad");
               Z29TareaEstado = cgiGet( "Z29TareaEstado");
               Z30TareaDescripcion = cgiGet( "Z30TareaDescripcion");
               Z31TareaObersvacion = cgiGet( "Z31TareaObersvacion");
               Z6TareaPID = (short)(context.localUtil.CToN( cgiGet( "Z6TareaPID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TAREAID");
                  AnyError = 1;
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A5TareaID = 0;
                  AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
               }
               else
               {
                  A5TareaID = (short)(context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
               }
               A26TareaName = cgiGet( edtTareaName_Internalname);
               AssignAttri("", false, "A26TareaName", A26TareaName);
               A27TareaVersion = cgiGet( edtTareaVersion_Internalname);
               AssignAttri("", false, "A27TareaVersion", A27TareaVersion);
               A28TareaPrioridad = cgiGet( edtTareaPrioridad_Internalname);
               AssignAttri("", false, "A28TareaPrioridad", A28TareaPrioridad);
               cmbTareaEstado.CurrentValue = cgiGet( cmbTareaEstado_Internalname);
               A29TareaEstado = cgiGet( cmbTareaEstado_Internalname);
               AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
               if ( ( ( context.localUtil.CToN( cgiGet( edtTareaPID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTareaPID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TAREAPID");
                  AnyError = 1;
                  GX_FocusControl = edtTareaPID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6TareaPID = 0;
                  n6TareaPID = false;
                  AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
               }
               else
               {
                  A6TareaPID = (short)(context.localUtil.CToN( cgiGet( edtTareaPID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  n6TareaPID = false;
                  AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
               }
               n6TareaPID = ((0==A6TareaPID) ? true : false);
               A30TareaDescripcion = cgiGet( edtTareaDescripcion_Internalname);
               AssignAttri("", false, "A30TareaDescripcion", A30TareaDescripcion);
               A31TareaObersvacion = cgiGet( edtTareaObersvacion_Internalname);
               AssignAttri("", false, "A31TareaObersvacion", A31TareaObersvacion);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  A5TareaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           E12062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E13062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
            E13062 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll065( ) ;
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
         if ( IsIns( ) )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         if ( IsDsp( ) )
         {
            bttBtn_enter_Visible = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
         }
         DisableAttributes065( ) ;
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

      protected void ResetCaption060( )
      {
      }

      protected void E12062( )
      {
         /* Start Routine */
      }

      protected void E13062( )
      {
         /* After Trn Routine */
      }

      protected void ZM065( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z26TareaName = T00063_A26TareaName[0];
               Z27TareaVersion = T00063_A27TareaVersion[0];
               Z28TareaPrioridad = T00063_A28TareaPrioridad[0];
               Z29TareaEstado = T00063_A29TareaEstado[0];
               Z30TareaDescripcion = T00063_A30TareaDescripcion[0];
               Z31TareaObersvacion = T00063_A31TareaObersvacion[0];
               Z6TareaPID = T00063_A6TareaPID[0];
            }
            else
            {
               Z26TareaName = A26TareaName;
               Z27TareaVersion = A27TareaVersion;
               Z28TareaPrioridad = A28TareaPrioridad;
               Z29TareaEstado = A29TareaEstado;
               Z30TareaDescripcion = A30TareaDescripcion;
               Z31TareaObersvacion = A31TareaObersvacion;
               Z6TareaPID = A6TareaPID;
            }
         }
         if ( GX_JID == -1 )
         {
            Z5TareaID = A5TareaID;
            Z26TareaName = A26TareaName;
            Z27TareaVersion = A27TareaVersion;
            Z28TareaPrioridad = A28TareaPrioridad;
            Z29TareaEstado = A29TareaEstado;
            Z30TareaDescripcion = A30TareaDescripcion;
            Z31TareaObersvacion = A31TareaObersvacion;
            Z6TareaPID = A6TareaPID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         }
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

      protected void Load065( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
            A26TareaName = T00065_A26TareaName[0];
            AssignAttri("", false, "A26TareaName", A26TareaName);
            A27TareaVersion = T00065_A27TareaVersion[0];
            AssignAttri("", false, "A27TareaVersion", A27TareaVersion);
            A28TareaPrioridad = T00065_A28TareaPrioridad[0];
            AssignAttri("", false, "A28TareaPrioridad", A28TareaPrioridad);
            A29TareaEstado = T00065_A29TareaEstado[0];
            AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
            A30TareaDescripcion = T00065_A30TareaDescripcion[0];
            AssignAttri("", false, "A30TareaDescripcion", A30TareaDescripcion);
            A31TareaObersvacion = T00065_A31TareaObersvacion[0];
            AssignAttri("", false, "A31TareaObersvacion", A31TareaObersvacion);
            A6TareaPID = T00065_A6TareaPID[0];
            AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
            n6TareaPID = T00065_n6TareaPID[0];
            ZM065( -1) ;
         }
         pr_default.close(3);
         OnLoadActions065( ) ;
      }

      protected void OnLoadActions065( )
      {
      }

      protected void CheckExtendedTable065( )
      {
         nIsDirty_5 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {n6TareaPID, A6TareaPID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A6TareaPID) ) )
            {
               GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea Padre", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "TAREAPID");
               AnyError = 1;
               GX_FocusControl = edtTareaPID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors065( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A6TareaPID )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {n6TareaPID, A6TareaPID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A6TareaPID) ) )
            {
               GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea Padre", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "TAREAPID");
               AnyError = 1;
               GX_FocusControl = edtTareaPID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(4) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(4);
      }

      protected void GetKey065( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM065( 1) ;
            RcdFound5 = 1;
            A5TareaID = T00063_A5TareaID[0];
            AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
            A26TareaName = T00063_A26TareaName[0];
            AssignAttri("", false, "A26TareaName", A26TareaName);
            A27TareaVersion = T00063_A27TareaVersion[0];
            AssignAttri("", false, "A27TareaVersion", A27TareaVersion);
            A28TareaPrioridad = T00063_A28TareaPrioridad[0];
            AssignAttri("", false, "A28TareaPrioridad", A28TareaPrioridad);
            A29TareaEstado = T00063_A29TareaEstado[0];
            AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
            A30TareaDescripcion = T00063_A30TareaDescripcion[0];
            AssignAttri("", false, "A30TareaDescripcion", A30TareaDescripcion);
            A31TareaObersvacion = T00063_A31TareaObersvacion[0];
            AssignAttri("", false, "A31TareaObersvacion", A31TareaObersvacion);
            A6TareaPID = T00063_A6TareaPID[0];
            AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
            n6TareaPID = T00063_n6TareaPID[0];
            Z5TareaID = A5TareaID;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load065( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey065( ) ;
            }
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey065( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey065( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00068_A5TareaID[0] < A5TareaID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00068_A5TareaID[0] > A5TareaID ) ) )
            {
               A5TareaID = T00068_A5TareaID[0];
               AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00069_A5TareaID[0] > A5TareaID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00069_A5TareaID[0] < A5TareaID ) ) )
            {
               A5TareaID = T00069_A5TareaID[0];
               AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey065( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert065( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A5TareaID != Z5TareaID )
               {
                  A5TareaID = Z5TareaID;
                  AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "TAREAID");
                  AnyError = 1;
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update065( ) ;
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A5TareaID != Z5TareaID )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtTareaID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert065( ) ;
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
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtTareaID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert065( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A5TareaID != Z5TareaID )
         {
            A5TareaID = Z5TareaID;
            AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "TAREAID");
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "TAREAID");
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart065( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd065( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_previous( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         move_next( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart065( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext065( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd065( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency065( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A5TareaID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z26TareaName, T00062_A26TareaName[0]) != 0 ) || ( StringUtil.StrCmp(Z27TareaVersion, T00062_A27TareaVersion[0]) != 0 ) || ( StringUtil.StrCmp(Z28TareaPrioridad, T00062_A28TareaPrioridad[0]) != 0 ) || ( StringUtil.StrCmp(Z29TareaEstado, T00062_A29TareaEstado[0]) != 0 ) || ( StringUtil.StrCmp(Z30TareaDescripcion, T00062_A30TareaDescripcion[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z31TareaObersvacion, T00062_A31TareaObersvacion[0]) != 0 ) || ( Z6TareaPID != T00062_A6TareaPID[0] ) )
            {
               if ( StringUtil.StrCmp(Z26TareaName, T00062_A26TareaName[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaName");
                  GXUtil.WriteLogRaw("Old: ",Z26TareaName);
                  GXUtil.WriteLogRaw("Current: ",T00062_A26TareaName[0]);
               }
               if ( StringUtil.StrCmp(Z27TareaVersion, T00062_A27TareaVersion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaVersion");
                  GXUtil.WriteLogRaw("Old: ",Z27TareaVersion);
                  GXUtil.WriteLogRaw("Current: ",T00062_A27TareaVersion[0]);
               }
               if ( StringUtil.StrCmp(Z28TareaPrioridad, T00062_A28TareaPrioridad[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaPrioridad");
                  GXUtil.WriteLogRaw("Old: ",Z28TareaPrioridad);
                  GXUtil.WriteLogRaw("Current: ",T00062_A28TareaPrioridad[0]);
               }
               if ( StringUtil.StrCmp(Z29TareaEstado, T00062_A29TareaEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaEstado");
                  GXUtil.WriteLogRaw("Old: ",Z29TareaEstado);
                  GXUtil.WriteLogRaw("Current: ",T00062_A29TareaEstado[0]);
               }
               if ( StringUtil.StrCmp(Z30TareaDescripcion, T00062_A30TareaDescripcion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaDescripcion");
                  GXUtil.WriteLogRaw("Old: ",Z30TareaDescripcion);
                  GXUtil.WriteLogRaw("Current: ",T00062_A30TareaDescripcion[0]);
               }
               if ( StringUtil.StrCmp(Z31TareaObersvacion, T00062_A31TareaObersvacion[0]) != 0 )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaObersvacion");
                  GXUtil.WriteLogRaw("Old: ",Z31TareaObersvacion);
                  GXUtil.WriteLogRaw("Current: ",T00062_A31TareaObersvacion[0]);
               }
               if ( Z6TareaPID != T00062_A6TareaPID[0] )
               {
                  GXUtil.WriteLog("tarea:[seudo value changed for attri]"+"TareaPID");
                  GXUtil.WriteLogRaw("Old: ",Z6TareaPID);
                  GXUtil.WriteLogRaw("Current: ",T00062_A6TareaPID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Tarea"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert065( )
      {
         BeforeValidate065( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable065( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM065( 0) ;
            CheckOptimisticConcurrency065( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm065( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert065( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {A26TareaName, A27TareaVersion, A28TareaPrioridad, A29TareaEstado, A30TareaDescripcion, A31TareaObersvacion, n6TareaPID, A6TareaPID});
                     A5TareaID = T000610_A5TareaID[0];
                     AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption060( ) ;
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
               Load065( ) ;
            }
            EndLevel065( ) ;
         }
         CloseExtendedTableCursors065( ) ;
      }

      protected void Update065( )
      {
         BeforeValidate065( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable065( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency065( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm065( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate065( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000611 */
                     pr_default.execute(9, new Object[] {A26TareaName, A27TareaVersion, A28TareaPrioridad, A29TareaEstado, A30TareaDescripcion, A31TareaObersvacion, n6TareaPID, A6TareaPID, A5TareaID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Tarea"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate065( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption060( ) ;
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
            EndLevel065( ) ;
         }
         CloseExtendedTableCursors065( ) ;
      }

      protected void DeferredUpdate065( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate065( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency065( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls065( ) ;
            AfterConfirm065( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete065( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000612 */
                  pr_default.execute(10, new Object[] {A5TareaID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Tarea") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound5 == 0 )
                        {
                           InitAll065( ) ;
                           Gx_mode = "INS";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption060( ) ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel065( ) ;
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls065( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000613 */
            pr_default.execute(11, new Object[] {A5TareaID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {context.GetMessage( "Tarea", "")}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor T000614 */
            pr_default.execute(12, new Object[] {A5TareaID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {context.GetMessage( "Tarea", "")}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel065( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete065( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("tarea",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
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

      public void ScanStart065( )
      {
         /* Scan By routine */
         /* Using cursor T000615 */
         pr_default.execute(13);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound5 = 1;
            A5TareaID = T000615_A5TareaID[0];
            AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext065( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound5 = 1;
            A5TareaID = T000615_A5TareaID[0];
            AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
         }
      }

      protected void ScanEnd065( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm065( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert065( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate065( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete065( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete065( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate065( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes065( )
      {
         edtTareaID_Enabled = 0;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), true);
         edtTareaName_Enabled = 0;
         AssignProp("", false, edtTareaName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaName_Enabled), 5, 0), true);
         edtTareaVersion_Enabled = 0;
         AssignProp("", false, edtTareaVersion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaVersion_Enabled), 5, 0), true);
         edtTareaPrioridad_Enabled = 0;
         AssignProp("", false, edtTareaPrioridad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaPrioridad_Enabled), 5, 0), true);
         cmbTareaEstado.Enabled = 0;
         AssignProp("", false, cmbTareaEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(cmbTareaEstado.Enabled), 5, 0), true);
         edtTareaPID_Enabled = 0;
         AssignProp("", false, edtTareaPID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaPID_Enabled), 5, 0), true);
         edtTareaDescripcion_Enabled = 0;
         AssignProp("", false, edtTareaDescripcion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaDescripcion_Enabled), 5, 0), true);
         edtTareaObersvacion_Enabled = 0;
         AssignProp("", false, edtTareaObersvacion_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaObersvacion_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes065( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020825180363", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("tarea.aspx") +"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z5TareaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z26TareaName", StringUtil.RTrim( Z26TareaName));
         GxWebStd.gx_hidden_field( context, "Z27TareaVersion", StringUtil.RTrim( Z27TareaVersion));
         GxWebStd.gx_hidden_field( context, "Z28TareaPrioridad", StringUtil.RTrim( Z28TareaPrioridad));
         GxWebStd.gx_hidden_field( context, "Z29TareaEstado", StringUtil.RTrim( Z29TareaEstado));
         GxWebStd.gx_hidden_field( context, "Z30TareaDescripcion", Z30TareaDescripcion);
         GxWebStd.gx_hidden_field( context, "Z31TareaObersvacion", Z31TareaObersvacion);
         GxWebStd.gx_hidden_field( context, "Z6TareaPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6TareaPID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("tarea.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Tarea" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Tarea", "") ;
      }

      protected void InitializeNonKey065( )
      {
         A26TareaName = "";
         AssignAttri("", false, "A26TareaName", A26TareaName);
         A27TareaVersion = "";
         AssignAttri("", false, "A27TareaVersion", A27TareaVersion);
         A28TareaPrioridad = "";
         AssignAttri("", false, "A28TareaPrioridad", A28TareaPrioridad);
         A29TareaEstado = "";
         AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
         A30TareaDescripcion = "";
         AssignAttri("", false, "A30TareaDescripcion", A30TareaDescripcion);
         A31TareaObersvacion = "";
         AssignAttri("", false, "A31TareaObersvacion", A31TareaObersvacion);
         A6TareaPID = 0;
         n6TareaPID = false;
         AssignAttri("", false, "A6TareaPID", StringUtil.LTrimStr( (decimal)(A6TareaPID), 4, 0));
         n6TareaPID = ((0==A6TareaPID) ? true : false);
         Z26TareaName = "";
         Z27TareaVersion = "";
         Z28TareaPrioridad = "";
         Z29TareaEstado = "";
         Z30TareaDescripcion = "";
         Z31TareaObersvacion = "";
         Z6TareaPID = 0;
      }

      protected void InitAll065( )
      {
         A5TareaID = 0;
         AssignAttri("", false, "A5TareaID", StringUtil.LTrimStr( (decimal)(A5TareaID), 4, 0));
         InitializeNonKey065( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020825180367", true, true);
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
         context.AddJavascriptSource("tarea.js", "?2020825180367", false, true);
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
         cmbTareaEstado_Internalname = "TAREAESTADO";
         edtTareaPID_Internalname = "TAREAPID";
         edtTareaDescripcion_Internalname = "TAREADESCRIPCION";
         edtTareaObersvacion_Internalname = "TAREAOBERSVACION";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         bttAtras_Internalname = "ATRAS";
         divMaintable_Internalname = "MAINTABLE";
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
         Form.Caption = context.GetMessage( "Tarea", "");
         bttAtras_Visible = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtTareaObersvacion_Enabled = 1;
         edtTareaDescripcion_Enabled = 1;
         edtTareaPID_Jsonclick = "";
         edtTareaPID_Enabled = 1;
         cmbTareaEstado_Jsonclick = "";
         cmbTareaEstado.Enabled = 1;
         edtTareaPrioridad_Jsonclick = "";
         edtTareaPrioridad_Enabled = 1;
         edtTareaVersion_Jsonclick = "";
         edtTareaVersion_Enabled = 1;
         edtTareaName_Jsonclick = "";
         edtTareaName_Enabled = 1;
         edtTareaID_Jsonclick = "";
         edtTareaID_Enabled = 1;
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
         cmbTareaEstado.Name = "TAREAESTADO";
         cmbTareaEstado.WebTags = "";
         cmbTareaEstado.addItem("PROGRAMADO", context.GetMessage( "PROGRAMADO", ""), 0);
         cmbTareaEstado.addItem("EN PROCESO", context.GetMessage( "EN PROCESO", ""), 0);
         cmbTareaEstado.addItem("SUSPENDIDO", context.GetMessage( "SUSPENDIO", ""), 0);
         cmbTareaEstado.addItem("CANCELADO", context.GetMessage( "CANCELADO", ""), 0);
         if ( cmbTareaEstado.ItemCount > 0 )
         {
            A29TareaEstado = cmbTareaEstado.getValidValue(A29TareaEstado);
            AssignAttri("", false, "A29TareaEstado", A29TareaEstado);
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtTareaName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
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

      public void Valid_Tareaid( )
      {
         A29TareaEstado = cmbTareaEstado.CurrentValue;
         cmbTareaEstado.CurrentValue = A29TareaEstado;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( cmbTareaEstado.ItemCount > 0 )
         {
            A29TareaEstado = cmbTareaEstado.getValidValue(A29TareaEstado);
            cmbTareaEstado.CurrentValue = A29TareaEstado;
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbTareaEstado.CurrentValue = StringUtil.RTrim( A29TareaEstado);
         }
         /*  Sending validation outputs */
         AssignAttri("", false, "A26TareaName", StringUtil.RTrim( A26TareaName));
         AssignAttri("", false, "A27TareaVersion", StringUtil.RTrim( A27TareaVersion));
         AssignAttri("", false, "A28TareaPrioridad", StringUtil.RTrim( A28TareaPrioridad));
         AssignAttri("", false, "A29TareaEstado", StringUtil.RTrim( A29TareaEstado));
         cmbTareaEstado.CurrentValue = StringUtil.RTrim( A29TareaEstado);
         AssignProp("", false, cmbTareaEstado_Internalname, "Values", cmbTareaEstado.ToJavascriptSource(), true);
         AssignAttri("", false, "A30TareaDescripcion", A30TareaDescripcion);
         AssignAttri("", false, "A31TareaObersvacion", A31TareaObersvacion);
         AssignAttri("", false, "A6TareaPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TareaPID), 4, 0, ".", "")));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z5TareaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5TareaID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z26TareaName", StringUtil.RTrim( Z26TareaName));
         GxWebStd.gx_hidden_field( context, "Z27TareaVersion", StringUtil.RTrim( Z27TareaVersion));
         GxWebStd.gx_hidden_field( context, "Z28TareaPrioridad", StringUtil.RTrim( Z28TareaPrioridad));
         GxWebStd.gx_hidden_field( context, "Z29TareaEstado", StringUtil.RTrim( Z29TareaEstado));
         GxWebStd.gx_hidden_field( context, "Z30TareaDescripcion", Z30TareaDescripcion);
         GxWebStd.gx_hidden_field( context, "Z31TareaObersvacion", Z31TareaObersvacion);
         GxWebStd.gx_hidden_field( context, "Z6TareaPID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6TareaPID), 4, 0, ".", "")));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Tareapid( )
      {
         n6TareaPID = false;
         /* Using cursor T000616 */
         pr_default.execute(14, new Object[] {n6TareaPID, A6TareaPID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A6TareaPID) ) )
            {
               GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea Padre", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "TAREAPID");
               AnyError = 1;
               GX_FocusControl = edtTareaPID_Internalname;
            }
         }
         pr_default.close(14);
         dynload_actions( ) ;
         /*  Sending validation outputs */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E13062',iparms:[]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("'ATRAS'","{handler:'E11065',iparms:[]");
         setEventMetadata("'ATRAS'",",oparms:[]}");
         setEventMetadata("VALID_TAREAID","{handler:'Valid_Tareaid',iparms:[{av:'cmbTareaEstado'},{av:'A29TareaEstado',fld:'TAREAESTADO',pic:''},{av:'A5TareaID',fld:'TAREAID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_TAREAID",",oparms:[{av:'A26TareaName',fld:'TAREANAME',pic:''},{av:'A27TareaVersion',fld:'TAREAVERSION',pic:''},{av:'A28TareaPrioridad',fld:'TAREAPRIORIDAD',pic:''},{av:'cmbTareaEstado'},{av:'A29TareaEstado',fld:'TAREAESTADO',pic:''},{av:'A30TareaDescripcion',fld:'TAREADESCRIPCION',pic:''},{av:'A31TareaObersvacion',fld:'TAREAOBERSVACION',pic:''},{av:'A6TareaPID',fld:'TAREAPID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z5TareaID'},{av:'Z26TareaName'},{av:'Z27TareaVersion'},{av:'Z28TareaPrioridad'},{av:'Z29TareaEstado'},{av:'Z30TareaDescripcion'},{av:'Z31TareaObersvacion'},{av:'Z6TareaPID'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_TAREAPID","{handler:'Valid_Tareapid',iparms:[{av:'A6TareaPID',fld:'TAREAPID',pic:'ZZZ9'}]");
         setEventMetadata("VALID_TAREAPID",",oparms:[]}");
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
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z26TareaName = "";
         Z27TareaVersion = "";
         Z28TareaPrioridad = "";
         Z29TareaEstado = "";
         Z30TareaDescripcion = "";
         Z31TareaObersvacion = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A29TareaEstado = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A26TareaName = "";
         A27TareaVersion = "";
         A28TareaPrioridad = "";
         A30TareaDescripcion = "";
         A31TareaObersvacion = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         bttAtras_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00065_A5TareaID = new short[1] ;
         T00065_A26TareaName = new String[] {""} ;
         T00065_A27TareaVersion = new String[] {""} ;
         T00065_A28TareaPrioridad = new String[] {""} ;
         T00065_A29TareaEstado = new String[] {""} ;
         T00065_A30TareaDescripcion = new String[] {""} ;
         T00065_A31TareaObersvacion = new String[] {""} ;
         T00065_A6TareaPID = new short[1] ;
         T00065_n6TareaPID = new bool[] {false} ;
         T00064_A6TareaPID = new short[1] ;
         T00064_n6TareaPID = new bool[] {false} ;
         T00066_A6TareaPID = new short[1] ;
         T00066_n6TareaPID = new bool[] {false} ;
         T00067_A5TareaID = new short[1] ;
         T00063_A5TareaID = new short[1] ;
         T00063_A26TareaName = new String[] {""} ;
         T00063_A27TareaVersion = new String[] {""} ;
         T00063_A28TareaPrioridad = new String[] {""} ;
         T00063_A29TareaEstado = new String[] {""} ;
         T00063_A30TareaDescripcion = new String[] {""} ;
         T00063_A31TareaObersvacion = new String[] {""} ;
         T00063_A6TareaPID = new short[1] ;
         T00063_n6TareaPID = new bool[] {false} ;
         sMode5 = "";
         T00068_A5TareaID = new short[1] ;
         T00069_A5TareaID = new short[1] ;
         T00062_A5TareaID = new short[1] ;
         T00062_A26TareaName = new String[] {""} ;
         T00062_A27TareaVersion = new String[] {""} ;
         T00062_A28TareaPrioridad = new String[] {""} ;
         T00062_A29TareaEstado = new String[] {""} ;
         T00062_A30TareaDescripcion = new String[] {""} ;
         T00062_A31TareaObersvacion = new String[] {""} ;
         T00062_A6TareaPID = new short[1] ;
         T00062_n6TareaPID = new bool[] {false} ;
         T000610_A5TareaID = new short[1] ;
         T000613_A6TareaPID = new short[1] ;
         T000613_n6TareaPID = new bool[] {false} ;
         T000614_A8GestionProyectID = new short[1] ;
         T000614_A5TareaID = new short[1] ;
         T000615_A5TareaID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ26TareaName = "";
         ZZ27TareaVersion = "";
         ZZ28TareaPrioridad = "";
         ZZ29TareaEstado = "";
         ZZ30TareaDescripcion = "";
         ZZ31TareaObersvacion = "";
         T000616_A6TareaPID = new short[1] ;
         T000616_n6TareaPID = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tarea__default(),
            new Object[][] {
                new Object[] {
               T00062_A5TareaID, T00062_A26TareaName, T00062_A27TareaVersion, T00062_A28TareaPrioridad, T00062_A29TareaEstado, T00062_A30TareaDescripcion, T00062_A31TareaObersvacion, T00062_A6TareaPID, T00062_n6TareaPID
               }
               , new Object[] {
               T00063_A5TareaID, T00063_A26TareaName, T00063_A27TareaVersion, T00063_A28TareaPrioridad, T00063_A29TareaEstado, T00063_A30TareaDescripcion, T00063_A31TareaObersvacion, T00063_A6TareaPID, T00063_n6TareaPID
               }
               , new Object[] {
               T00064_A6TareaPID
               }
               , new Object[] {
               T00065_A5TareaID, T00065_A26TareaName, T00065_A27TareaVersion, T00065_A28TareaPrioridad, T00065_A29TareaEstado, T00065_A30TareaDescripcion, T00065_A31TareaObersvacion, T00065_A6TareaPID, T00065_n6TareaPID
               }
               , new Object[] {
               T00066_A6TareaPID
               }
               , new Object[] {
               T00067_A5TareaID
               }
               , new Object[] {
               T00068_A5TareaID
               }
               , new Object[] {
               T00069_A5TareaID
               }
               , new Object[] {
               T000610_A5TareaID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000613_A6TareaPID
               }
               , new Object[] {
               T000614_A8GestionProyectID, T000614_A5TareaID
               }
               , new Object[] {
               T000615_A5TareaID
               }
               , new Object[] {
               T000616_A6TareaPID
               }
            }
         );
      }

      private short Z5TareaID ;
      private short Z6TareaPID ;
      private short GxWebError ;
      private short A6TareaPID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A5TareaID ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short nIsDirty_5 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ5TareaID ;
      private short ZZ6TareaPID ;
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
      private int edtTareaPID_Enabled ;
      private int edtTareaDescripcion_Enabled ;
      private int edtTareaObersvacion_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttAtras_Visible ;
      private int idxLst ;
      private String sPrefix ;
      private String Z26TareaName ;
      private String Z27TareaVersion ;
      private String Z28TareaPrioridad ;
      private String Z29TareaEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTareaID_Internalname ;
      private String A29TareaEstado ;
      private String cmbTareaEstado_Internalname ;
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
      private String edtTareaID_Jsonclick ;
      private String edtTareaName_Internalname ;
      private String A26TareaName ;
      private String edtTareaName_Jsonclick ;
      private String edtTareaVersion_Internalname ;
      private String A27TareaVersion ;
      private String edtTareaVersion_Jsonclick ;
      private String edtTareaPrioridad_Internalname ;
      private String A28TareaPrioridad ;
      private String edtTareaPrioridad_Jsonclick ;
      private String cmbTareaEstado_Jsonclick ;
      private String edtTareaPID_Internalname ;
      private String edtTareaPID_Jsonclick ;
      private String edtTareaDescripcion_Internalname ;
      private String edtTareaObersvacion_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttAtras_Internalname ;
      private String bttAtras_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode5 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String ZZ26TareaName ;
      private String ZZ27TareaVersion ;
      private String ZZ28TareaPrioridad ;
      private String ZZ29TareaEstado ;
      private bool entryPointCalled ;
      private bool n6TareaPID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String Z30TareaDescripcion ;
      private String Z31TareaObersvacion ;
      private String A30TareaDescripcion ;
      private String A31TareaObersvacion ;
      private String ZZ30TareaDescripcion ;
      private String ZZ31TareaObersvacion ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTareaEstado ;
      private IDataStoreProvider pr_default ;
      private short[] T00065_A5TareaID ;
      private String[] T00065_A26TareaName ;
      private String[] T00065_A27TareaVersion ;
      private String[] T00065_A28TareaPrioridad ;
      private String[] T00065_A29TareaEstado ;
      private String[] T00065_A30TareaDescripcion ;
      private String[] T00065_A31TareaObersvacion ;
      private short[] T00065_A6TareaPID ;
      private bool[] T00065_n6TareaPID ;
      private short[] T00064_A6TareaPID ;
      private bool[] T00064_n6TareaPID ;
      private short[] T00066_A6TareaPID ;
      private bool[] T00066_n6TareaPID ;
      private short[] T00067_A5TareaID ;
      private short[] T00063_A5TareaID ;
      private String[] T00063_A26TareaName ;
      private String[] T00063_A27TareaVersion ;
      private String[] T00063_A28TareaPrioridad ;
      private String[] T00063_A29TareaEstado ;
      private String[] T00063_A30TareaDescripcion ;
      private String[] T00063_A31TareaObersvacion ;
      private short[] T00063_A6TareaPID ;
      private bool[] T00063_n6TareaPID ;
      private short[] T00068_A5TareaID ;
      private short[] T00069_A5TareaID ;
      private short[] T00062_A5TareaID ;
      private String[] T00062_A26TareaName ;
      private String[] T00062_A27TareaVersion ;
      private String[] T00062_A28TareaPrioridad ;
      private String[] T00062_A29TareaEstado ;
      private String[] T00062_A30TareaDescripcion ;
      private String[] T00062_A31TareaObersvacion ;
      private short[] T00062_A6TareaPID ;
      private bool[] T00062_n6TareaPID ;
      private short[] T000610_A5TareaID ;
      private short[] T000613_A6TareaPID ;
      private bool[] T000613_n6TareaPID ;
      private short[] T000614_A8GestionProyectID ;
      private short[] T000614_A5TareaID ;
      private short[] T000615_A5TareaID ;
      private short[] T000616_A6TareaPID ;
      private bool[] T000616_n6TareaPID ;
      private GXWebForm Form ;
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@TareaPID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@TareaPID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@TareaName",SqlDbType.NChar,40,0} ,
          new Object[] {"@TareaVersion",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaPrioridad",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaEstado",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaDescripcion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaObersvacion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaPID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@TareaName",SqlDbType.NChar,40,0} ,
          new Object[] {"@TareaVersion",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaPrioridad",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaEstado",SqlDbType.NChar,20,0} ,
          new Object[] {"@TareaDescripcion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaObersvacion",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@TareaPID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@TareaPID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [TareaID], [TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion], [TareaPID] AS TareaPID FROM [Tarea] WITH (UPDLOCK) WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00063", "SELECT [TareaID], [TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion], [TareaPID] AS TareaPID FROM [Tarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00064", "SELECT [TareaID] AS TareaPID FROM [Tarea] WHERE [TareaID] = @TareaPID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00065", "SELECT TM1.[TareaID], TM1.[TareaName], TM1.[TareaVersion], TM1.[TareaPrioridad], TM1.[TareaEstado], TM1.[TareaDescripcion], TM1.[TareaObersvacion], TM1.[TareaPID] AS TareaPID FROM [Tarea] TM1 WHERE TM1.[TareaID] = @TareaID ORDER BY TM1.[TareaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00066", "SELECT [TareaID] AS TareaPID FROM [Tarea] WHERE [TareaID] = @TareaPID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00067", "SELECT [TareaID] FROM [Tarea] WHERE [TareaID] = @TareaID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00068", "SELECT TOP 1 [TareaID] FROM [Tarea] WHERE ( [TareaID] > @TareaID) ORDER BY [TareaID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00069", "SELECT TOP 1 [TareaID] FROM [Tarea] WHERE ( [TareaID] < @TareaID) ORDER BY [TareaID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000610", "INSERT INTO [Tarea]([TareaName], [TareaVersion], [TareaPrioridad], [TareaEstado], [TareaDescripcion], [TareaObersvacion], [TareaPID]) VALUES(@TareaName, @TareaVersion, @TareaPrioridad, @TareaEstado, @TareaDescripcion, @TareaObersvacion, @TareaPID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000610)
             ,new CursorDef("T000611", "UPDATE [Tarea] SET [TareaName]=@TareaName, [TareaVersion]=@TareaVersion, [TareaPrioridad]=@TareaPrioridad, [TareaEstado]=@TareaEstado, [TareaDescripcion]=@TareaDescripcion, [TareaObersvacion]=@TareaObersvacion, [TareaPID]=@TareaPID  WHERE [TareaID] = @TareaID", GxErrorMask.GX_NOMASK,prmT000611)
             ,new CursorDef("T000612", "DELETE FROM [Tarea]  WHERE [TareaID] = @TareaID", GxErrorMask.GX_NOMASK,prmT000612)
             ,new CursorDef("T000613", "SELECT TOP 1 [TareaID] AS TareaPID FROM [Tarea] WHERE [TareaPID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000614", "SELECT TOP 1 [GestionProyectID], [TareaID] FROM [GestionProyectTarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000615", "SELECT [TareaID] FROM [Tarea] ORDER BY [TareaID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000616", "SELECT [TareaID] AS TareaPID FROM [Tarea] WHERE [TareaID] = @TareaPID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,1, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
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
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[7]);
                }
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[7]);
                }
                stmt.SetParameter(8, (short)parms[8]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
       }
    }

 }

}
