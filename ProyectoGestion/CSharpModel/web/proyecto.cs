/*
               File: Proyecto
        Description: Proyecto
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 3/22/2020 21:2:4.76
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
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV9ProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV9ProyectoID", StringUtil.LTrimStr( (decimal)(AV9ProyectoID), 4, 0));
               AssignAttri("", false, "gxhash_vPROYECTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ProyectoID), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Proyecto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtProyectoName_Internalname;
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

      public void execute( String aP0_Gx_mode ,
                           short aP1_ProyectoID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV9ProyectoID = aP1_ProyectoID;
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Proyecto.htm");
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
         GxWebStd.gx_single_line_edit( context, edtProyectoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16ProyectoID), 4, 0, ".", "")), ((edtProyectoID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9")) : context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_Proyecto.htm");
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
         GxWebStd.gx_single_line_edit( context, edtProyectoName_Internalname, StringUtil.RTrim( A17ProyectoName), StringUtil.RTrim( context.localUtil.Format( A17ProyectoName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoName_Enabled, 0, "text", "", 30, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "NameProyect", "left", true, "", "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoDescription_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Multiple line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         GxWebStd.gx_html_textarea( context, edtProyectoDescription_Internalname, A22ProyectoDescription, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A22ProyectoDescription), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", 0, 1, edtProyectoDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Proyecto.htm");
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
         context.WriteHtmlText( "<div id=\""+edtProyectoFecInicio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtProyectoFecInicio_Internalname, context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"), context.localUtil.Format( A18ProyectoFecInicio, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoFecInicio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoFecInicio_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
         GxWebStd.gx_bitmap( context, edtProyectoFecInicio_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtProyectoFecInicio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Proyecto.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProyectoFecFin_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtProyectoFecFin_Internalname, "Fec Fin", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         context.WriteHtmlText( "<div id=\""+edtProyectoFecFin_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtProyectoFecFin_Internalname, context.localUtil.Format(A19ProyectoFecFin, "99/99/99"), context.localUtil.Format( A19ProyectoFecFin, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoFecFin_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoFecFin_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Proyecto.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtProyectoEstado_Internalname, StringUtil.RTrim( A20ProyectoEstado), StringUtil.RTrim( context.localUtil.Format( A20ProyectoEstado, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProyectoEstado_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProyectoEstado_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "Estado", "left", true, "", "HLP_Proyecto.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Proyecto.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
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
               Z16ProyectoID = (short)(context.localUtil.CToN( cgiGet( "Z16ProyectoID"), ".", ","));
               Z17ProyectoName = cgiGet( "Z17ProyectoName");
               Z30ProyectoNombre = cgiGet( "Z30ProyectoNombre");
               Z18ProyectoFecInicio = context.localUtil.CToD( cgiGet( "Z18ProyectoFecInicio"), 0);
               Z22ProyectoDescription = cgiGet( "Z22ProyectoDescription");
               Z19ProyectoFecFin = context.localUtil.CToD( cgiGet( "Z19ProyectoFecFin"), 0);
               Z20ProyectoEstado = cgiGet( "Z20ProyectoEstado");
               A30ProyectoNombre = cgiGet( "Z30ProyectoNombre");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV9ProyectoID = (short)(context.localUtil.CToN( cgiGet( "vPROYECTOID"), ".", ","));
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0);
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               A30ProyectoNombre = cgiGet( "PROYECTONOMBRE");
               AV15Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               A16ProyectoID = (short)(context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), ".", ","));
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
               A17ProyectoName = cgiGet( edtProyectoName_Internalname);
               AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
               A22ProyectoDescription = cgiGet( edtProyectoDescription_Internalname);
               AssignAttri("", false, "A22ProyectoDescription", A22ProyectoDescription);
               A18ProyectoFecInicio = context.localUtil.CToD( cgiGet( edtProyectoFecInicio_Internalname), 1);
               AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
               A19ProyectoFecFin = context.localUtil.CToD( cgiGet( edtProyectoFecFin_Internalname), 1);
               AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
               A20ProyectoEstado = cgiGet( edtProyectoEstado_Internalname);
               AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Proyecto");
               A16ProyectoID = (short)(context.localUtil.CToN( cgiGet( edtProyectoID_Internalname), ".", ","));
               AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
               forbiddenHiddens.Add("ProyectoID", context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9"));
               A18ProyectoFecInicio = context.localUtil.CToD( cgiGet( edtProyectoFecInicio_Internalname), 1);
               AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
               forbiddenHiddens.Add("ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               forbiddenHiddens.Add("ProyectoNombre", StringUtil.RTrim( context.localUtil.Format( A30ProyectoNombre, "")));
               A19ProyectoFecFin = context.localUtil.CToD( cgiGet( edtProyectoFecFin_Internalname), 1);
               AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
               forbiddenHiddens.Add("ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A16ProyectoID != Z16ProyectoID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("proyecto:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
                  A16ProyectoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
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
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode7;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PROYECTOID");
                        AnyError = 1;
                        GX_FocusControl = edtProyectoID_Internalname;
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
            DisableAttributes077( ) ;
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
         BeforeValidate077( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls077( ) ;
            }
            else
            {
               CheckExtendedTable077( ) ;
               CloseExtendedTableCursors077( ) ;
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
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "TransactionContext", "ProyectoGestion");
      }

      protected void E12072( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwproyecto.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM077( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z17ProyectoName = T00073_A17ProyectoName[0];
               Z30ProyectoNombre = T00073_A30ProyectoNombre[0];
               Z18ProyectoFecInicio = T00073_A18ProyectoFecInicio[0];
               Z22ProyectoDescription = T00073_A22ProyectoDescription[0];
               Z19ProyectoFecFin = T00073_A19ProyectoFecFin[0];
               Z20ProyectoEstado = T00073_A20ProyectoEstado[0];
            }
            else
            {
               Z17ProyectoName = A17ProyectoName;
               Z30ProyectoNombre = A30ProyectoNombre;
               Z18ProyectoFecInicio = A18ProyectoFecInicio;
               Z22ProyectoDescription = A22ProyectoDescription;
               Z19ProyectoFecFin = A19ProyectoFecFin;
               Z20ProyectoEstado = A20ProyectoEstado;
            }
         }
         if ( GX_JID == -7 )
         {
            Z16ProyectoID = A16ProyectoID;
            Z17ProyectoName = A17ProyectoName;
            Z30ProyectoNombre = A30ProyectoNombre;
            Z18ProyectoFecInicio = A18ProyectoFecInicio;
            Z22ProyectoDescription = A22ProyectoDescription;
            Z19ProyectoFecFin = A19ProyectoFecFin;
            Z20ProyectoEstado = A20ProyectoEstado;
         }
      }

      protected void standaloneNotModal( )
      {
         edtProyectoID_Enabled = 0;
         AssignProp("", false, edtProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoID_Enabled), 5, 0), true);
         edtProyectoFecFin_Enabled = 0;
         AssignProp("", false, edtProyectoFecFin_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecFin_Enabled), 5, 0), true);
         edtProyectoFecInicio_Enabled = 0;
         AssignProp("", false, edtProyectoFecInicio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecInicio_Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( context);
         AssignAttri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         edtProyectoID_Enabled = 0;
         AssignProp("", false, edtProyectoID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoID_Enabled), 5, 0), true);
         edtProyectoFecFin_Enabled = 0;
         AssignProp("", false, edtProyectoFecFin_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecFin_Enabled), 5, 0), true);
         edtProyectoFecInicio_Enabled = 0;
         AssignProp("", false, edtProyectoFecInicio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoFecInicio_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV9ProyectoID) )
         {
            A16ProyectoID = AV9ProyectoID;
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
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
         if ( IsIns( )  && (DateTime.MinValue==A18ProyectoFecInicio) && ( Gx_BScreen == 0 ) )
         {
            A18ProyectoFecInicio = Gx_date;
            AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
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
            A30ProyectoNombre = T00074_A30ProyectoNombre[0];
            A18ProyectoFecInicio = T00074_A18ProyectoFecInicio[0];
            AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            A22ProyectoDescription = T00074_A22ProyectoDescription[0];
            AssignAttri("", false, "A22ProyectoDescription", A22ProyectoDescription);
            A19ProyectoFecFin = T00074_A19ProyectoFecFin[0];
            AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            A20ProyectoEstado = T00074_A20ProyectoEstado[0];
            AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
            ZM077( -7) ;
         }
         pr_default.close(2);
         OnLoadActions077( ) ;
      }

      protected void OnLoadActions077( )
      {
         AV15Pgmname = "Proyecto";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable077( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV15Pgmname = "Proyecto";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A17ProyectoName)) )
         {
            GX_msglist.addItem("Campo Obligtorio", 1, "PROYECTONAME");
            AnyError = 1;
            GX_FocusControl = edtProyectoName_Internalname;
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
            ZM077( 7) ;
            RcdFound7 = 1;
            A16ProyectoID = T00073_A16ProyectoID[0];
            AssignAttri("", false, "A16ProyectoID", StringUtil.LTrimStr( (decimal)(A16ProyectoID), 4, 0));
            A17ProyectoName = T00073_A17ProyectoName[0];
            AssignAttri("", false, "A17ProyectoName", A17ProyectoName);
            A30ProyectoNombre = T00073_A30ProyectoNombre[0];
            A18ProyectoFecInicio = T00073_A18ProyectoFecInicio[0];
            AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
            A22ProyectoDescription = T00073_A22ProyectoDescription[0];
            AssignAttri("", false, "A22ProyectoDescription", A22ProyectoDescription);
            A19ProyectoFecFin = T00073_A19ProyectoFecFin[0];
            AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
            A20ProyectoEstado = T00073_A20ProyectoEstado[0];
            AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
            Z16ProyectoID = A16ProyectoID;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load077( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey077( ) ;
            }
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey077( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey077( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
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
            GX_FocusControl = edtProyectoName_Internalname;
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
                  GX_FocusControl = edtProyectoName_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update077( ) ;
                  GX_FocusControl = edtProyectoName_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A16ProyectoID != Z16ProyectoID )
               {
                  /* Insert record */
                  GX_FocusControl = edtProyectoName_Internalname;
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
                     /* Insert record */
                     GX_FocusControl = edtProyectoName_Internalname;
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
            GX_FocusControl = edtProyectoName_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
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
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z17ProyectoName, T00072_A17ProyectoName[0]) != 0 ) || ( StringUtil.StrCmp(Z30ProyectoNombre, T00072_A30ProyectoNombre[0]) != 0 ) || ( Z18ProyectoFecInicio != T00072_A18ProyectoFecInicio[0] ) || ( StringUtil.StrCmp(Z22ProyectoDescription, T00072_A22ProyectoDescription[0]) != 0 ) || ( Z19ProyectoFecFin != T00072_A19ProyectoFecFin[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z20ProyectoEstado, T00072_A20ProyectoEstado[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z17ProyectoName, T00072_A17ProyectoName[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoName");
                  GXUtil.WriteLogRaw("Old: ",Z17ProyectoName);
                  GXUtil.WriteLogRaw("Current: ",T00072_A17ProyectoName[0]);
               }
               if ( StringUtil.StrCmp(Z30ProyectoNombre, T00072_A30ProyectoNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoNombre");
                  GXUtil.WriteLogRaw("Old: ",Z30ProyectoNombre);
                  GXUtil.WriteLogRaw("Current: ",T00072_A30ProyectoNombre[0]);
               }
               if ( Z18ProyectoFecInicio != T00072_A18ProyectoFecInicio[0] )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoFecInicio");
                  GXUtil.WriteLogRaw("Old: ",Z18ProyectoFecInicio);
                  GXUtil.WriteLogRaw("Current: ",T00072_A18ProyectoFecInicio[0]);
               }
               if ( StringUtil.StrCmp(Z22ProyectoDescription, T00072_A22ProyectoDescription[0]) != 0 )
               {
                  GXUtil.WriteLog("proyecto:[seudo value changed for attri]"+"ProyectoDescription");
                  GXUtil.WriteLogRaw("Old: ",Z22ProyectoDescription);
                  GXUtil.WriteLogRaw("Current: ",T00072_A22ProyectoDescription[0]);
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
                     pr_default.execute(6, new Object[] {A17ProyectoName, A30ProyectoNombre, A18ProyectoFecInicio, A22ProyectoDescription, A19ProyectoFecFin, A20ProyectoEstado});
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
                     pr_default.execute(7, new Object[] {A17ProyectoName, A30ProyectoNombre, A18ProyectoFecInicio, A22ProyectoDescription, A19ProyectoFecFin, A20ProyectoEstado, A16ProyectoID});
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
            EndLevel077( ) ;
         }
         CloseExtendedTableCursors077( ) ;
      }

      protected void DeferredUpdate077( )
      {
      }

      protected void delete( )
      {
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel077( ) ;
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls077( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Proyecto";
            AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
         }
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
         /* Scan By routine */
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
         edtProyectoDescription_Enabled = 0;
         AssignProp("", false, edtProyectoDescription_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtProyectoDescription_Enabled), 5, 0), true);
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
         context.AddJavascriptSource("gxcfg.js", "?2020322212536", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("proyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9ProyectoID)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Proyecto");
         forbiddenHiddens.Add("ProyectoID", context.localUtil.Format( (decimal)(A16ProyectoID), "ZZZ9"));
         forbiddenHiddens.Add("ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         forbiddenHiddens.Add("ProyectoNombre", StringUtil.RTrim( context.localUtil.Format( A30ProyectoNombre, "")));
         forbiddenHiddens.Add("ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("proyecto:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z16ProyectoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16ProyectoID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z17ProyectoName", StringUtil.RTrim( Z17ProyectoName));
         GxWebStd.gx_hidden_field( context, "Z30ProyectoNombre", StringUtil.RTrim( Z30ProyectoNombre));
         GxWebStd.gx_hidden_field( context, "Z18ProyectoFecInicio", context.localUtil.DToC( Z18ProyectoFecInicio, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z22ProyectoDescription", Z22ProyectoDescription);
         GxWebStd.gx_hidden_field( context, "Z19ProyectoFecFin", context.localUtil.DToC( Z19ProyectoFecFin, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z20ProyectoEstado", StringUtil.RTrim( Z20ProyectoEstado));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV11TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vPROYECTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ProyectoID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPROYECTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ProyectoID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROYECTONOMBRE", StringUtil.RTrim( A30ProyectoNombre));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
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
         return formatLink("proyecto.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV9ProyectoID) ;
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
         A30ProyectoNombre = "";
         AssignAttri("", false, "A30ProyectoNombre", A30ProyectoNombre);
         A22ProyectoDescription = "";
         AssignAttri("", false, "A22ProyectoDescription", A22ProyectoDescription);
         A19ProyectoFecFin = DateTime.MinValue;
         AssignAttri("", false, "A19ProyectoFecFin", context.localUtil.Format(A19ProyectoFecFin, "99/99/99"));
         A20ProyectoEstado = "";
         AssignAttri("", false, "A20ProyectoEstado", A20ProyectoEstado);
         A18ProyectoFecInicio = Gx_date;
         AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
         Z17ProyectoName = "";
         Z30ProyectoNombre = "";
         Z18ProyectoFecInicio = DateTime.MinValue;
         Z22ProyectoDescription = "";
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
         A18ProyectoFecInicio = i18ProyectoFecInicio;
         AssignAttri("", false, "A18ProyectoFecInicio", context.localUtil.Format(A18ProyectoFecInicio, "99/99/99"));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020322212545", true, true);
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
         context.AddJavascriptSource("proyecto.js", "?2020322212545", false, true);
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
         edtProyectoDescription_Internalname = "PROYECTODESCRIPTION";
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
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtProyectoEstado_Jsonclick = "";
         edtProyectoEstado_Enabled = 1;
         edtProyectoFecFin_Jsonclick = "";
         edtProyectoFecFin_Enabled = 0;
         edtProyectoFecInicio_Jsonclick = "";
         edtProyectoFecInicio_Enabled = 0;
         edtProyectoDescription_Enabled = 1;
         edtProyectoName_Jsonclick = "";
         edtProyectoName_Enabled = 1;
         edtProyectoID_Jsonclick = "";
         edtProyectoID_Enabled = 0;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9ProyectoID',fld:'vPROYECTOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV9ProyectoID',fld:'vPROYECTOID',pic:'ZZZ9',hsh:true},{av:'A16ProyectoID',fld:'PROYECTOID',pic:'ZZZ9'},{av:'A18ProyectoFecInicio',fld:'PROYECTOFECINICIO',pic:''},{av:'A30ProyectoNombre',fld:'PROYECTONOMBRE',pic:''},{av:'A19ProyectoFecFin',fld:'PROYECTOFECFIN',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12072',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_PROYECTOID","{handler:'Valid_Proyectoid',iparms:[]");
         setEventMetadata("VALID_PROYECTOID",",oparms:[]}");
         setEventMetadata("VALID_PROYECTONAME","{handler:'Valid_Proyectoname',iparms:[]");
         setEventMetadata("VALID_PROYECTONAME",",oparms:[]}");
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
         Z17ProyectoName = "";
         Z30ProyectoNombre = "";
         Z18ProyectoFecInicio = DateTime.MinValue;
         Z22ProyectoDescription = "";
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
         A22ProyectoDescription = "";
         A18ProyectoFecInicio = DateTime.MinValue;
         A19ProyectoFecFin = DateTime.MinValue;
         A20ProyectoEstado = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         A30ProyectoNombre = "";
         Gx_date = DateTime.MinValue;
         AV15Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = context.GetSession();
         T00074_A16ProyectoID = new short[1] ;
         T00074_A17ProyectoName = new String[] {""} ;
         T00074_A30ProyectoNombre = new String[] {""} ;
         T00074_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00074_A22ProyectoDescription = new String[] {""} ;
         T00074_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00074_A20ProyectoEstado = new String[] {""} ;
         T00075_A16ProyectoID = new short[1] ;
         T00073_A16ProyectoID = new short[1] ;
         T00073_A17ProyectoName = new String[] {""} ;
         T00073_A30ProyectoNombre = new String[] {""} ;
         T00073_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00073_A22ProyectoDescription = new String[] {""} ;
         T00073_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00073_A20ProyectoEstado = new String[] {""} ;
         T00076_A16ProyectoID = new short[1] ;
         T00077_A16ProyectoID = new short[1] ;
         T00072_A16ProyectoID = new short[1] ;
         T00072_A17ProyectoName = new String[] {""} ;
         T00072_A30ProyectoNombre = new String[] {""} ;
         T00072_A18ProyectoFecInicio = new DateTime[] {DateTime.MinValue} ;
         T00072_A22ProyectoDescription = new String[] {""} ;
         T00072_A19ProyectoFecFin = new DateTime[] {DateTime.MinValue} ;
         T00072_A20ProyectoEstado = new String[] {""} ;
         T00078_A16ProyectoID = new short[1] ;
         T000711_A16ProyectoID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i18ProyectoFecInicio = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.proyecto__default(),
            new Object[][] {
                new Object[] {
               T00072_A16ProyectoID, T00072_A17ProyectoName, T00072_A30ProyectoNombre, T00072_A18ProyectoFecInicio, T00072_A22ProyectoDescription, T00072_A19ProyectoFecFin, T00072_A20ProyectoEstado
               }
               , new Object[] {
               T00073_A16ProyectoID, T00073_A17ProyectoName, T00073_A30ProyectoNombre, T00073_A18ProyectoFecInicio, T00073_A22ProyectoDescription, T00073_A19ProyectoFecFin, T00073_A20ProyectoEstado
               }
               , new Object[] {
               T00074_A16ProyectoID, T00074_A17ProyectoName, T00074_A30ProyectoNombre, T00074_A18ProyectoFecInicio, T00074_A22ProyectoDescription, T00074_A19ProyectoFecFin, T00074_A20ProyectoEstado
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
         AV15Pgmname = "Proyecto";
         Z18ProyectoFecInicio = DateTime.MinValue;
         A18ProyectoFecInicio = DateTime.MinValue;
         i18ProyectoFecInicio = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
      }

      private short wcpOAV9ProyectoID ;
      private short Z16ProyectoID ;
      private short GxWebError ;
      private short AV9ProyectoID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A16ProyectoID ;
      private short Gx_BScreen ;
      private short RcdFound7 ;
      private short GX_JID ;
      private short nIsDirty_7 ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtProyectoID_Enabled ;
      private int edtProyectoName_Enabled ;
      private int edtProyectoDescription_Enabled ;
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
      private String wcpOGx_mode ;
      private String Z17ProyectoName ;
      private String Z30ProyectoNombre ;
      private String Z20ProyectoEstado ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtProyectoName_Internalname ;
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
      private String edtProyectoID_Internalname ;
      private String edtProyectoID_Jsonclick ;
      private String A17ProyectoName ;
      private String edtProyectoName_Jsonclick ;
      private String edtProyectoDescription_Internalname ;
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
      private String A30ProyectoNombre ;
      private String AV15Pgmname ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z18ProyectoFecInicio ;
      private DateTime Z19ProyectoFecFin ;
      private DateTime A18ProyectoFecInicio ;
      private DateTime A19ProyectoFecFin ;
      private DateTime Gx_date ;
      private DateTime i18ProyectoFecInicio ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z22ProyectoDescription ;
      private String A22ProyectoDescription ;
      private IGxSession AV12WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00074_A16ProyectoID ;
      private String[] T00074_A17ProyectoName ;
      private String[] T00074_A30ProyectoNombre ;
      private DateTime[] T00074_A18ProyectoFecInicio ;
      private String[] T00074_A22ProyectoDescription ;
      private DateTime[] T00074_A19ProyectoFecFin ;
      private String[] T00074_A20ProyectoEstado ;
      private short[] T00075_A16ProyectoID ;
      private short[] T00073_A16ProyectoID ;
      private String[] T00073_A17ProyectoName ;
      private String[] T00073_A30ProyectoNombre ;
      private DateTime[] T00073_A18ProyectoFecInicio ;
      private String[] T00073_A22ProyectoDescription ;
      private DateTime[] T00073_A19ProyectoFecFin ;
      private String[] T00073_A20ProyectoEstado ;
      private short[] T00076_A16ProyectoID ;
      private short[] T00077_A16ProyectoID ;
      private short[] T00072_A16ProyectoID ;
      private String[] T00072_A17ProyectoName ;
      private String[] T00072_A30ProyectoNombre ;
      private DateTime[] T00072_A18ProyectoFecInicio ;
      private String[] T00072_A22ProyectoDescription ;
      private DateTime[] T00072_A19ProyectoFecFin ;
      private String[] T00072_A20ProyectoEstado ;
      private short[] T00078_A16ProyectoID ;
      private short[] T000711_A16ProyectoID ;
      private GXWebForm Form ;
      private SdtTransactionContext AV11TrnContext ;
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
          new Object[] {"@ProyectoName",SqlDbType.NChar,40,0} ,
          new Object[] {"@ProyectoNombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@ProyectoFecInicio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoDescription",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@ProyectoFecFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoEstado",SqlDbType.NChar,30,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@ProyectoName",SqlDbType.NChar,40,0} ,
          new Object[] {"@ProyectoNombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@ProyectoFecInicio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ProyectoDescription",SqlDbType.NVarChar,1024,0} ,
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
              new CursorDef("T00072", "SELECT [ProyectoID], [ProyectoName], [ProyectoNombre], [ProyectoFecInicio], [ProyectoDescription], [ProyectoFecFin], [ProyectoEstado] FROM [Proyecto] WITH (UPDLOCK) WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00073", "SELECT [ProyectoID], [ProyectoName], [ProyectoNombre], [ProyectoFecInicio], [ProyectoDescription], [ProyectoFecFin], [ProyectoEstado] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00074", "SELECT TM1.[ProyectoID], TM1.[ProyectoName], TM1.[ProyectoNombre], TM1.[ProyectoFecInicio], TM1.[ProyectoDescription], TM1.[ProyectoFecFin], TM1.[ProyectoEstado] FROM [Proyecto] TM1 WHERE TM1.[ProyectoID] = @ProyectoID ORDER BY TM1.[ProyectoID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00075", "SELECT [ProyectoID] FROM [Proyecto] WHERE [ProyectoID] = @ProyectoID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00076", "SELECT TOP 1 [ProyectoID] FROM [Proyecto] WHERE ( [ProyectoID] > @ProyectoID) ORDER BY [ProyectoID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00077", "SELECT TOP 1 [ProyectoID] FROM [Proyecto] WHERE ( [ProyectoID] < @ProyectoID) ORDER BY [ProyectoID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00078", "INSERT INTO [Proyecto]([ProyectoName], [ProyectoNombre], [ProyectoFecInicio], [ProyectoDescription], [ProyectoFecFin], [ProyectoEstado]) VALUES(@ProyectoName, @ProyectoNombre, @ProyectoFecInicio, @ProyectoDescription, @ProyectoFecFin, @ProyectoEstado); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00078)
             ,new CursorDef("T00079", "UPDATE [Proyecto] SET [ProyectoName]=@ProyectoName, [ProyectoNombre]=@ProyectoNombre, [ProyectoFecInicio]=@ProyectoFecInicio, [ProyectoDescription]=@ProyectoDescription, [ProyectoFecFin]=@ProyectoFecFin, [ProyectoEstado]=@ProyectoEstado  WHERE [ProyectoID] = @ProyectoID", GxErrorMask.GX_NOMASK,prmT00079)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
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
