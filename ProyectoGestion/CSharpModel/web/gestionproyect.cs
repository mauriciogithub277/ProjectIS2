/*
               File: GestionProyect
        Description: Gestion Proyect
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:53.63
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
   public class gestionproyect : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A4ProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A4ProyectoID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A5TareaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A5TareaID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridgestionproyect_tarea") == 0 )
         {
            nRC_GXsfl_53 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_53_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_53_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridgestionproyect_tarea_newrow( ) ;
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
            Form.Meta.addItem("description", context.GetMessage( "Gestion Proyect", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtGestionProyectID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public gestionproyect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gestionproyect( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, context.GetMessage( "Gestion Proyect", ""), "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GestionProyect.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", context.GetMessage( "GX_BtnSelect", ""), bttBtn_select_Jsonclick, 5, context.GetMessage( "GX_BtnSelect", ""), "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_GestionProyect.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtGestionProyectID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtGestionProyectID_Internalname, context.GetMessage( "Proyect ID", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtGestionProyectID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8GestionProyectID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtGestionProyectID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8GestionProyectID), "ZZZ9")) : context.localUtil.Format( (decimal)(A8GestionProyectID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtGestionProyectID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtGestionProyectID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoID_Internalname, context.GetMessage( "Proyecto ID", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtProyectoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4ProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtProyectoID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4ProyectoID), "ZZZ9")) : context.localUtil.Format( (decimal)(A4ProyectoID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoName_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoName_Internalname, context.GetMessage( "Proyecto Name", ""), "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtProyectoName_Internalname, StringUtil.RTrim( A20ProyectoName), StringUtil.RTrim( context.localUtil.Format( A20ProyectoName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "NameProyect", "left", true, "", "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTareatable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitletarea_Internalname, context.GetMessage( "Tarea", ""), "", "", lblTitletarea_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridgestionproyect_tarea( ) ;
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
         ClassString = "BtnBack";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttVolver_Internalname, "", context.GetMessage( "VOLVER", ""), bttVolver_Jsonclick, 7, context.GetMessage( "VOLVER", ""), "", StyleString, ClassString, bttVolver_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11047_client"+"'", TempTags, "", 2, "HLP_GestionProyect.htm");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridgestionproyect_tarea( )
      {
         /*  Grid Control  */
         Gridgestionproyect_tareaContainer.AddObjectProperty("GridName", "Gridgestionproyect_tarea");
         Gridgestionproyect_tareaContainer.AddObjectProperty("Header", subGridgestionproyect_tarea_Header);
         Gridgestionproyect_tareaContainer.AddObjectProperty("Class", "Grid");
         Gridgestionproyect_tareaContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Backcolorstyle), 1, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("CmpContext", "");
         Gridgestionproyect_tareaContainer.AddObjectProperty("InMasterPage", "false");
         Gridgestionproyect_tareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridgestionproyect_tareaColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TareaID), 4, 0, ".", "")));
         Gridgestionproyect_tareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaID_Enabled), 5, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddColumnProperties(Gridgestionproyect_tareaColumn);
         Gridgestionproyect_tareaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridgestionproyect_tareaColumn.AddObjectProperty("Value", StringUtil.RTrim( A26TareaName));
         Gridgestionproyect_tareaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaName_Enabled), 5, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddColumnProperties(Gridgestionproyect_tareaColumn);
         Gridgestionproyect_tareaContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Selectedindex), 4, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Allowselection), 1, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Selectioncolor), 9, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Allowhovering), 1, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Hoveringcolor), 9, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Allowcollapsing), 1, 0, ".", "")));
         Gridgestionproyect_tareaContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridgestionproyect_tarea_Collapsed), 1, 0, ".", "")));
         nGXsfl_53_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount8 = 4;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_8 = 1;
               ScanStart048( ) ;
               while ( RcdFound8 != 0 )
               {
                  init_level_properties8( ) ;
                  getByPrimaryKey048( ) ;
                  AddRow048( ) ;
                  ScanNext048( ) ;
               }
               ScanEnd048( ) ;
               nBlankRcdCount8 = 4;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            sMode8 = Gx_mode;
            while ( nGXsfl_53_idx < nRC_GXsfl_53 )
            {
               bGXsfl_53_Refreshing = true;
               ReadRow048( ) ;
               edtTareaID_Enabled = (int)(context.localUtil.CToN( cgiGet( "TAREAID_"+sGXsfl_53_idx+"Enabled"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               edtTareaName_Enabled = (int)(context.localUtil.CToN( cgiGet( "TAREANAME_"+sGXsfl_53_idx+"Enabled"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignProp("", false, edtTareaName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaName_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               if ( ( nRcdExists_8 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  standaloneModal048( ) ;
               }
               SendRow048( ) ;
               bGXsfl_53_Refreshing = false;
            }
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount8 = 4;
            nRcdExists_8 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart048( ) ;
               while ( RcdFound8 != 0 )
               {
                  sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_538( ) ;
                  init_level_properties8( ) ;
                  standaloneNotModal048( ) ;
                  getByPrimaryKey048( ) ;
                  standaloneModal048( ) ;
                  AddRow048( ) ;
                  ScanNext048( ) ;
               }
               ScanEnd048( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode8 = Gx_mode;
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
         SubsflControlProps_538( ) ;
         InitAll048( ) ;
         init_level_properties8( ) ;
         nRcdExists_8 = 0;
         nIsMod_8 = 0;
         nRcdDeleted_8 = 0;
         nBlankRcdCount8 = (short)(nBlankRcdUsr8+nBlankRcdCount8);
         fRowAdded = 0;
         while ( nBlankRcdCount8 > 0 )
         {
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            AddRow048( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtTareaID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount8 = (short)(nBlankRcdCount8-1);
         }
         Gx_mode = sMode8;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridgestionproyect_tareaContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridgestionproyect_tarea", Gridgestionproyect_tareaContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridgestionproyect_tareaContainerData", Gridgestionproyect_tareaContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridgestionproyect_tareaContainerData"+"V", Gridgestionproyect_tareaContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridgestionproyect_tareaContainerData"+"V"+"\" value='"+Gridgestionproyect_tareaContainer.GridValuesHidden()+"'/>") ;
         }
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z8GestionProyectID = (short)(context.localUtil.CToN( cgiGet( "Z8GestionProyectID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Z4ProyectoID = (short)(context.localUtil.CToN( cgiGet( "Z4ProyectoID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Gx_mode = cgiGet( "Mode");
            nRC_GXsfl_53 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            Gx_mode = cgiGet( "vMODE");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtGestionProyectID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtGestionProyectID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "GESTIONPROYECTID");
               AnyError = 1;
               GX_FocusControl = edtGestionProyectID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A8GestionProyectID = 0;
               AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
            }
            else
            {
               A8GestionProyectID = (short)(context.localUtil.CToN( cgiGet( edtGestionProyectID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROYECTOID");
               AnyError = 1;
               GX_FocusControl = edtProyectoID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A4ProyectoID = 0;
               AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
            }
            else
            {
               A4ProyectoID = (short)(context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
            }
            A20ProyectoName = cgiGet( edtProyectoName_Internalname);
            AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            standaloneNotModal( ) ;
         }
         else
         {
            standaloneNotModal( ) ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
            {
               Gx_mode = "DSP";
               AssignAttri("", false, "Gx_mode", Gx_mode);
               A8GestionProyectID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll047( ) ;
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
         DisableAttributes047( ) ;
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

      protected void CONFIRM_048( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow048( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               GetKey048( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate048( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable048( ) ;
                        CloseExtendedTableCursors048( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "TAREAID_" + sGXsfl_53_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtTareaID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( nRcdDeleted_8 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey048( ) ;
                        Load048( ) ;
                        BeforeValidate048( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls048( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate048( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable048( ) ;
                              CloseExtendedTableCursors048( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "TAREAID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtTareaID_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTareaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( edtTareaName_Internalname, StringUtil.RTrim( A26TareaName)) ;
            ChangePostValue( "ZT_"+"Z5TareaID_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "TAREAID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TAREANAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaName_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void ZM047( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z4ProyectoID = T00046_A4ProyectoID[0];
            }
            else
            {
               Z4ProyectoID = A4ProyectoID;
            }
         }
         if ( GX_JID == -1 )
         {
            Z8GestionProyectID = A8GestionProyectID;
            Z4ProyectoID = A4ProyectoID;
            Z20ProyectoName = A20ProyectoName;
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

      protected void Load047( )
      {
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A8GestionProyectID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound7 = 1;
            A20ProyectoName = T00048_A20ProyectoName[0];
            AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
            A4ProyectoID = T00048_A4ProyectoID[0];
            AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
            ZM047( -1) ;
         }
         pr_default.close(6);
         OnLoadActions047( ) ;
      }

      protected void OnLoadActions047( )
      {
      }

      protected void CheckExtendedTable047( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A4ProyectoID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Proyecto", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "PROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20ProyectoName = T00047_A20ProyectoName[0];
         AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors047( )
      {
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A4ProyectoID )
      {
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A4ProyectoID});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Proyecto", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "PROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20ProyectoName = T00049_A20ProyectoName[0];
         AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A20ProyectoName))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(7) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(7);
      }

      protected void GetKey047( )
      {
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A8GestionProyectID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A8GestionProyectID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM047( 1) ;
            RcdFound7 = 1;
            A8GestionProyectID = T00046_A8GestionProyectID[0];
            AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
            A4ProyectoID = T00046_A4ProyectoID[0];
            AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
            Z8GestionProyectID = A8GestionProyectID;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load047( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey047( ) ;
            }
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey047( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey047( ) ;
         if ( RcdFound7 == 0 )
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
         RcdFound7 = 0;
         /* Using cursor T000411 */
         pr_default.execute(9, new Object[] {A8GestionProyectID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000411_A8GestionProyectID[0] < A8GestionProyectID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000411_A8GestionProyectID[0] > A8GestionProyectID ) ) )
            {
               A8GestionProyectID = T000411_A8GestionProyectID[0];
               AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000412 */
         pr_default.execute(10, new Object[] {A8GestionProyectID});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000412_A8GestionProyectID[0] > A8GestionProyectID ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000412_A8GestionProyectID[0] < A8GestionProyectID ) ) )
            {
               A8GestionProyectID = T000412_A8GestionProyectID[0];
               AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(10);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey047( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtGestionProyectID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert047( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A8GestionProyectID != Z8GestionProyectID )
               {
                  A8GestionProyectID = Z8GestionProyectID;
                  AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "GESTIONPROYECTID");
                  AnyError = 1;
                  GX_FocusControl = edtGestionProyectID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtGestionProyectID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update047( ) ;
                  GX_FocusControl = edtGestionProyectID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A8GestionProyectID != Z8GestionProyectID )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtGestionProyectID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert047( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "GESTIONPROYECTID");
                     AnyError = 1;
                     GX_FocusControl = edtGestionProyectID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtGestionProyectID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert047( ) ;
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
         if ( A8GestionProyectID != Z8GestionProyectID )
         {
            A8GestionProyectID = Z8GestionProyectID;
            AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "GESTIONPROYECTID");
            AnyError = 1;
            GX_FocusControl = edtGestionProyectID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtGestionProyectID_Internalname;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "GESTIONPROYECTID");
            AnyError = 1;
            GX_FocusControl = edtGestionProyectID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtProyectoID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart047( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd047( ) ;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoID_Internalname;
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
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoID_Internalname;
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
         ScanStart047( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound7 != 0 )
            {
               ScanNext047( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd047( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency047( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00045 */
            pr_default.execute(3, new Object[] {A8GestionProyectID});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GestionProyect"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z4ProyectoID != T00045_A4ProyectoID[0] ) )
            {
               if ( Z4ProyectoID != T00045_A4ProyectoID[0] )
               {
                  GXUtil.WriteLog("gestionproyect:[seudo value changed for attri]"+"ProyectoID");
                  GXUtil.WriteLogRaw("Old: ",Z4ProyectoID);
                  GXUtil.WriteLogRaw("Current: ",T00045_A4ProyectoID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"GestionProyect"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM047( 0) ;
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000413 */
                     pr_default.execute(11, new Object[] {A4ProyectoID});
                     A8GestionProyectID = T000413_A8GestionProyectID[0];
                     AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("GestionProyect") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel047( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption040( ) ;
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
            else
            {
               Load047( ) ;
            }
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void Update047( )
      {
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable047( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000414 */
                     pr_default.execute(12, new Object[] {A4ProyectoID, A8GestionProyectID});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("GestionProyect") ;
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GestionProyect"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate047( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel047( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption040( ) ;
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
            EndLevel047( ) ;
         }
         CloseExtendedTableCursors047( ) ;
      }

      protected void DeferredUpdate047( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate047( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency047( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls047( ) ;
            AfterConfirm047( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete047( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart048( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     getByPrimaryKey048( ) ;
                     Delete048( ) ;
                     ScanNext048( ) ;
                  }
                  ScanEnd048( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000415 */
                     pr_default.execute(13, new Object[] {A8GestionProyectID});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("GestionProyect") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound7 == 0 )
                           {
                              InitAll047( ) ;
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
                           ResetCaption040( ) ;
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
         }
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel047( ) ;
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls047( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000416 */
            pr_default.execute(14, new Object[] {A4ProyectoID});
            A20ProyectoName = T000416_A20ProyectoName[0];
            AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel048( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow048( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               standaloneNotModal048( ) ;
               GetKey048( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  Insert048( ) ;
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( ( nRcdDeleted_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        Delete048( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           Update048( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "TAREAID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtTareaID_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTareaID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( edtTareaName_Internalname, StringUtil.RTrim( A26TareaName)) ;
            ChangePostValue( "ZT_"+"Z5TareaID_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, context.GetLanguageProperty( "decimal_point"), ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "TAREAID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TAREANAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaName_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll048( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_8 = 0;
         nIsMod_8 = 0;
         nRcdDeleted_8 = 0;
      }

      protected void ProcessLevel047( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode;
         ProcessNestedLevel048( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel047( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete047( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            pr_default.close(2);
            context.CommitDataStores("gestionproyect",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(14);
            pr_default.close(2);
            context.RollbackDataStores("gestionproyect",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart047( )
      {
         /* Using cursor T000417 */
         pr_default.execute(15);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound7 = 1;
            A8GestionProyectID = T000417_A8GestionProyectID[0];
            AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext047( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound7 = 1;
            A8GestionProyectID = T000417_A8GestionProyectID[0];
            AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
         }
      }

      protected void ScanEnd047( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm047( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert047( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate047( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete047( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete047( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate047( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes047( )
      {
         edtGestionProyectID_Enabled = 0;
         AssignProp("", false, edtGestionProyectID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtGestionProyectID_Enabled), 5, 0), true);
         edtProyectoID_Enabled = 0;
         AssignProp("", false, edtProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoID_Enabled), 5, 0), true);
         edtProyectoName_Enabled = 0;
         AssignProp("", false, edtProyectoName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoName_Enabled), 5, 0), true);
      }

      protected void ZM048( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -3 )
         {
            Z8GestionProyectID = A8GestionProyectID;
            Z5TareaID = A5TareaID;
            Z26TareaName = A26TareaName;
         }
      }

      protected void standaloneNotModal048( )
      {
      }

      protected void standaloneModal048( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTareaID_Enabled = 0;
            AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
         else
         {
            edtTareaID_Enabled = 1;
            AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
      }

      protected void Load048( )
      {
         /* Using cursor T000418 */
         pr_default.execute(16, new Object[] {A8GestionProyectID, A5TareaID});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound8 = 1;
            A26TareaName = T000418_A26TareaName[0];
            ZM048( -3) ;
         }
         pr_default.close(16);
         OnLoadActions048( ) ;
      }

      protected void OnLoadActions048( )
      {
      }

      protected void CheckExtendedTable048( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         standaloneModal048( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "TAREAID_" + sGXsfl_53_idx;
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26TareaName = T00044_A26TareaName[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors048( )
      {
         pr_default.close(2);
      }

      protected void enableDisable048( )
      {
      }

      protected void gxLoad_4( short A5TareaID )
      {
         /* Using cursor T000419 */
         pr_default.execute(17, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GXCCtl = "TAREAID_" + sGXsfl_53_idx;
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A26TareaName = T000419_A26TareaName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A26TareaName))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(17) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(17);
      }

      protected void GetKey048( )
      {
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A8GestionProyectID, A5TareaID});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey048( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A8GestionProyectID, A5TareaID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM048( 3) ;
            RcdFound8 = 1;
            InitializeNonKey048( ) ;
            A5TareaID = T00043_A5TareaID[0];
            Z8GestionProyectID = A8GestionProyectID;
            Z5TareaID = A5TareaID;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal048( ) ;
            Load048( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey048( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal048( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes048( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency048( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A8GestionProyectID, A5TareaID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"GestionProyectTarea"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"GestionProyectTarea"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert048( )
      {
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable048( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM048( 0) ;
            CheckOptimisticConcurrency048( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm048( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert048( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000421 */
                     pr_default.execute(19, new Object[] {A8GestionProyectID, A5TareaID});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("GestionProyectTarea") ;
                     if ( (pr_default.getStatus(19) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
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
               Load048( ) ;
            }
            EndLevel048( ) ;
         }
         CloseExtendedTableCursors048( ) ;
      }

      protected void Update048( )
      {
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable048( ) ;
         }
         if ( ( nIsMod_8 != 0 ) || ( nIsDirty_8 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency048( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm048( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate048( ) ;
                     if ( AnyError == 0 )
                     {
                        /* No attributes to update on table [GestionProyectTarea] */
                        DeferredUpdate048( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey048( ) ;
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
               EndLevel048( ) ;
            }
         }
         CloseExtendedTableCursors048( ) ;
      }

      protected void DeferredUpdate048( )
      {
      }

      protected void Delete048( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency048( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls048( ) ;
            AfterConfirm048( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete048( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000422 */
                  pr_default.execute(20, new Object[] {A8GestionProyectID, A5TareaID});
                  pr_default.close(20);
                  dsDefault.SmartCacheProvider.SetUpdated("GestionProyectTarea") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
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
         EndLevel048( ) ;
         Gx_mode = sMode8;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls048( )
      {
         standaloneModal048( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000423 */
            pr_default.execute(21, new Object[] {A5TareaID});
            A26TareaName = T000423_A26TareaName[0];
            pr_default.close(21);
         }
      }

      protected void EndLevel048( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart048( )
      {
         /* Scan By routine */
         /* Using cursor T000424 */
         pr_default.execute(22, new Object[] {A8GestionProyectID});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound8 = 1;
            A5TareaID = T000424_A5TareaID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext048( )
      {
         /* Scan next routine */
         pr_default.readNext(22);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound8 = 1;
            A5TareaID = T000424_A5TareaID[0];
         }
      }

      protected void ScanEnd048( )
      {
         pr_default.close(22);
      }

      protected void AfterConfirm048( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert048( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate048( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete048( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete048( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate048( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes048( )
      {
         edtTareaID_Enabled = 0;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         edtTareaName_Enabled = 0;
         AssignProp("", false, edtTareaName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaName_Enabled), 5, 0), !bGXsfl_53_Refreshing);
      }

      protected void send_integrity_lvl_hashes048( )
      {
      }

      protected void send_integrity_lvl_hashes047( )
      {
      }

      protected void SubsflControlProps_538( )
      {
         edtTareaID_Internalname = "TAREAID_"+sGXsfl_53_idx;
         edtTareaName_Internalname = "TAREANAME_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_538( )
      {
         edtTareaID_Internalname = "TAREAID_"+sGXsfl_53_fel_idx;
         edtTareaName_Internalname = "TAREANAME_"+sGXsfl_53_fel_idx;
      }

      protected void AddRow048( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_538( ) ;
         SendRow048( ) ;
      }

      protected void SendRow048( )
      {
         Gridgestionproyect_tareaRow = GXWebRow.GetNew(context);
         if ( subGridgestionproyect_tarea_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridgestionproyect_tarea_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridgestionproyect_tarea_Class, "") != 0 )
            {
               subGridgestionproyect_tarea_Linesclass = subGridgestionproyect_tarea_Class+"Odd";
            }
         }
         else if ( subGridgestionproyect_tarea_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridgestionproyect_tarea_Backstyle = 0;
            subGridgestionproyect_tarea_Backcolor = subGridgestionproyect_tarea_Allbackcolor;
            if ( StringUtil.StrCmp(subGridgestionproyect_tarea_Class, "") != 0 )
            {
               subGridgestionproyect_tarea_Linesclass = subGridgestionproyect_tarea_Class+"Uniform";
            }
         }
         else if ( subGridgestionproyect_tarea_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridgestionproyect_tarea_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridgestionproyect_tarea_Class, "") != 0 )
            {
               subGridgestionproyect_tarea_Linesclass = subGridgestionproyect_tarea_Class+"Odd";
            }
            subGridgestionproyect_tarea_Backcolor = (int)(0x0);
         }
         else if ( subGridgestionproyect_tarea_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridgestionproyect_tarea_Backstyle = 1;
            if ( ((int)((nGXsfl_53_idx) % (2))) == 0 )
            {
               subGridgestionproyect_tarea_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridgestionproyect_tarea_Class, "") != 0 )
               {
                  subGridgestionproyect_tarea_Linesclass = subGridgestionproyect_tarea_Class+"Even";
               }
            }
            else
            {
               subGridgestionproyect_tarea_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridgestionproyect_tarea_Class, "") != 0 )
               {
                  subGridgestionproyect_tarea_Linesclass = subGridgestionproyect_tarea_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridgestionproyect_tareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTareaID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A5TareaID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(this,54);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTareaID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTareaID_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridgestionproyect_tareaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTareaName_Internalname,StringUtil.RTrim( A26TareaName),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTareaName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtTareaName_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"Name",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridgestionproyect_tareaRow);
         send_integrity_lvl_hashes048( ) ;
         GXCCtl = "Z5TareaID_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5TareaID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GXCCtl = "nIsMod_8_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "TAREAID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAREANAME_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTareaName_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridgestionproyect_tareaContainer.AddRow(Gridgestionproyect_tareaRow);
      }

      protected void ReadRow048( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_538( ) ;
         edtTareaID_Enabled = (int)(context.localUtil.CToN( cgiGet( "TAREAID_"+sGXsfl_53_idx+"Enabled"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         edtTareaName_Enabled = (int)(context.localUtil.CToN( cgiGet( "TAREANAME_"+sGXsfl_53_idx+"Enabled"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         if ( ( ( context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "TAREAID_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
            wbErr = true;
            A5TareaID = 0;
         }
         else
         {
            A5TareaID = (short)(context.localUtil.CToN( cgiGet( edtTareaID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         }
         A26TareaName = cgiGet( edtTareaName_Internalname);
         GXCCtl = "Z5TareaID_" + sGXsfl_53_idx;
         Z5TareaID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_53_idx;
         nRcdDeleted_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_53_idx;
         nRcdExists_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         GXCCtl = "nIsMod_8_" + sGXsfl_53_idx;
         nIsMod_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
      }

      protected void assign_properties_default( )
      {
         defedtTareaID_Enabled = edtTareaID_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_53_idx = 0;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_538( ) ;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_538( ) ;
            ChangePostValue( "Z5TareaID_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z5TareaID_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z5TareaID_"+sGXsfl_53_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?202082421275438", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gestionproyect.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z8GestionProyectID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8GestionProyectID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z4ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4ProyectoID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_53_idx), 8, 0, context.GetLanguageProperty( "decimal_point"), "")));
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
         return formatLink("gestionproyect.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GestionProyect" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Gestion Proyect", "") ;
      }

      protected void InitializeNonKey047( )
      {
         A4ProyectoID = 0;
         AssignAttri("", false, "A4ProyectoID", StringUtil.LTrimStr( (decimal)(A4ProyectoID), 4, 0));
         A20ProyectoName = "";
         AssignAttri("", false, "A20ProyectoName", A20ProyectoName);
         Z4ProyectoID = 0;
      }

      protected void InitAll047( )
      {
         A8GestionProyectID = 0;
         AssignAttri("", false, "A8GestionProyectID", StringUtil.LTrimStr( (decimal)(A8GestionProyectID), 4, 0));
         InitializeNonKey047( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey048( )
      {
         A26TareaName = "";
      }

      protected void InitAll048( )
      {
         A5TareaID = 0;
         InitializeNonKey048( ) ;
      }

      protected void StandaloneModalInsert048( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082421275441", true, true);
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
         context.AddJavascriptSource("gestionproyect.js", "?202082421275442", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties8( )
      {
         edtTareaID_Enabled = defedtTareaID_Enabled;
         AssignProp("", false, edtTareaID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTareaID_Enabled), 5, 0), !bGXsfl_53_Refreshing);
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
         edtGestionProyectID_Internalname = "GESTIONPROYECTID";
         edtProyectoID_Internalname = "PROYECTOID";
         edtProyectoName_Internalname = "PROYECTONAME";
         lblTitletarea_Internalname = "TITLETAREA";
         edtTareaID_Internalname = "TAREAID";
         edtTareaName_Internalname = "TAREANAME";
         divTareatable_Internalname = "TAREATABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         bttVolver_Internalname = "VOLVER";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridgestionproyect_tarea_Internalname = "GRIDGESTIONPROYECT_TAREA";
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
         Form.Caption = context.GetMessage( "Gestion Proyect", "");
         edtTareaName_Jsonclick = "";
         edtTareaID_Jsonclick = "";
         subGridgestionproyect_tarea_Class = "Grid";
         subGridgestionproyect_tarea_Backcolorstyle = 0;
         subGridgestionproyect_tarea_Allowcollapsing = 0;
         subGridgestionproyect_tarea_Allowselection = 0;
         edtTareaName_Enabled = 0;
         edtTareaID_Enabled = 1;
         subGridgestionproyect_tarea_Header = "";
         bttVolver_Visible = 1;
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtProyectoName_Jsonclick = "";
         edtProyectoName_Enabled = 0;
         edtProyectoID_Jsonclick = "";
         edtProyectoID_Enabled = 1;
         edtGestionProyectID_Jsonclick = "";
         edtGestionProyectID_Enabled = 1;
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

      protected void gxnrGridgestionproyect_tarea_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_538( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow048( ) ;
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_538( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridgestionproyect_tareaContainer)) ;
         /* End function gxnrGridgestionproyect_tarea_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtProyectoID_Internalname;
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

      public void Valid_Gestionproyectid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A4ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4ProyectoID), 4, 0, ".", "")));
         AssignAttri("", false, "A20ProyectoName", StringUtil.RTrim( A20ProyectoName));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z8GestionProyectID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8GestionProyectID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4ProyectoID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z20ProyectoName", StringUtil.RTrim( Z20ProyectoName));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
      }

      public void Valid_Proyectoid( )
      {
         /* Using cursor T000416 */
         pr_default.execute(14, new Object[] {A4ProyectoID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Proyecto", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "PROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtProyectoID_Internalname;
         }
         A20ProyectoName = T000416_A20ProyectoName[0];
         pr_default.close(14);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A20ProyectoName", StringUtil.RTrim( A20ProyectoName));
      }

      public void Valid_Tareaid( )
      {
         /* Using cursor T000423 */
         pr_default.execute(21, new Object[] {A5TareaID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Tarea", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "TAREAID");
            AnyError = 1;
            GX_FocusControl = edtTareaID_Internalname;
         }
         A26TareaName = T000423_A26TareaName[0];
         pr_default.close(21);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A26TareaName", StringUtil.RTrim( A26TareaName));
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
         setEventMetadata("'VOLVER'","{handler:'E11047',iparms:[]");
         setEventMetadata("'VOLVER'",",oparms:[]}");
         setEventMetadata("VALID_GESTIONPROYECTID","{handler:'Valid_Gestionproyectid',iparms:[{av:'A8GestionProyectID',fld:'GESTIONPROYECTID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_GESTIONPROYECTID",",oparms:[{av:'A4ProyectoID',fld:'PROYECTOID',pic:'ZZZ9'},{av:'A20ProyectoName',fld:'PROYECTONAME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z8GestionProyectID'},{av:'Z4ProyectoID'},{av:'Z20ProyectoName'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_PROYECTOID","{handler:'Valid_Proyectoid',iparms:[{av:'A4ProyectoID',fld:'PROYECTOID',pic:'ZZZ9'},{av:'A20ProyectoName',fld:'PROYECTONAME',pic:''}]");
         setEventMetadata("VALID_PROYECTOID",",oparms:[{av:'A20ProyectoName',fld:'PROYECTONAME',pic:''}]}");
         setEventMetadata("VALID_TAREAID","{handler:'Valid_Tareaid',iparms:[{av:'A5TareaID',fld:'TAREAID',pic:'ZZZ9'},{av:'A26TareaName',fld:'TAREANAME',pic:''}]");
         setEventMetadata("VALID_TAREAID",",oparms:[{av:'A26TareaName',fld:'TAREANAME',pic:''}]}");
         setEventMetadata("NULL","{handler:'Valid_Tareaname',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
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
         pr_default.close(21);
         pr_default.close(4);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A20ProyectoName = "";
         lblTitletarea_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         bttVolver_Jsonclick = "";
         Gridgestionproyect_tareaContainer = new GXWebGrid( context);
         Gridgestionproyect_tareaColumn = new GXWebColumn();
         A26TareaName = "";
         sMode8 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z20ProyectoName = "";
         T00048_A8GestionProyectID = new short[1] ;
         T00048_A20ProyectoName = new String[] {""} ;
         T00048_A4ProyectoID = new short[1] ;
         T00047_A20ProyectoName = new String[] {""} ;
         T00049_A20ProyectoName = new String[] {""} ;
         T000410_A8GestionProyectID = new short[1] ;
         T00046_A8GestionProyectID = new short[1] ;
         T00046_A4ProyectoID = new short[1] ;
         sMode7 = "";
         T000411_A8GestionProyectID = new short[1] ;
         T000412_A8GestionProyectID = new short[1] ;
         T00045_A8GestionProyectID = new short[1] ;
         T00045_A4ProyectoID = new short[1] ;
         T000413_A8GestionProyectID = new short[1] ;
         T000416_A20ProyectoName = new String[] {""} ;
         T000417_A8GestionProyectID = new short[1] ;
         Z26TareaName = "";
         T000418_A8GestionProyectID = new short[1] ;
         T000418_A26TareaName = new String[] {""} ;
         T000418_A5TareaID = new short[1] ;
         T00044_A26TareaName = new String[] {""} ;
         T000419_A26TareaName = new String[] {""} ;
         T000420_A8GestionProyectID = new short[1] ;
         T000420_A5TareaID = new short[1] ;
         T00043_A8GestionProyectID = new short[1] ;
         T00043_A5TareaID = new short[1] ;
         T00042_A8GestionProyectID = new short[1] ;
         T00042_A5TareaID = new short[1] ;
         T000423_A26TareaName = new String[] {""} ;
         T000424_A8GestionProyectID = new short[1] ;
         T000424_A5TareaID = new short[1] ;
         Gridgestionproyect_tareaRow = new GXWebRow();
         subGridgestionproyect_tarea_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ20ProyectoName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gestionproyect__default(),
            new Object[][] {
                new Object[] {
               T00042_A8GestionProyectID, T00042_A5TareaID
               }
               , new Object[] {
               T00043_A8GestionProyectID, T00043_A5TareaID
               }
               , new Object[] {
               T00044_A26TareaName
               }
               , new Object[] {
               T00045_A8GestionProyectID, T00045_A4ProyectoID
               }
               , new Object[] {
               T00046_A8GestionProyectID, T00046_A4ProyectoID
               }
               , new Object[] {
               T00047_A20ProyectoName
               }
               , new Object[] {
               T00048_A8GestionProyectID, T00048_A20ProyectoName, T00048_A4ProyectoID
               }
               , new Object[] {
               T00049_A20ProyectoName
               }
               , new Object[] {
               T000410_A8GestionProyectID
               }
               , new Object[] {
               T000411_A8GestionProyectID
               }
               , new Object[] {
               T000412_A8GestionProyectID
               }
               , new Object[] {
               T000413_A8GestionProyectID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000416_A20ProyectoName
               }
               , new Object[] {
               T000417_A8GestionProyectID
               }
               , new Object[] {
               T000418_A8GestionProyectID, T000418_A26TareaName, T000418_A5TareaID
               }
               , new Object[] {
               T000419_A26TareaName
               }
               , new Object[] {
               T000420_A8GestionProyectID, T000420_A5TareaID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000423_A26TareaName
               }
               , new Object[] {
               T000424_A8GestionProyectID, T000424_A5TareaID
               }
            }
         );
      }

      private short Z8GestionProyectID ;
      private short Z4ProyectoID ;
      private short Z5TareaID ;
      private short nRcdDeleted_8 ;
      private short nRcdExists_8 ;
      private short nIsMod_8 ;
      private short GxWebError ;
      private short A4ProyectoID ;
      private short A5TareaID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A8GestionProyectID ;
      private short subGridgestionproyect_tarea_Backcolorstyle ;
      private short subGridgestionproyect_tarea_Allowselection ;
      private short subGridgestionproyect_tarea_Allowhovering ;
      private short subGridgestionproyect_tarea_Allowcollapsing ;
      private short subGridgestionproyect_tarea_Collapsed ;
      private short nBlankRcdCount8 ;
      private short RcdFound8 ;
      private short nBlankRcdUsr8 ;
      private short GX_JID ;
      private short RcdFound7 ;
      private short nIsDirty_7 ;
      private short Gx_BScreen ;
      private short nIsDirty_8 ;
      private short subGridgestionproyect_tarea_Backstyle ;
      private short gxajaxcallmode ;
      private short ZZ8GestionProyectID ;
      private short ZZ4ProyectoID ;
      private int nRC_GXsfl_53 ;
      private int nGXsfl_53_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtGestionProyectID_Enabled ;
      private int edtProyectoID_Enabled ;
      private int edtProyectoName_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttVolver_Visible ;
      private int edtTareaID_Enabled ;
      private int edtTareaName_Enabled ;
      private int subGridgestionproyect_tarea_Selectedindex ;
      private int subGridgestionproyect_tarea_Selectioncolor ;
      private int subGridgestionproyect_tarea_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridgestionproyect_tarea_Backcolor ;
      private int subGridgestionproyect_tarea_Allbackcolor ;
      private int defedtTareaID_Enabled ;
      private int idxLst ;
      private long GRIDGESTIONPROYECT_TAREA_nFirstRecordOnPage ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_53_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtGestionProyectID_Internalname ;
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
      private String edtGestionProyectID_Jsonclick ;
      private String edtProyectoID_Internalname ;
      private String edtProyectoID_Jsonclick ;
      private String edtProyectoName_Internalname ;
      private String A20ProyectoName ;
      private String edtProyectoName_Jsonclick ;
      private String divTareatable_Internalname ;
      private String lblTitletarea_Internalname ;
      private String lblTitletarea_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttVolver_Internalname ;
      private String bttVolver_Jsonclick ;
      private String subGridgestionproyect_tarea_Header ;
      private String A26TareaName ;
      private String sMode8 ;
      private String edtTareaID_Internalname ;
      private String edtTareaName_Internalname ;
      private String sStyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z20ProyectoName ;
      private String sMode7 ;
      private String Z26TareaName ;
      private String sGXsfl_53_fel_idx="0001" ;
      private String subGridgestionproyect_tarea_Class ;
      private String subGridgestionproyect_tarea_Linesclass ;
      private String ROClassString ;
      private String edtTareaID_Jsonclick ;
      private String edtTareaName_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridgestionproyect_tarea_Internalname ;
      private String ZZ20ProyectoName ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_53_Refreshing=false ;
      private GXWebGrid Gridgestionproyect_tareaContainer ;
      private GXWebRow Gridgestionproyect_tareaRow ;
      private GXWebColumn Gridgestionproyect_tareaColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00048_A8GestionProyectID ;
      private String[] T00048_A20ProyectoName ;
      private short[] T00048_A4ProyectoID ;
      private String[] T00047_A20ProyectoName ;
      private String[] T00049_A20ProyectoName ;
      private short[] T000410_A8GestionProyectID ;
      private short[] T00046_A8GestionProyectID ;
      private short[] T00046_A4ProyectoID ;
      private short[] T000411_A8GestionProyectID ;
      private short[] T000412_A8GestionProyectID ;
      private short[] T00045_A8GestionProyectID ;
      private short[] T00045_A4ProyectoID ;
      private short[] T000413_A8GestionProyectID ;
      private String[] T000416_A20ProyectoName ;
      private short[] T000417_A8GestionProyectID ;
      private short[] T000418_A8GestionProyectID ;
      private String[] T000418_A26TareaName ;
      private short[] T000418_A5TareaID ;
      private String[] T00044_A26TareaName ;
      private String[] T000419_A26TareaName ;
      private short[] T000420_A8GestionProyectID ;
      private short[] T000420_A5TareaID ;
      private short[] T00043_A8GestionProyectID ;
      private short[] T00043_A5TareaID ;
      private short[] T00042_A8GestionProyectID ;
      private short[] T00042_A5TareaID ;
      private String[] T000423_A26TareaName ;
      private short[] T000424_A8GestionProyectID ;
      private short[] T000424_A5TareaID ;
      private GXWebForm Form ;
   }

   public class gestionproyect__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@GestionProyectID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@TareaID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [GestionProyectID], [TareaID] FROM [GestionProyectTarea] WITH (UPDLOCK) WHERE [GestionProyectID] = @GestionProyectID AND [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00043", "SELECT [GestionProyectID], [TareaID] FROM [GestionProyectTarea] WHERE [GestionProyectID] = @GestionProyectID AND [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00044", "SELECT [TareaName] FROM [Tarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00045", "SELECT [GestionProyectID], [ProyectoID] FROM [GestionProyect] WITH (UPDLOCK) WHERE [GestionProyectID] = @GestionProyectID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00046", "SELECT [GestionProyectID], [ProyectoID] FROM [GestionProyect] WHERE [GestionProyectID] = @GestionProyectID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00047", "SELECT [ProyectoName] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00048", "SELECT TM1.[GestionProyectID], T2.[ProyectoName], TM1.[ProyectoID] FROM ([GestionProyect] TM1 INNER JOIN [Proyecto] T2 ON T2.[ProyectoID] = TM1.[ProyectoID]) WHERE TM1.[GestionProyectID] = @GestionProyectID ORDER BY TM1.[GestionProyectID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00049", "SELECT [ProyectoName] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000410", "SELECT [GestionProyectID] FROM [GestionProyect] WHERE [GestionProyectID] = @GestionProyectID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000411", "SELECT TOP 1 [GestionProyectID] FROM [GestionProyect] WHERE ( [GestionProyectID] > @GestionProyectID) ORDER BY [GestionProyectID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000412", "SELECT TOP 1 [GestionProyectID] FROM [GestionProyect] WHERE ( [GestionProyectID] < @GestionProyectID) ORDER BY [GestionProyectID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000413", "INSERT INTO [GestionProyect]([ProyectoID]) VALUES(@ProyectoID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000413)
             ,new CursorDef("T000414", "UPDATE [GestionProyect] SET [ProyectoID]=@ProyectoID  WHERE [GestionProyectID] = @GestionProyectID", GxErrorMask.GX_NOMASK,prmT000414)
             ,new CursorDef("T000415", "DELETE FROM [GestionProyect]  WHERE [GestionProyectID] = @GestionProyectID", GxErrorMask.GX_NOMASK,prmT000415)
             ,new CursorDef("T000416", "SELECT [ProyectoName] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000417", "SELECT [GestionProyectID] FROM [GestionProyect] ORDER BY [GestionProyectID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000418", "SELECT T1.[GestionProyectID], T2.[TareaName], T1.[TareaID] FROM ([GestionProyectTarea] T1 INNER JOIN [Tarea] T2 ON T2.[TareaID] = T1.[TareaID]) WHERE T1.[GestionProyectID] = @GestionProyectID and T1.[TareaID] = @TareaID ORDER BY T1.[GestionProyectID], T1.[TareaID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000418,5, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000419", "SELECT [TareaName] FROM [Tarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000420", "SELECT [GestionProyectID], [TareaID] FROM [GestionProyectTarea] WHERE [GestionProyectID] = @GestionProyectID AND [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000421", "INSERT INTO [GestionProyectTarea]([GestionProyectID], [TareaID]) VALUES(@GestionProyectID, @TareaID)", GxErrorMask.GX_NOMASK,prmT000421)
             ,new CursorDef("T000422", "DELETE FROM [GestionProyectTarea]  WHERE [GestionProyectID] = @GestionProyectID AND [TareaID] = @TareaID", GxErrorMask.GX_NOMASK,prmT000422)
             ,new CursorDef("T000423", "SELECT [TareaName] FROM [Tarea] WHERE [TareaID] = @TareaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000423,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000424", "SELECT [GestionProyectID], [TareaID] FROM [GestionProyectTarea] WHERE [GestionProyectID] = @GestionProyectID ORDER BY [GestionProyectID], [TareaID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000424,5, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
