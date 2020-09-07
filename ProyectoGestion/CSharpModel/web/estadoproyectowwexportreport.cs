/*
               File: EstadoProyectoWWExportReport
        Description: Estado Proyecto WWExport Report
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:51.27
       Program type: HTTP procedure
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
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estadoproyectowwexportreport : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public estadoproyectowwexportreport( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public estadoproyectowwexportreport( IGxContext context )
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
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         estadoproyectowwexportreport objestadoproyectowwexportreport;
         objestadoproyectowwexportreport = new estadoproyectowwexportreport();
         objestadoproyectowwexportreport.context.SetSubmitInitialConfig(context);
         objestadoproyectowwexportreport.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objestadoproyectowwexportreport);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((estadoproyectowwexportreport)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         M_top = 0;
         M_bot = 6;
         P_lines = (int)(66-M_bot);
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15;
         PrtOffset = 0;
         gxXPage = 100;
         gxYPage = 100;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 1, 15840, 12240, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6));
            Gx_line = (int)(P_lines+1);
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S151 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            AV45Title = context.GetMessage( "Estado Proyecto List", "");
            /* Execute user subroutine: 'PRINTFILTERS' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'PRINTCOLUMNTITLES' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'PRINTDATA' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'PRINTFOOTER' */
            S171 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H110( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'PRINTFILTERS' Routine */
         if ( AV28GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV25GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV28GridState.gxTpr_Dynamicfilters.Item(1));
            AV12DynamicFiltersSelector1 = AV25GridStateDynamicFilter.gxTpr_Selected;
            if ( StringUtil.StrCmp(AV12DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 )
            {
               AV13DynamicFiltersOperator1 = AV25GridStateDynamicFilter.gxTpr_Operator;
               AV14EstadoProyectoNombre1 = AV25GridStateDynamicFilter.gxTpr_Value;
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14EstadoProyectoNombre1)) )
               {
                  if ( AV13DynamicFiltersOperator1 == 0 )
                  {
                     AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                  }
                  else if ( AV13DynamicFiltersOperator1 == 1 )
                  {
                     AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                  }
                  AV16EstadoProyectoNombre = AV14EstadoProyectoNombre1;
                  H110( false, 20) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15FilterEstadoProyectoNombreDescription, "")), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV16EstadoProyectoNombre, "")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+20);
               }
            }
            if ( AV28GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               AV17DynamicFiltersEnabled2 = true;
               AV25GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV28GridState.gxTpr_Dynamicfilters.Item(2));
               AV18DynamicFiltersSelector2 = AV25GridStateDynamicFilter.gxTpr_Selected;
               if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 )
               {
                  AV19DynamicFiltersOperator2 = AV25GridStateDynamicFilter.gxTpr_Operator;
                  AV20EstadoProyectoNombre2 = AV25GridStateDynamicFilter.gxTpr_Value;
                  if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20EstadoProyectoNombre2)) )
                  {
                     if ( AV19DynamicFiltersOperator2 == 0 )
                     {
                        AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                     }
                     else if ( AV19DynamicFiltersOperator2 == 1 )
                     {
                        AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                     }
                     AV16EstadoProyectoNombre = AV20EstadoProyectoNombre2;
                     H110( false, 20) ;
                     getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15FilterEstadoProyectoNombreDescription, "")), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
                     getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV16EstadoProyectoNombre, "")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
                     Gx_OldLine = Gx_line;
                     Gx_line = (int)(Gx_line+20);
                  }
               }
               if ( AV28GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  AV21DynamicFiltersEnabled3 = true;
                  AV25GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV28GridState.gxTpr_Dynamicfilters.Item(3));
                  AV22DynamicFiltersSelector3 = AV25GridStateDynamicFilter.gxTpr_Selected;
                  if ( StringUtil.StrCmp(AV22DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 )
                  {
                     AV23DynamicFiltersOperator3 = AV25GridStateDynamicFilter.gxTpr_Operator;
                     AV24EstadoProyectoNombre3 = AV25GridStateDynamicFilter.gxTpr_Value;
                     if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24EstadoProyectoNombre3)) )
                     {
                        if ( AV23DynamicFiltersOperator3 == 0 )
                        {
                           AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                        }
                        else if ( AV23DynamicFiltersOperator3 == 1 )
                        {
                           AV15FilterEstadoProyectoNombreDescription = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                        }
                        AV16EstadoProyectoNombre = AV24EstadoProyectoNombre3;
                        H110( false, 20) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15FilterEstadoProyectoNombreDescription, "")), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV16EstadoProyectoNombre, "")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
                        Gx_OldLine = Gx_line;
                        Gx_line = (int)(Gx_line+20);
                     }
                  }
               }
            }
         }
         if ( ! ( (0==AV30TFEstadoProyectoID) && (0==AV31TFEstadoProyectoID_To) ) )
         {
            H110( false, 20) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.GetMessage( "Proyecto ID", ""), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30TFEstadoProyectoID), "ZZZ9")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+20);
            AV34TFEstadoProyectoID_To_Description = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto ID", ""), context.GetMessage( "WWP_TSTo", ""), "", "", "", "", "", "", "");
            H110( false, 20) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV34TFEstadoProyectoID_To_Description, "")), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV31TFEstadoProyectoID_To), "ZZZ9")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+20);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFEstadoProyectoNombre_Sel)) )
         {
            H110( false, 20) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.GetMessage( "Proyecto Nombre", ""), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV33TFEstadoProyectoNombre_Sel, "")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+20);
         }
         else
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV32TFEstadoProyectoNombre)) )
            {
               H110( false, 20) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 169, 169, 169, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(context.GetMessage( "Proyecto Nombre", ""), 25, Gx_line+0, 229, Gx_line+15, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV32TFEstadoProyectoNombre, "")), 229, Gx_line+0, 789, Gx_line+15, 0, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+20);
            }
         }
      }

      protected void S121( )
      {
         /* 'PRINTCOLUMNTITLES' Routine */
         H110( false, 22) ;
         getPrinter().GxDrawLine(25, Gx_line+21, 789, Gx_line+21, 2, 217, 83, 79, 0) ;
         Gx_OldLine = Gx_line;
         Gx_line = (int)(Gx_line+22);
         H110( false, 37) ;
         getPrinter().GxAttris("Microsoft Sans Serif", 9, false, false, false, false, 0, 217, 83, 79, 0, 255, 255, 255) ;
         getPrinter().GxDrawText(context.GetMessage( "Proyecto ID", ""), 30, Gx_line+10, 281, Gx_line+27, 2, 0, 0, 0) ;
         getPrinter().GxDrawText(context.GetMessage( "Proyecto Nombre", ""), 285, Gx_line+10, 787, Gx_line+27, 0, 0, 0, 0) ;
         Gx_OldLine = Gx_line;
         Gx_line = (int)(Gx_line+37);
      }

      protected void S131( )
      {
         /* 'PRINTDATA' Routine */
         AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV12DynamicFiltersSelector1;
         AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV13DynamicFiltersOperator1;
         AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV14EstadoProyectoNombre1;
         AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV17DynamicFiltersEnabled2;
         AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV18DynamicFiltersSelector2;
         AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV19DynamicFiltersOperator2;
         AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV20EstadoProyectoNombre2;
         AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV21DynamicFiltersEnabled3;
         AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV22DynamicFiltersSelector3;
         AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV23DynamicFiltersOperator3;
         AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV24EstadoProyectoNombre3;
         AV63EstadoProyectoWWDS_12_Tfestadoproyectoid = AV30TFEstadoProyectoID;
         AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV31TFEstadoProyectoID_To;
         AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV32TFEstadoProyectoNombre;
         AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV33TFEstadoProyectoNombre_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                              AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                              AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                              AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                              AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                              AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                              AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                              AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                              AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                              AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                              AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                              AV63EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                              AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                              AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                              AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                              A34EstadoProyectoNombre ,
                                              A7EstadoProyectoID ,
                                              AV10OrderedBy ,
                                              AV11OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV54EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV54EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV58EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV58EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV62EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV62EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre = StringUtil.PadR( StringUtil.RTrim( AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre), 40, "%");
         /* Using cursor P00112 */
         pr_default.execute(0, new Object[] {lV54EstadoProyectoWWDS_3_Estadoproyectonombre1, lV54EstadoProyectoWWDS_3_Estadoproyectonombre1, lV58EstadoProyectoWWDS_7_Estadoproyectonombre2, lV58EstadoProyectoWWDS_7_Estadoproyectonombre2, lV62EstadoProyectoWWDS_11_Estadoproyectonombre3, lV62EstadoProyectoWWDS_11_Estadoproyectonombre3, AV63EstadoProyectoWWDS_12_Tfestadoproyectoid, AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to, lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre, AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EstadoProyectoID = P00112_A7EstadoProyectoID[0];
            A34EstadoProyectoNombre = P00112_A34EstadoProyectoNombre[0];
            /* Execute user subroutine: 'BEFOREPRINTLINE' */
            S144 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               returnInSub = true;
               if (true) return;
            }
            H110( false, 36) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A7EstadoProyectoID), "ZZZ9")), 30, Gx_line+10, 281, Gx_line+25, 2, 0, 0, 0) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A34EstadoProyectoNombre, "")), 285, Gx_line+10, 787, Gx_line+25, 0, 0, 0, 0) ;
            getPrinter().GxDrawLine(28, Gx_line+35, 789, Gx_line+35, 1, 220, 220, 220, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+36);
            /* Execute user subroutine: 'AFTERPRINTLINE' */
            S161 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               returnInSub = true;
               if (true) return;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void S151( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV26Session.Get("EstadoProyectoWWGridState"), "") == 0 )
         {
            AV28GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         else
         {
            AV28GridState.FromXml(AV26Session.Get("EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         AV10OrderedBy = AV28GridState.gxTpr_Orderedby;
         AV11OrderedDsc = AV28GridState.gxTpr_Ordereddsc;
         AV67GXV1 = 1;
         while ( AV67GXV1 <= AV28GridState.gxTpr_Filtervalues.Count )
         {
            AV29GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV28GridState.gxTpr_Filtervalues.Item(AV67GXV1));
            if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTOID") == 0 )
            {
               AV30TFEstadoProyectoID = (short)(NumberUtil.Val( AV29GridStateFilterValue.gxTpr_Value, "."));
               AV31TFEstadoProyectoID_To = (short)(NumberUtil.Val( AV29GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE") == 0 )
            {
               AV32TFEstadoProyectoNombre = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE_SEL") == 0 )
            {
               AV33TFEstadoProyectoNombre_Sel = AV29GridStateFilterValue.gxTpr_Value;
            }
            AV67GXV1 = (int)(AV67GXV1+1);
         }
      }

      protected void S144( )
      {
         /* 'BEFOREPRINTLINE' Routine */
      }

      protected void S161( )
      {
         /* 'AFTERPRINTLINE' Routine */
      }

      protected void S171( )
      {
         /* 'PRINTFOOTER' Routine */
      }

      protected void H110( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines;
                  AV43PageInfo = context.GetMessage( "Page: ", "") + StringUtil.Trim( StringUtil.Str( (decimal)(Gx_page), 6, 0));
                  AV40DateInfo = context.GetMessage( "Date: ", "") + context.localUtil.Format( Gx_date, "99/99/99");
                  getPrinter().GxDrawRect(0, Gx_line+5, 819, Gx_line+40, 1, 0, 0, 0, 1, 217, 83, 79, 1, 1, 1, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 255, 255, 255, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV43PageInfo, "")), 30, Gx_line+15, 409, Gx_line+30, 0, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV40DateInfo, "")), 409, Gx_line+15, 789, Gx_line+30, 2, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+40);
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0;
               Gx_line = 0;
               Gx_page = (int)(Gx_page+1);
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight));
               /* Print headers */
               getPrinter().GxStartPage() ;
               AV38AppName = context.GetMessage( "DVelop Software Solutions", "");
               AV44Phone = "+1 550 8923";
               AV42Mail = "info@mail.com";
               AV46Website = "http://www.web.com";
               AV35AddressLine1 = "French Boulevard 2859";
               AV36AddressLine2 = "Downtown";
               AV37AddressLine3 = "Paris, France";
               getPrinter().GxDrawRect(0, Gx_line+0, 819, Gx_line+108, 1, 0, 0, 0, 1, 217, 83, 79, 1, 1, 1, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 255, 255, 255, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV38AppName, "")), 30, Gx_line+30, 283, Gx_line+45, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 20, false, false, false, false, 0, 255, 255, 255, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV45Title, "")), 30, Gx_line+45, 283, Gx_line+78, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 255, 255, 255, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV44Phone, "")), 283, Gx_line+30, 536, Gx_line+46, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV42Mail, "")), 283, Gx_line+46, 536, Gx_line+62, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV46Website, "")), 283, Gx_line+62, 536, Gx_line+78, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV35AddressLine1, "")), 536, Gx_line+30, 789, Gx_line+46, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV36AddressLine2, "")), 536, Gx_line+46, 789, Gx_line+62, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV37AddressLine3, "")), 536, Gx_line+62, 789, Gx_line+78, 2, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+128);
               if (true) break;
            }
            else
            {
               PrtOffset = 0;
               Gx_line = (int)(Gx_line+1);
            }
            ToSkip = (int)(ToSkip-1);
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         GXKey = "";
         gxfirstwebparm = "";
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV45Title = "";
         AV28GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV25GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV12DynamicFiltersSelector1 = "";
         AV14EstadoProyectoNombre1 = "";
         AV15FilterEstadoProyectoNombreDescription = "";
         AV16EstadoProyectoNombre = "";
         AV18DynamicFiltersSelector2 = "";
         AV20EstadoProyectoNombre2 = "";
         AV22DynamicFiltersSelector3 = "";
         AV24EstadoProyectoNombre3 = "";
         AV34TFEstadoProyectoID_To_Description = "";
         AV33TFEstadoProyectoNombre_Sel = "";
         AV32TFEstadoProyectoNombre = "";
         AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 = "";
         AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 = "";
         AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 = "";
         AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = "";
         scmdbuf = "";
         lV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         lV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         lV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         A34EstadoProyectoNombre = "";
         P00112_A7EstadoProyectoID = new short[1] ;
         P00112_A34EstadoProyectoNombre = new String[] {""} ;
         AV26Session = context.GetSession();
         AV29GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV43PageInfo = "";
         AV40DateInfo = "";
         Gx_date = DateTime.MinValue;
         AV38AppName = "";
         AV44Phone = "";
         AV42Mail = "";
         AV46Website = "";
         AV35AddressLine1 = "";
         AV36AddressLine2 = "";
         AV37AddressLine3 = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estadoproyectowwexportreport__default(),
            new Object[][] {
                new Object[] {
               P00112_A7EstadoProyectoID, P00112_A34EstadoProyectoNombre
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_line = 0;
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV13DynamicFiltersOperator1 ;
      private short AV19DynamicFiltersOperator2 ;
      private short AV23DynamicFiltersOperator3 ;
      private short AV30TFEstadoProyectoID ;
      private short AV31TFEstadoProyectoID_To ;
      private short AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ;
      private short AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ;
      private short AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ;
      private short AV63EstadoProyectoWWDS_12_Tfestadoproyectoid ;
      private short AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to ;
      private short A7EstadoProyectoID ;
      private short AV10OrderedBy ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private int AV67GXV1 ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV14EstadoProyectoNombre1 ;
      private String AV16EstadoProyectoNombre ;
      private String AV20EstadoProyectoNombre2 ;
      private String AV24EstadoProyectoNombre3 ;
      private String AV33TFEstadoProyectoNombre_Sel ;
      private String AV32TFEstadoProyectoNombre ;
      private String AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ;
      private String scmdbuf ;
      private String lV54EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String lV58EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String lV62EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String A34EstadoProyectoNombre ;
      private DateTime Gx_date ;
      private bool entryPointCalled ;
      private bool returnInSub ;
      private bool AV17DynamicFiltersEnabled2 ;
      private bool AV21DynamicFiltersEnabled3 ;
      private bool AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ;
      private bool AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ;
      private bool AV11OrderedDsc ;
      private String AV45Title ;
      private String AV12DynamicFiltersSelector1 ;
      private String AV15FilterEstadoProyectoNombreDescription ;
      private String AV18DynamicFiltersSelector2 ;
      private String AV22DynamicFiltersSelector3 ;
      private String AV34TFEstadoProyectoID_To_Description ;
      private String AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 ;
      private String AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 ;
      private String AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 ;
      private String AV43PageInfo ;
      private String AV40DateInfo ;
      private String AV38AppName ;
      private String AV44Phone ;
      private String AV42Mail ;
      private String AV46Website ;
      private String AV35AddressLine1 ;
      private String AV36AddressLine2 ;
      private String AV37AddressLine3 ;
      private IGxSession AV26Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00112_A7EstadoProyectoID ;
      private String[] P00112_A34EstadoProyectoNombre ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV28GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV29GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV25GridStateDynamicFilter ;
   }

   public class estadoproyectowwexportreport__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00112( IGxContext context ,
                                             String AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                             short AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                             String AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                             bool AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                             String AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                             short AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                             String AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                             bool AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                             String AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                             short AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                             String AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                             short AV63EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                             short AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                             String AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                             String AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                             String A34EstadoProyectoNombre ,
                                             short A7EstadoProyectoID ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [EstadoProyectoID], [EstadoProyectoNombre] FROM [EstadoProyecto]";
         if ( ( StringUtil.StrCmp(AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV54EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV54EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV54EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV54EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV58EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV58EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV58EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV58EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV62EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV62EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV62EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV62EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV63EstadoProyectoWWDS_12_Tfestadoproyectoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] >= @AV63EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] >= @AV63EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( ! (0==AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] <= @AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] <= @AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] = @AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] = @AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoNombre]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoNombre] DESC";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoID]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoID] DESC";
         }
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00112(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (bool)dynConstraints[18] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP00112 ;
          prmP00112 = new Object[] {
          new Object[] {"@lV54EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV54EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV58EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV58EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV62EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV62EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV63EstadoProyectoWWDS_12_Tfestadoproyectoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel",SqlDbType.NChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00112", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00112,100, GxCacheFrequency.OFF ,true,false )
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
