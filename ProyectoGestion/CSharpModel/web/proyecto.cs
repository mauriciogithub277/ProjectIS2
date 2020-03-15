/*
               File: Proyecto
        Description: Proyecto
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 3/14/2020 11:13:34.11
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
   public class proyecto : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "Proyecto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtProyectoID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public proyecto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public proyecto( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Proyecto", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Proyecto.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PROYECTOID"+"'), id:'"+"PROYECTOID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Proyecto.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtProyectoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16ProyectoID), 4, 0, ".", "")), ((edtProyectoID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9")) : context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_Proyecto.htm");
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
         GxWebStd.gx_label_element( context, edtProyectoName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtProyectoName_Internalname, StringUtil.RTrim( A17ProyectoName), StringUtil.RTrim( context.localUtil.Format( A17ProyectoName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoName_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "Name", "left", true, "", "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoFecInicio_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoFecInicio_Internalname, "Fec Inicio", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtProyectoFecInicio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtProyectoFecInicio_Internalname, context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"), context.localUtil.Format( A18ProyectoFecInicio, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoFecInicio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoFecInicio_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
         GxWebStd.gx_bitmap( context, edtProyectoFecInicio_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtProyectoFecInicio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Proyecto.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoFecFin_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoFecFin_Internalname, "Fec Fin", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtProyectoFecFin_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtProyectoFecFin_Internalname, context.localUtil.Format(A19ProyectoFecFin, "99/99/99"), context.localUtil.Format( A19ProyectoFecFin, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoFecFin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoFecFin_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
         GxWebStd.gx_bitmap( context, edtProyectoFecFin_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtProyectoFecFin_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Proyecto.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoEstado_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoEstado_Internalname, "Estado", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtProyectoEstado_Internalname, StringUtil.RTrim( A20ProyectoEstado), StringUtil.RTrim( context.localUtil.Format( A20ProyectoEstado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoEstado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoEstado_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "Estado", "left", true, "", "HLP_Proyecto.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            Z16ProyectoID = (short)(context.localUtil.CToN( cgiGet( "Z16ProyectoID"), ".", ","));
            Z17ProyectoName = cgiGet( "Z17ProyectoName");
            Z18ProyectoFecInicio = context.localUtil.CToD( cgiGet( "Z18ProyectoFecInicio"), 0);
            Z19ProyectoFecFin = context.localUtil.CToD( cgiGet( "Z19ProyectoFecFin"), 0);
            Z20ProyectoEstado = cgiGet( "Z20ProyectoEstado");
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            Gx_mode = cgiGet( "vMODE");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROYECTOID");
               AnyError = 1;
               GX_FocusControl = edtProyectoID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A16ProyectoID = 0;
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
            }
            else
            {
               A16ProyectoID = (short)(context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), ".", ","));
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
            }
            A17ProyectoName = cgiGet( edtProyectoName_Internalname);
            AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
            if ( context.localUtil.VCDate( cgiGet( edtProyectoFecInicio_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Proyecto Fec Inicio"}), 1, "PROYECTOFECINICIO");
               AnyError = 1;
               GX_FocusControl = edtProyectoFecInicio_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A18ProyectoFecInicio = DateTime.MinValue;
               AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            }
            else
            {
               A18ProyectoFecInicio = context.localUtil.CToD( cgiGet( edtProyectoFecInicio_Internalname), 1);
               AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtProyectoFecFin_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Proyecto Fec Fin"}), 1, "PROYECTOFECFIN");
               AnyError = 1;
               GX_FocusControl = edtProyectoFecFin_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A19ProyectoFecFin = DateTime.MinValue;
               AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            }
            else
            {
               A19ProyectoFecFin = context.localUtil.CToD( cgiGet( edtProyectoFecFin_Internalname), 1);
               AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            }
            A20ProyectoEstado = cgiGet( edtProyectoEstado_Internalname);
            AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
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
               A16ProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
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
               InitAll077( ) ;
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
         DisableAttributes077( ) ;
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

      protected void ResetCaption070( )
      {
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z17ProyectoName = T00073_A17ProyectoName[0];
               Z18ProyectoFecInicio = T00073_A18ProyectoFecInicio[0];
               Z19ProyectoFecFin = T00073_A19ProyectoFecFin[0];
               Z20ProyectoEstado = T00073_A20ProyectoEstado[0];
            }
            else
            {
               Z17ProyectoName = A17ProyectoName;
               Z18ProyectoFecInicio = A18ProyectoFecInicio;
               Z19ProyectoFecFin = A19ProyectoFecFin;
               Z20ProyectoEstado = A20ProyectoEstado;
            }
         }
         if ( GX_JID == -3 )
         {
            Z16ProyectoID = A16ProyectoID;
            Z17ProyectoName = A17ProyectoName;
            Z18ProyectoFecInicio = A18ProyectoFecInicio;
            Z19ProyectoFecFin = A19ProyectoFecFin;
            Z20ProyectoEstado = A20ProyectoEstado;
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

      protected void Load077( )
      {
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A16ProyectoID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound7 = 1;
            A17ProyectoName = T00074_A17ProyectoName[0];
            AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
            A18ProyectoFecInicio = T00074_A18ProyectoFecInicio[0];
            AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            A19ProyectoFecFin = T00074_A19ProyectoFecFin[0];
            AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            A20ProyectoEstado = T00074_A20ProyectoEstado[0];
            AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
            ZM077( -3) ;
         }
         pr_default.close(2);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
      }

      protected void CheckExtendedTable077( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A18ProyectoFecInicio) || ( A18ProyectoFecInicio >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Proyecto Fec Inicio is out of range", "OutOfRange", 1, "PROYECTOFECINICIO");
            AnyError = 1;
            GX_FocusControl = edtProyectoFecInicio_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A19ProyectoFecFin) || ( A19ProyectoFecFin >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Proyecto Fec Fin is out of range", "OutOfRange", 1, "PROYECTOFECFIN");
            AnyError = 1;
            GX_FocusControl = edtProyectoFecFin_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors077( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey077( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A16ProyectoID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A16ProyectoID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM077( 3) ;
            RcdFound7 = 1;
            A16ProyectoID = T00073_A16ProyectoID[0];
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
            A17ProyectoName = T00073_A17ProyectoName[0];
            AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
            A18ProyectoFecInicio = T00073_A18ProyectoFecInicio[0];
            AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            A19ProyectoFecFin = T00073_A19ProyectoFecFin[0];
            AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            A20ProyectoEstado = T00073_A20ProyectoEstado[0];
            AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
            Z16ProyectoID = A16ProyectoID;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
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
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A16ProyectoID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00076_A16ProyectoID[0] < A16ProyectoID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00076_A16ProyectoID[0] > A16ProyectoID ) ) )
            {
               A16ProyectoID = T00076_A16ProyectoID[0];
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A16ProyectoID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00077_A16ProyectoID[0] > A16ProyectoID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00077_A16ProyectoID[0] < A16ProyectoID ) ) )
            {
               A16ProyectoID = T00077_A16ProyectoID[0];
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey077( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert077( ) ;
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
               if ( A16ProyectoID != Z16ProyectoID )
               {
                  A16ProyectoID = Z16ProyectoID;
                  AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PROYECTOID");
                  AnyError = 1;
                  GX_FocusControl = edtProyectoID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtProyectoID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update077( ) ;
                  GX_FocusControl = edtProyectoID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A16ProyectoID != Z16ProyectoID )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtProyectoID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert077( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PROYECTOID");
                     AnyError = 1;
                     GX_FocusControl = edtProyectoID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtProyectoID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert077( ) ;
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
         if ( A16ProyectoID != Z16ProyectoID )
         {
            A16ProyectoID = Z16ProyectoID;
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtProyectoID_Internalname;
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
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PROYECTOID");
            AnyError = 1;
            GX_FocusControl = edtProyectoID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtProyectoName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd077( ) ;
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
         GX_FocusControl = edtProyectoName_Internalname;
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
         GX_FocusControl = edtProyectoName_Internalname;
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
         ScanStart077( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound7 != 0 )
            {
               ScanNext077( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtProyectoName_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd077( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency077( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A16ProyectoID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proyecto"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z17ProyectoName, T00072_A17ProyectoName[0]) != 0 ) || ( Z18ProyectoFecInicio != T00072_A18ProyectoFecInicio[0] ) || ( Z19ProyectoFecFin != T00072_A19ProyectoFecFin[0] ) || ( StringUtil.StrCmp(Z20ProyectoEstado, T00072_A20ProyectoEstado[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z17ProyectoName, T00072_A17ProyectoName[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoName");
                  GXUtil.WriteLogRaw("Old: ",Z17ProyectoName);
                  GXUtil.WriteLogRaw("Current: ",T00072_A17ProyectoName[0]);
               }
               if ( Z18ProyectoFecInicio != T00072_A18ProyectoFecInicio[0] )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoFecInicio");
                  GXUtil.WriteLogRaw("Old: ",Z18ProyectoFecInicio);
                  GXUtil.WriteLogRaw("Current: ",T00072_A18ProyectoFecInicio[0]);
               }
               if ( Z19ProyectoFecFin != T00072_A19ProyectoFecFin[0] )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoFecFin");
                  GXUtil.WriteLogRaw("Old: ",Z19ProyectoFecFin);
                  GXUtil.WriteLogRaw("Current: ",T00072_A19ProyectoFecFin[0]);
               }
               if ( StringUtil.StrCmp(Z20ProyectoEstado, T00072_A20ProyectoEstado[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoEstado");
                  GXUtil.WriteLogRaw("Old: ",Z20ProyectoEstado);
                  GXUtil.WriteLogRaw("Current: ",T00072_A20ProyectoEstado[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Proyecto"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM077( 0) ;
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00078 */
                     pr_default.execute(6, new Object[] {A17ProyectoName, A18ProyectoFecInicio, A19ProyectoFecFin, A20ProyectoEstado});
                     A16ProyectoID = T00078_A16ProyectoID[0];
                     AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
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
               Load077( ) ;
            }
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void Update077( )
      {
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable077( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm077( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate077( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00079 */
                     pr_default.execute(7, new Object[] {A17ProyectoName, A18ProyectoFecInicio, A19ProyectoFecFin, A20ProyectoEstado, A16ProyectoID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Proyecto"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate077( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption070( ) ;
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
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency077( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls077( ) ;
            AfterConfirm077( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete077( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000710 */
                  pr_default.execute(8, new Object[] {A16ProyectoID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Proyecto") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound7 == 0 )
                        {
                           InitAll077( ) ;
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
                        ResetCaption070( ) ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         EndLevel077( ) ;
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel077( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete077( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("proyecto",pr_default);
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
            context.RollbackDataStores("proyecto",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart077( )
      {
         /* Using cursor T000711 */
         pr_default.execute(9);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound7 = 1;
            A16ProyectoID = T000711_A16ProyectoID[0];
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext077( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound7 = 1;
            A16ProyectoID = T000711_A16ProyectoID[0];
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
         }
      }

      protected void ScanEnd077( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm077( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert077( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate077( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete077( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete077( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate077( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes077( )
      {
         edtProyectoID_Enabled = 0;
         AssignProp("", false, edtProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoID_Enabled), 5, 0), true);
         edtProyectoName_Enabled = 0;
         AssignProp("", false, edtProyectoName_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoName_Enabled), 5, 0), true);
         edtProyectoFecInicio_Enabled = 0;
         AssignProp("", false, edtProyectoFecInicio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecInicio_Enabled), 5, 0), true);
         edtProyectoFecFin_Enabled = 0;
         AssignProp("", false, edtProyectoFecFin_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecFin_Enabled), 5, 0), true);
         edtProyectoEstado_Enabled = 0;
         AssignProp("", false, edtProyectoEstado_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoEstado_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes077( )
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
         context.AddJavascriptSource("gxcfg.js", "?202031411133451", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("proyecto.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z16ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16ProyectoID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z17ProyectoName", StringUtil.RTrim( Z17ProyectoName));
         GxWebStd.gx_hidden_field( context, "Z18ProyectoFecInicio", context.localUtil.DToC( Z18ProyectoFecInicio, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z19ProyectoFecFin", context.localUtil.DToC( Z19ProyectoFecFin, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z20ProyectoEstado", StringUtil.RTrim( Z20ProyectoEstado));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
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
         return formatLink("proyecto.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Proyecto" ;
      }

      public override String GetPgmdesc( )
      {
         return "Proyecto" ;
      }

      protected void InitializeNonKey077( )
      {
         A17ProyectoName = "";
         AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
         A18ProyectoFecInicio = DateTime.MinValue;
         AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
         A19ProyectoFecFin = DateTime.MinValue;
         AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
         A20ProyectoEstado = "";
         AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
         Z17ProyectoName = "";
         Z18ProyectoFecInicio = DateTime.MinValue;
         Z19ProyectoFecFin = DateTime.MinValue;
         Z20ProyectoEstado = "";
      }

      protected void InitAll077( )
      {
         A16ProyectoID = 0;
         AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
         InitializeNonKey077( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202031411133454", true, true);
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
         context.AddJavascriptSource("proyecto.js", "?202031411133454", false, true);
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
         edtProyectoID_Internalname = "PROYECTOID";
         edtProyectoName_Internalname = "PROYECTONAME";
         edtProyectoFecInicio_Internalname = "PROYECTOFECINICIO";
         edtProyectoFecFin_Internalname = "PROYECTOFECFIN";
         edtProyectoEstado_Internalname = "PROYECTOESTADO";
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
         Form.Caption = "Proyecto";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtProyectoEstado_Jsonclick = "";
         edtProyectoEstado_Enabled = 1;
         edtProyectoFecFin_Jsonclick = "";
         edtProyectoFecFin_Enabled = 1;
         edtProyectoFecInicio_Jsonclick = "";
         edtProyectoFecInicio_Enabled = 1;
         edtProyectoName_Jsonclick = "";
         edtProyectoName_Enabled = 1;
         edtProyectoID_Jsonclick = "";
         edtProyectoID_Enabled = 1;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         getEqualNoModal( ) ;
         GX_FocusControl = edtProyectoName_Internalname;
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

      public void Valid_Proyectoid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A17ProyectoName", StringUtil.RTrim( A17ProyectoName));
         AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
         AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
         AssignAttri("", false, "A20ProyectoEstado", StringUtil.RTrim( A20ProyectoEstado));
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z16ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16ProyectoID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z17ProyectoName", StringUtil.RTrim( Z17ProyectoName));
         GxWebStd.gx_hidden_field( context, "Z18ProyectoFecInicio", context.localUtil.Format(Z18ProyectoFecInicio, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "Z19ProyectoFecFin", context.localUtil.Format(Z19ProyectoFecFin, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "Z20ProyectoEstado", StringUtil.RTrim( Z20ProyectoEstado));
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         SendCloseFormHiddens( ) ;
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
         setEventMetadata("VALID_PROYECTOID","{handler:'Valid_Proyectoid',iparms:[{av:'A16ProyectoID',fld:'PROYECTOID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_PROYECTOID",",oparms:[{av:'A17ProyectoName',fld:'PROYECTONAME',pic:''},{av:'A18ProyectoFecInicio',fld:'PROYECTOFECINICIO',pic:''},{av:'A19ProyectoFecFin',fld:'PROYECTOFECFIN',pic:''},{av:'A20ProyectoEstado',fld:'PROYECTOESTADO',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z16ProyectoID'},{av:'Z17ProyectoName'},{av:'Z18ProyectoFecInicio'},{av:'Z19ProyectoFecFin'},{av:'Z20ProyectoEstado'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
         setEventMetadata("VALID_PROYECTOFECINICIO","{handler:'Valid_Proyectofecinicio',iparms:[]");
         setEventMetadata("VALID_PROYECTOFECINICIO",",oparms:[]}");
         setEventMetadata("VALID_PROYECTOFECFIN","{handler:'Valid_Proyectofecfin',iparms:[]");
         setEventMetadata("VALID_PROYECTOFECFIN",",oparms:[]}");
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
         Z17ProyectoName = "";
         Z18ProyectoFecInicio = DateTime.MinValue;
         Z19ProyectoFecFin = DateTime.MinValue;
         Z20ProyectoEstado = "";
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
         A17ProyectoName = "";
         A18ProyectoFecInicio = DateTime.MinValue;
         A19ProyectoFecFin = DateTime.MinValue;
         A20ProyectoEstado = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00074_A16ProyectoID = new short[1] ;
         T00074_A17ProyectoName = new String[] {""} ;
         T00074_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00074_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00074_A20ProyectoEstado = new String[] {""} ;
         T00075_A16ProyectoID = new short[1] ;
         T00073_A16ProyectoID = new short[1] ;
         T00073_A17ProyectoName = new String[] {""} ;
         T00073_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00073_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00073_A20ProyectoEstado = new String[] {""} ;
         sMode7 = "";
         T00076_A16ProyectoID = new short[1] ;
         T00077_A16ProyectoID = new short[1] ;
         T00072_A16ProyectoID = new short[1] ;
         T00072_A17ProyectoName = new String[] {""} ;
         T00072_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00072_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00072_A20ProyectoEstado = new String[] {""} ;
         T00078_A16ProyectoID = new short[1] ;
         T000711_A16ProyectoID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         ZZ17ProyectoName = "";
         ZZ18ProyectoFecInicio = DateTime.MinValue;
         ZZ19ProyectoFecFin = DateTime.MinValue;
         ZZ20ProyectoEstado = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proyecto__default(),
            new Object[][] {
                new Object[] {
               T00072_A16ProyectoID, T00072_A17ProyectoName, T00072_A18ProyectoFecInicio, T00072_A19ProyectoFecFin, T00072_A20ProyectoEstado
               }
               , new Object[] {
               T00073_A16ProyectoID, T00073_A17ProyectoName, T00073_A18ProyectoFecInicio, T00073_A19ProyectoFecFin, T00073_A20ProyectoEstado
               }
               , new Object[] {
               T00074_A16ProyectoID, T00074_A17ProyectoName, T00074_A18ProyectoFecInicio, T00074_A19ProyectoFecFin, T00074_A20ProyectoEstado
               }
               , new Object[] {
               T00075_A16ProyectoID
               }
               , new Object[] {
               T00076_A16ProyectoID
               }
               , new Object[] {
               T00077_A16ProyectoID
               }
               , new Object[] {
               T00078_A16ProyectoID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000711_A16ProyectoID
               }
            }
         );
      }

      private short Z16ProyectoID ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A16ProyectoID ;
      private short GX_JID ;
      private short RcdFound7 ;
      private short nIsDirty_7 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ16ProyectoID ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtProyectoID_Enabled ;
      private int edtProyectoName_Enabled ;
      private int edtProyectoFecInicio_Enabled ;
      private int edtProyectoFecFin_Enabled ;
      private int edtProyectoEstado_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String Z17ProyectoName ;
      private String Z20ProyectoEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtProyectoID_Internalname ;
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
      private String edtProyectoID_Jsonclick ;
      private String edtProyectoName_Internalname ;
      private String A17ProyectoName ;
      private String edtProyectoName_Jsonclick ;
      private String edtProyectoFecInicio_Internalname ;
      private String edtProyectoFecInicio_Jsonclick ;
      private String edtProyectoFecFin_Internalname ;
      private String edtProyectoFecFin_Jsonclick ;
      private String edtProyectoEstado_Internalname ;
      private String A20ProyectoEstado ;
      private String edtProyectoEstado_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode7 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String ZZ17ProyectoName ;
      private String ZZ20ProyectoEstado ;
      private DateTime Z18ProyectoFecInicio ;
      private DateTime Z19ProyectoFecFin ;
      private DateTime A18ProyectoFecInicio ;
      private DateTime A19ProyectoFecFin ;
      private DateTime ZZ18ProyectoFecInicio ;
      private DateTime ZZ19ProyectoFecFin ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00074_A16ProyectoID ;
      private String[] T00074_A17ProyectoName ;
      private DateTime[] T00074_A18ProyectoFecInicio ;
      private DateTime[] T00074_A19ProyectoFecFin ;
      private String[] T00074_A20ProyectoEstado ;
      private short[] T00075_A16ProyectoID ;
      private short[] T00073_A16ProyectoID ;
      private String[] T00073_A17ProyectoName ;
      private DateTime[] T00073_A18ProyectoFecInicio ;
      private DateTime[] T00073_A19ProyectoFecFin ;
      private String[] T00073_A20ProyectoEstado ;
      private short[] T00076_A16ProyectoID ;
      private short[] T00077_A16ProyectoID ;
      private short[] T00072_A16ProyectoID ;
      private String[] T00072_A17ProyectoName ;
      private DateTime[] T00072_A18ProyectoFecInicio ;
      private DateTime[] T00072_A19ProyectoFecFin ;
      private String[] T00072_A20ProyectoEstado ;
      private short[] T00078_A16ProyectoID ;
      private short[] T000711_A16ProyectoID ;
      private GXWebForm Form ;
   }

   public class proyecto__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@ProyectoName",SqlDbType.NChar,20,0} ,
          new Object[] {"@ProyectoFecInicio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoFecFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoEstado",SqlDbType.NChar,30,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@ProyectoName",SqlDbType.NChar,20,0} ,
          new Object[] {"@ProyectoFecInicio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoFecFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoEstado",SqlDbType.NChar,30,0} ,
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@ProyectoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [ProyectoID], [ProyectoName], [ProyectoFecInicio], [ProyectoFecFin], [ProyectoEstado] FROM [Proyecto] WITH (UPDLOCK) WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00073", "SELECT [ProyectoID], [ProyectoName], [ProyectoFecInicio], [ProyectoFecFin], [ProyectoEstado] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00074", "SELECT TM1.[ProyectoID], TM1.[ProyectoName], TM1.[ProyectoFecInicio], TM1.[ProyectoFecFin], TM1.[ProyectoEstado] FROM [Proyecto] TM1 WHERE TM1.[ProyectoID] = @ProyectoID ORDER BY TM1.[ProyectoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00075", "SELECT [ProyectoID] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00076", "SELECT TOP 1 [ProyectoID] FROM [Proyecto] WHERE ( [ProyectoID] > @ProyectoID) ORDER BY [ProyectoID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00077", "SELECT TOP 1 [ProyectoID] FROM [Proyecto] WHERE ( [ProyectoID] < @ProyectoID) ORDER BY [ProyectoID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00078", "INSERT INTO [Proyecto]([ProyectoName], [ProyectoFecInicio], [ProyectoFecFin], [ProyectoEstado]) VALUES(@ProyectoName, @ProyectoFecInicio, @ProyectoFecFin, @ProyectoEstado); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00078)
             ,new CursorDef("T00079", "UPDATE [Proyecto] SET [ProyectoName]=@ProyectoName, [ProyectoFecInicio]=@ProyectoFecInicio, [ProyectoFecFin]=@ProyectoFecFin, [ProyectoEstado]=@ProyectoEstado  WHERE [ProyectoID] = @ProyectoID", GxErrorMask.GX_NOMASK,prmT00079)
             ,new CursorDef("T000710", "DELETE FROM [Proyecto]  WHERE [ProyectoID] = @ProyectoID", GxErrorMask.GX_NOMASK,prmT000710)
             ,new CursorDef("T000711", "SELECT [ProyectoID] FROM [Proyecto] ORDER BY [ProyectoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
