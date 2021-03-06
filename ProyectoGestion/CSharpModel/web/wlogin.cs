/*
               File: Wlogin
        Description: Wlogin
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:55.57
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
   public class wlogin : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public wlogin( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wlogin( IGxContext context )
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
            ValidateSpaRequest();
            PA0F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               edtavTexterror_Enabled = 0;
               AssignProp("", false, edtavTexterror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror_Enabled), 5, 0), true);
               edtavTexterror2_Enabled = 0;
               AssignProp("", false, edtavTexterror2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror2_Enabled), 5, 0), true);
               edtavLoginerror_Enabled = 0;
               AssignProp("", false, edtavLoginerror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLoginerror_Enabled), 5, 0), true);
               WS0F2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE0F2( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( context.GetMessage( "Wlogin", "")) ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202082421275560", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wlogin.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_NAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A9Name, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PASSWORD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A10Password, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "NAME", StringUtil.RTrim( A9Name));
         GxWebStd.gx_hidden_field( context, "gxhash_NAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A9Name, "")), context));
         GxWebStd.gx_hidden_field( context, "PASSWORD", StringUtil.RTrim( A10Password));
         GxWebStd.gx_hidden_field( context, "gxhash_PASSWORD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A10Password, "")), context));
         GxWebStd.gx_hidden_field( context, "ROLESNAME", StringUtil.RTrim( A15RolesName));
      }

      protected void RenderHtmlCloseForm0F2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "Wlogin" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Wlogin", "") ;
      }

      protected void WB0F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            wb_table1_6_0F2( true) ;
         }
         else
         {
            wb_table1_6_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_6_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttIniciar_Internalname, "", context.GetMessage( "Iniciar", ""), bttIniciar_Jsonclick, 5, context.GetMessage( "Iniciar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'INICIAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavLoginerror_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLoginerror_Internalname, StringUtil.RTrim( AV5LoginError), StringUtil.RTrim( context.localUtil.Format( AV5LoginError, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLoginerror_Jsonclick, 0, "TextActionAttribute", "", "", "", "", 1, edtavLoginerror_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Wlogin", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "'INICIAR'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'Iniciar' */
                           E110F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E120F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
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
                           dynload_actions( ) ;
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

      protected void WE0F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0F2( ) ;
            }
         }
      }

      protected void PA0F2( )
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
               GX_FocusControl = edtavUsuario_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavTexterror_Enabled = 0;
         AssignProp("", false, edtavTexterror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror_Enabled), 5, 0), true);
         edtavTexterror2_Enabled = 0;
         AssignProp("", false, edtavTexterror2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror2_Enabled), 5, 0), true);
         edtavLoginerror_Enabled = 0;
         AssignProp("", false, edtavLoginerror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLoginerror_Enabled), 5, 0), true);
      }

      protected void RF0F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E120F2 ();
            WB0F0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0F2( )
      {
         GxWebStd.gx_hidden_field( context, "NAME", StringUtil.RTrim( A9Name));
         GxWebStd.gx_hidden_field( context, "gxhash_NAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A9Name, "")), context));
         GxWebStd.gx_hidden_field( context, "PASSWORD", StringUtil.RTrim( A10Password));
         GxWebStd.gx_hidden_field( context, "gxhash_PASSWORD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A10Password, "")), context));
      }

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavTexterror_Enabled = 0;
         AssignProp("", false, edtavTexterror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror_Enabled), 5, 0), true);
         edtavTexterror2_Enabled = 0;
         AssignProp("", false, edtavTexterror2_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavTexterror2_Enabled), 5, 0), true);
         edtavLoginerror_Enabled = 0;
         AssignProp("", false, edtavLoginerror_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavLoginerror_Enabled), 5, 0), true);
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            /* Read variables values. */
            AV10usuario = cgiGet( edtavUsuario_Internalname);
            AssignAttri("", false, "AV10usuario", AV10usuario);
            AV8textError = cgiGet( edtavTexterror_Internalname);
            AssignAttri("", false, "AV8textError", AV8textError);
            AV6password = cgiGet( edtavPassword_Internalname);
            AssignAttri("", false, "AV6password", AV6password);
            AV9textError2 = cgiGet( edtavTexterror2_Internalname);
            AssignAttri("", false, "AV9textError2", AV9textError2);
            AV5LoginError = cgiGet( edtavLoginerror_Internalname);
            AssignAttri("", false, "AV5LoginError", AV5LoginError);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E110F2( )
      {
         /* 'Iniciar' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10usuario)) && String.IsNullOrEmpty(StringUtil.RTrim( AV6password)) )
         {
            AV8textError = context.GetMessage( "Campo Obligatorio", "");
            AssignAttri("", false, "AV8textError", AV8textError);
            AV9textError2 = context.GetMessage( "Campo Obligatorio ", "");
            AssignAttri("", false, "AV9textError2", AV9textError2);
         }
         else
         {
            AV14GXLvl6 = 0;
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {AV10usuario, AV6password});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A2RolesID = H000F2_A2RolesID[0];
               A10Password = H000F2_A10Password[0];
               A9Name = H000F2_A9Name[0];
               A15RolesName = H000F2_A15RolesName[0];
               A15RolesName = H000F2_A15RolesName[0];
               AV14GXLvl6 = 1;
               AV11idUser = A15RolesName;
               CallWebObject(formatLink("wwdasboard.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11idUser)));
               context.wjLocDisableFrm = 1;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV14GXLvl6 == 0 )
            {
               AV5LoginError = context.GetMessage( "Error-Credenciales", "");
               AssignAttri("", false, "AV5LoginError", AV5LoginError);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E120F2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_6_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "FormContainer", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Iniciar Sesion", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "BigTitle", 0, "", 1, 1, 0, "HLP_Wlogin.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavUsuario_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavUsuario_Internalname, context.GetMessage( "Usuario", ""), "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUsuario_Internalname, StringUtil.RTrim( AV10usuario), StringUtil.RTrim( context.localUtil.Format( AV10usuario, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,14);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUsuario_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavUsuario_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "Name", "left", true, "", "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavTexterror_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTexterror_Internalname, StringUtil.RTrim( AV8textError), StringUtil.RTrim( context.localUtil.Format( AV8textError, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,18);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTexterror_Jsonclick, 0, "ErrorAttribute", "", "", "", "", 1, edtavTexterror_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavPassword_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPassword_Internalname, context.GetMessage( "Contraseņa", ""), "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPassword_Internalname, StringUtil.RTrim( AV6password), StringUtil.RTrim( context.localUtil.Format( AV6password, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,23);\""+" "+"data-gx-password-reveal"+" ", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPassword_Enabled, 0, "text", "", 40, "chr", 1, "row", 20, -1, 0, 0, 1, 0, -1, true, "", "left", true, "", "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavTexterror2_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTexterror2_Internalname, StringUtil.RTrim( AV9textError2), StringUtil.RTrim( context.localUtil.Format( AV9textError2, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTexterror2_Jsonclick, 0, "ErrorAttribute", "", "", "", "", 1, edtavTexterror2_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Wlogin.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_6_0F2e( true) ;
         }
         else
         {
            wb_table1_6_0F2e( false) ;
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
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202082421275576", true, true);
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
         context.AddJavascriptSource("wlogin.js", "?202082421275576", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         edtavUsuario_Internalname = "vUSUARIO";
         edtavTexterror_Internalname = "vTEXTERROR";
         edtavPassword_Internalname = "vPASSWORD";
         edtavTexterror2_Internalname = "vTEXTERROR2";
         tblTable1_Internalname = "TABLE1";
         bttIniciar_Internalname = "INICIAR";
         edtavLoginerror_Internalname = "vLOGINERROR";
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
         edtavTexterror2_Jsonclick = "";
         edtavTexterror2_Enabled = 1;
         edtavPassword_Jsonclick = "";
         edtavPassword_Enabled = 1;
         edtavTexterror_Jsonclick = "";
         edtavTexterror_Enabled = 1;
         edtavUsuario_Jsonclick = "";
         edtavUsuario_Enabled = 1;
         edtavLoginerror_Jsonclick = "";
         edtavLoginerror_Enabled = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A9Name',fld:'NAME',pic:'',hsh:true},{av:'A10Password',fld:'PASSWORD',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'INICIAR'","{handler:'E110F2',iparms:[{av:'AV10usuario',fld:'vUSUARIO',pic:''},{av:'AV6password',fld:'vPASSWORD',pic:''},{av:'A9Name',fld:'NAME',pic:'',hsh:true},{av:'A10Password',fld:'PASSWORD',pic:'',hsh:true},{av:'A15RolesName',fld:'ROLESNAME',pic:''}]");
         setEventMetadata("'INICIAR'",",oparms:[{av:'AV8textError',fld:'vTEXTERROR',pic:''},{av:'AV9textError2',fld:'vTEXTERROR2',pic:''},{av:'AV5LoginError',fld:'vLOGINERROR',pic:''}]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         A9Name = "";
         A10Password = "";
         GXKey = "";
         A15RolesName = "";
         GX_FocusControl = "";
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttIniciar_Jsonclick = "";
         AV5LoginError = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV10usuario = "";
         AV8textError = "";
         AV6password = "";
         AV9textError2 = "";
         scmdbuf = "";
         H000F2_A1UsuarioID = new short[1] ;
         H000F2_A2RolesID = new short[1] ;
         H000F2_A10Password = new String[] {""} ;
         H000F2_A9Name = new String[] {""} ;
         H000F2_A15RolesName = new String[] {""} ;
         AV11idUser = "";
         sStyleString = "";
         lblTextblock1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wlogin__default(),
            new Object[][] {
                new Object[] {
               H000F2_A1UsuarioID, H000F2_A2RolesID, H000F2_A10Password, H000F2_A9Name, H000F2_A15RolesName
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavTexterror_Enabled = 0;
         edtavTexterror2_Enabled = 0;
         edtavLoginerror_Enabled = 0;
      }

      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV14GXLvl6 ;
      private short A2RolesID ;
      private short nGXWrapped ;
      private int edtavTexterror_Enabled ;
      private int edtavTexterror2_Enabled ;
      private int edtavLoginerror_Enabled ;
      private int edtavUsuario_Enabled ;
      private int edtavPassword_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String edtavTexterror_Internalname ;
      private String edtavTexterror2_Internalname ;
      private String edtavLoginerror_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String A9Name ;
      private String A10Password ;
      private String GXKey ;
      private String A15RolesName ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttIniciar_Internalname ;
      private String bttIniciar_Jsonclick ;
      private String AV5LoginError ;
      private String edtavLoginerror_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsuario_Internalname ;
      private String AV10usuario ;
      private String AV8textError ;
      private String AV6password ;
      private String edtavPassword_Internalname ;
      private String AV9textError2 ;
      private String scmdbuf ;
      private String AV11idUser ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavUsuario_Jsonclick ;
      private String edtavTexterror_Jsonclick ;
      private String edtavPassword_Jsonclick ;
      private String edtavTexterror2_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000F2_A1UsuarioID ;
      private short[] H000F2_A2RolesID ;
      private String[] H000F2_A10Password ;
      private String[] H000F2_A9Name ;
      private String[] H000F2_A15RolesName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class wlogin__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"@AV10usuario",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV6password",SqlDbType.NChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "SELECT T1.[UsuarioID], T1.[RolesID], T1.[Password], T1.[Name], T2.[RolesName] FROM ([Usuario] T1 INNER JOIN [Roles] T2 ON T2.[RolesID] = T1.[RolesID]) WHERE (T1.[Name] = @AV10usuario) AND (T1.[Password] = @AV6password) ORDER BY T1.[UsuarioID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 40) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
