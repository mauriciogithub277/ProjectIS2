/*
               File: AttractionSupplier
        Description: Attraction Supplier
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 3/13/2020 18:2:23.84
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
   public class attractionsupplier : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A4AttractionID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A4AttractionID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A10SupplierID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A10SupplierID) ;
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
            Form.Meta.addItem("description", "Attraction Supplier", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtAttractionID_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public attractionsupplier( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public attractionsupplier( IGxContext context )
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Attraction Supplier", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_AttractionSupplier.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ATTRACTIONID"+"'), id:'"+"ATTRACTIONID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"SUPPLIERID"+"'), id:'"+"SUPPLIERID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_AttractionSupplier.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAttractionID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtAttractionID_Internalname, "Attraction ID", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtAttractionID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4AttractionID), 4, 0, ".", "")), ((edtAttractionID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4AttractionID), "ZZZ9")) : context.localUtil.Format( (decimal)(A4AttractionID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAttractionID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAttractionID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_AttractionSupplier.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, sImgUrl, imgprompt_4_Link, "", "", context.GetTheme( ), imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSupplierID_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSupplierID_Internalname, "Supplier ID", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtSupplierID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10SupplierID), 4, 0, ".", "")), ((edtSupplierID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10SupplierID), "ZZZ9")) : context.localUtil.Format( (decimal)(A10SupplierID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSupplierID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSupplierID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "", "HLP_AttractionSupplier.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_10_Internalname, sImgUrl, imgprompt_10_Link, "", "", context.GetTheme( ), imgprompt_10_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_AttractionSupplier.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_AttractionSupplier.htm");
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
            Z4AttractionID = (short)(context.localUtil.CToN( cgiGet( "Z4AttractionID"), ".", ","));
            Z10SupplierID = (short)(context.localUtil.CToN( cgiGet( "Z10SupplierID"), ".", ","));
            IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
            IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
            Gx_mode = cgiGet( "Mode");
            Gx_mode = cgiGet( "vMODE");
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtAttractionID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAttractionID_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ATTRACTIONID");
               AnyError = 1;
               GX_FocusControl = edtAttractionID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A4AttractionID = 0;
               AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            }
            else
            {
               A4AttractionID = (short)(context.localUtil.CToN( cgiGet( edtAttractionID_Internalname), ".", ","));
               AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtSupplierID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSupplierID_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SUPPLIERID");
               AnyError = 1;
               GX_FocusControl = edtSupplierID_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               A10SupplierID = 0;
               AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
            }
            else
            {
               A10SupplierID = (short)(context.localUtil.CToN( cgiGet( edtSupplierID_Internalname), ".", ","));
               AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
            }
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
               A4AttractionID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
               A10SupplierID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
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
               InitAll055( ) ;
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
         DisableAttributes055( ) ;
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

      protected void ResetCaption050( )
      {
      }

      protected void ZM055( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -1 )
         {
            Z4AttractionID = A4AttractionID;
            Z10SupplierID = A10SupplierID;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ATTRACTIONID"+"'), id:'"+"ATTRACTIONID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SUPPLIERID"+"'), id:'"+"SUPPLIERID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");");
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

      protected void Load055( )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A4AttractionID, A10SupplierID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound5 = 1;
            ZM055( -1) ;
         }
         pr_default.close(4);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
      }

      protected void CheckExtendedTable055( )
      {
         nIsDirty_5 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A4AttractionID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Attraction'.", "ForeignKeyNotFound", 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A10SupplierID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Supplier'.", "ForeignKeyNotFound", 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors055( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A4AttractionID )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A4AttractionID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Attraction'.", "ForeignKeyNotFound", 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(5) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(5);
      }

      protected void gxLoad_3( short A10SupplierID )
      {
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A10SupplierID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Supplier'.", "ForeignKeyNotFound", 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(6) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(6);
      }

      protected void GetKey055( )
      {
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A4AttractionID, A10SupplierID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A4AttractionID, A10SupplierID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM055( 1) ;
            RcdFound5 = 1;
            A4AttractionID = T00053_A4AttractionID[0];
            AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            A10SupplierID = T00053_A10SupplierID[0];
            AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
            Z4AttractionID = A4AttractionID;
            Z10SupplierID = A10SupplierID;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load055( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey055( ) ;
            }
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey055( ) ;
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
         GetKey055( ) ;
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
         /* Using cursor T000510 */
         pr_default.execute(8, new Object[] {A4AttractionID, A10SupplierID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000510_A4AttractionID[0] < A4AttractionID ) || ( T000510_A4AttractionID[0] == A4AttractionID ) && ( T000510_A10SupplierID[0] < A10SupplierID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000510_A4AttractionID[0] > A4AttractionID ) || ( T000510_A4AttractionID[0] == A4AttractionID ) && ( T000510_A10SupplierID[0] > A10SupplierID ) ) )
            {
               A4AttractionID = T000510_A4AttractionID[0];
               AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
               A10SupplierID = T000510_A10SupplierID[0];
               AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T000511 */
         pr_default.execute(9, new Object[] {A4AttractionID, A10SupplierID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000511_A4AttractionID[0] > A4AttractionID ) || ( T000511_A4AttractionID[0] == A4AttractionID ) && ( T000511_A10SupplierID[0] > A10SupplierID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000511_A4AttractionID[0] < A4AttractionID ) || ( T000511_A4AttractionID[0] == A4AttractionID ) && ( T000511_A10SupplierID[0] < A10SupplierID ) ) )
            {
               A4AttractionID = T000511_A4AttractionID[0];
               AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
               A10SupplierID = T000511_A10SupplierID[0];
               AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey055( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert055( ) ;
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
               if ( ( A4AttractionID != Z4AttractionID ) || ( A10SupplierID != Z10SupplierID ) )
               {
                  A4AttractionID = Z4AttractionID;
                  AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
                  A10SupplierID = Z10SupplierID;
                  AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ATTRACTIONID");
                  AnyError = 1;
                  GX_FocusControl = edtAttractionID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtAttractionID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update055( ) ;
                  GX_FocusControl = edtAttractionID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A4AttractionID != Z4AttractionID ) || ( A10SupplierID != Z10SupplierID ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAttractionID_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert055( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ATTRACTIONID");
                     AnyError = 1;
                     GX_FocusControl = edtAttractionID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtAttractionID_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert055( ) ;
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
         if ( ( A4AttractionID != Z4AttractionID ) || ( A10SupplierID != Z10SupplierID ) )
         {
            A4AttractionID = Z4AttractionID;
            AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            A10SupplierID = Z10SupplierID;
            AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAttractionID_Internalname;
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
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd055( ) ;
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
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         ScanStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext055( ) ;
            }
            Gx_mode = "UPD";
            AssignAttri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd055( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency055( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A4AttractionID, A10SupplierID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AttractionSupplier"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AttractionSupplier"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM055( 0) ;
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000512 */
                     pr_default.execute(10, new Object[] {A4AttractionID, A10SupplierID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("AttractionSupplier") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption050( ) ;
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [AttractionSupplier] */
                     DeferredUpdate055( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption050( ) ;
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
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls055( ) ;
            AfterConfirm055( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete055( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000513 */
                  pr_default.execute(11, new Object[] {A4AttractionID, A10SupplierID});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("AttractionSupplier") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound5 == 0 )
                        {
                           InitAll055( ) ;
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
                        ResetCaption050( ) ;
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
         EndLevel055( ) ;
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel055( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete055( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("attractionsupplier",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("attractionsupplier",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart055( )
      {
         /* Using cursor T000514 */
         pr_default.execute(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A4AttractionID = T000514_A4AttractionID[0];
            AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            A10SupplierID = T000514_A10SupplierID[0];
            AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext055( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A4AttractionID = T000514_A4AttractionID[0];
            AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
            A10SupplierID = T000514_A10SupplierID[0];
            AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
         }
      }

      protected void ScanEnd055( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes055( )
      {
         edtAttractionID_Enabled = 0;
         AssignProp("", false, edtAttractionID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtAttractionID_Enabled), 5, 0), true);
         edtSupplierID_Enabled = 0;
         AssignProp("", false, edtSupplierID_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSupplierID_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes055( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.AddJavascriptSource("gxcfg.js", "?20203131822422", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("attractionsupplier.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z4AttractionID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4AttractionID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z10SupplierID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10SupplierID), 4, 0, ".", "")));
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
         return formatLink("attractionsupplier.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "AttractionSupplier" ;
      }

      public override String GetPgmdesc( )
      {
         return "Attraction Supplier" ;
      }

      protected void InitializeNonKey055( )
      {
      }

      protected void InitAll055( )
      {
         A4AttractionID = 0;
         AssignAttri("", false, "A4AttractionID", StringUtil.LTrimStr( (decimal)(A4AttractionID), 4, 0));
         A10SupplierID = 0;
         AssignAttri("", false, "A10SupplierID", StringUtil.LTrimStr( (decimal)(A10SupplierID), 4, 0));
         InitializeNonKey055( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20203131822423", true, true);
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
         context.AddJavascriptSource("attractionsupplier.js", "?20203131822423", false, true);
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
         edtAttractionID_Internalname = "ATTRACTIONID";
         edtSupplierID_Internalname = "SUPPLIERID";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_4_Internalname = "PROMPT_4";
         imgprompt_10_Internalname = "PROMPT_10";
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
         Form.Caption = "Attraction Supplier";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgprompt_10_Visible = 1;
         imgprompt_10_Link = "";
         edtSupplierID_Jsonclick = "";
         edtSupplierID_Enabled = 1;
         imgprompt_4_Visible = 1;
         imgprompt_4_Link = "";
         edtAttractionID_Jsonclick = "";
         edtAttractionID_Enabled = 1;
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
         /* Using cursor T000515 */
         pr_default.execute(13, new Object[] {A4AttractionID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Attraction'.", "ForeignKeyNotFound", 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(13);
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A10SupplierID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Supplier'.", "ForeignKeyNotFound", 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierID_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(14);
         if ( AnyError == 0 )
         {
            GX_FocusControl = "";
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
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

      public void Valid_Attractionid( )
      {
         /* Using cursor T000515 */
         pr_default.execute(13, new Object[] {A4AttractionID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Attraction'.", "ForeignKeyNotFound", 1, "ATTRACTIONID");
            AnyError = 1;
            GX_FocusControl = edtAttractionID_Internalname;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         /*  Sending validation outputs */
      }

      public void Valid_Supplierid( )
      {
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A10SupplierID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Supplier'.", "ForeignKeyNotFound", 1, "SUPPLIERID");
            AnyError = 1;
            GX_FocusControl = edtSupplierID_Internalname;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "Gx_mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "Z4AttractionID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4AttractionID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z10SupplierID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10SupplierID), 4, 0, ".", "")));
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
         setEventMetadata("VALID_ATTRACTIONID","{handler:'Valid_Attractionid',iparms:[{av:'A4AttractionID',fld:'ATTRACTIONID',pic:'ZZZ9'}]");
         setEventMetadata("VALID_ATTRACTIONID",",oparms:[]}");
         setEventMetadata("VALID_SUPPLIERID","{handler:'Valid_Supplierid',iparms:[{av:'A4AttractionID',fld:'ATTRACTIONID',pic:'ZZZ9'},{av:'A10SupplierID',fld:'SUPPLIERID',pic:'ZZZ9'},{av:'Gx_mode',fld:'vMODE',pic:'@!'}]");
         setEventMetadata("VALID_SUPPLIERID",",oparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!'},{av:'Z4AttractionID'},{av:'Z10SupplierID'},{ctrl:'BTN_DELETE',prop:'Enabled'},{ctrl:'BTN_ENTER',prop:'Enabled'}]}");
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
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
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
         sImgUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00056_A4AttractionID = new short[1] ;
         T00056_A10SupplierID = new short[1] ;
         T00054_A4AttractionID = new short[1] ;
         T00055_A10SupplierID = new short[1] ;
         T00057_A4AttractionID = new short[1] ;
         T00058_A10SupplierID = new short[1] ;
         T00059_A4AttractionID = new short[1] ;
         T00059_A10SupplierID = new short[1] ;
         T00053_A4AttractionID = new short[1] ;
         T00053_A10SupplierID = new short[1] ;
         sMode5 = "";
         T000510_A4AttractionID = new short[1] ;
         T000510_A10SupplierID = new short[1] ;
         T000511_A4AttractionID = new short[1] ;
         T000511_A10SupplierID = new short[1] ;
         T00052_A4AttractionID = new short[1] ;
         T00052_A10SupplierID = new short[1] ;
         T000514_A4AttractionID = new short[1] ;
         T000514_A10SupplierID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000515_A4AttractionID = new short[1] ;
         T000516_A10SupplierID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.attractionsupplier__default(),
            new Object[][] {
                new Object[] {
               T00052_A4AttractionID, T00052_A10SupplierID
               }
               , new Object[] {
               T00053_A4AttractionID, T00053_A10SupplierID
               }
               , new Object[] {
               T00054_A4AttractionID
               }
               , new Object[] {
               T00055_A10SupplierID
               }
               , new Object[] {
               T00056_A4AttractionID, T00056_A10SupplierID
               }
               , new Object[] {
               T00057_A4AttractionID
               }
               , new Object[] {
               T00058_A10SupplierID
               }
               , new Object[] {
               T00059_A4AttractionID, T00059_A10SupplierID
               }
               , new Object[] {
               T000510_A4AttractionID, T000510_A10SupplierID
               }
               , new Object[] {
               T000511_A4AttractionID, T000511_A10SupplierID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000514_A4AttractionID, T000514_A10SupplierID
               }
               , new Object[] {
               T000515_A4AttractionID
               }
               , new Object[] {
               T000516_A10SupplierID
               }
            }
         );
      }

      private short Z4AttractionID ;
      private short Z10SupplierID ;
      private short GxWebError ;
      private short A4AttractionID ;
      private short A10SupplierID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short nIsDirty_5 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short ZZ4AttractionID ;
      private short ZZ10SupplierID ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtAttractionID_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtSupplierID_Enabled ;
      private int imgprompt_10_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtAttractionID_Internalname ;
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
      private String edtAttractionID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String edtSupplierID_Internalname ;
      private String edtSupplierID_Jsonclick ;
      private String imgprompt_10_Internalname ;
      private String imgprompt_10_Link ;
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
      private String sMode5 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00056_A4AttractionID ;
      private short[] T00056_A10SupplierID ;
      private short[] T00054_A4AttractionID ;
      private short[] T00055_A10SupplierID ;
      private short[] T00057_A4AttractionID ;
      private short[] T00058_A10SupplierID ;
      private short[] T00059_A4AttractionID ;
      private short[] T00059_A10SupplierID ;
      private short[] T00053_A4AttractionID ;
      private short[] T00053_A10SupplierID ;
      private short[] T000510_A4AttractionID ;
      private short[] T000510_A10SupplierID ;
      private short[] T000511_A4AttractionID ;
      private short[] T000511_A10SupplierID ;
      private short[] T00052_A4AttractionID ;
      private short[] T00052_A10SupplierID ;
      private short[] T000514_A4AttractionID ;
      private short[] T000514_A10SupplierID ;
      private short[] T000515_A4AttractionID ;
      private short[] T000516_A10SupplierID ;
      private GXWebForm Form ;
   }

   public class attractionsupplier__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
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
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@AttractionID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          new Object[] {"@SupplierID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [AttractionID], [SupplierID] FROM [AttractionSupplier] WITH (UPDLOCK) WHERE [AttractionID] = @AttractionID AND [SupplierID] = @SupplierID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00053", "SELECT [AttractionID], [SupplierID] FROM [AttractionSupplier] WHERE [AttractionID] = @AttractionID AND [SupplierID] = @SupplierID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00054", "SELECT [AttractionID] FROM [Attraction] WHERE [AttractionID] = @AttractionID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00055", "SELECT [SupplierID] FROM [Supplier] WHERE [SupplierID] = @SupplierID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00056", "SELECT TM1.[AttractionID], TM1.[SupplierID] FROM [AttractionSupplier] TM1 WHERE TM1.[AttractionID] = @AttractionID and TM1.[SupplierID] = @SupplierID ORDER BY TM1.[AttractionID], TM1.[SupplierID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00057", "SELECT [AttractionID] FROM [Attraction] WHERE [AttractionID] = @AttractionID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00058", "SELECT [SupplierID] FROM [Supplier] WHERE [SupplierID] = @SupplierID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00059", "SELECT [AttractionID], [SupplierID] FROM [AttractionSupplier] WHERE [AttractionID] = @AttractionID AND [SupplierID] = @SupplierID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000510", "SELECT TOP 1 [AttractionID], [SupplierID] FROM [AttractionSupplier] WHERE ( [AttractionID] > @AttractionID or [AttractionID] = @AttractionID and [SupplierID] > @SupplierID) ORDER BY [AttractionID], [SupplierID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000511", "SELECT TOP 1 [AttractionID], [SupplierID] FROM [AttractionSupplier] WHERE ( [AttractionID] < @AttractionID or [AttractionID] = @AttractionID and [SupplierID] < @SupplierID) ORDER BY [AttractionID] DESC, [SupplierID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000512", "INSERT INTO [AttractionSupplier]([AttractionID], [SupplierID]) VALUES(@AttractionID, @SupplierID)", GxErrorMask.GX_NOMASK,prmT000512)
             ,new CursorDef("T000513", "DELETE FROM [AttractionSupplier]  WHERE [AttractionID] = @AttractionID AND [SupplierID] = @SupplierID", GxErrorMask.GX_NOMASK,prmT000513)
             ,new CursorDef("T000514", "SELECT [AttractionID], [SupplierID] FROM [AttractionSupplier] ORDER BY [AttractionID], [SupplierID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000515", "SELECT [AttractionID] FROM [Attraction] WHERE [AttractionID] = @AttractionID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000516", "SELECT [SupplierID] FROM [Supplier] WHERE [SupplierID] = @SupplierID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
