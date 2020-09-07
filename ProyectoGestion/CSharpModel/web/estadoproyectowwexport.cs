/*
               File: EstadoProyectoWWExport
        Description: Estado Proyecto WWExport
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/25/2020 17:59:57.46
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estadoproyectowwexport : GXProcedure
   {
      public estadoproyectowwexport( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public estadoproyectowwexport( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_Filename ,
                           out String aP1_ErrorMessage )
      {
         this.AV11Filename = "" ;
         this.AV12ErrorMessage = "" ;
         initialize();
         executePrivate();
         aP0_Filename=this.AV11Filename;
         aP1_ErrorMessage=this.AV12ErrorMessage;
      }

      public String executeUdp( out String aP0_Filename )
      {
         execute(out aP0_Filename, out aP1_ErrorMessage);
         return AV12ErrorMessage ;
      }

      public void executeSubmit( out String aP0_Filename ,
                                 out String aP1_ErrorMessage )
      {
         estadoproyectowwexport objestadoproyectowwexport;
         objestadoproyectowwexport = new estadoproyectowwexport();
         objestadoproyectowwexport.AV11Filename = "" ;
         objestadoproyectowwexport.AV12ErrorMessage = "" ;
         objestadoproyectowwexport.context.SetSubmitInitialConfig(context);
         objestadoproyectowwexport.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objestadoproyectowwexport);
         aP0_Filename=this.AV11Filename;
         aP1_ErrorMessage=this.AV12ErrorMessage;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((estadoproyectowwexport)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'OPENDOCUMENT' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV13CellRow = 1;
         AV14FirstColumn = 1;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S201 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'WRITEFILTERS' */
         S131 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'WRITECOLUMNTITLES' */
         S141 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'WRITEDATA' */
         S161 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         /* Execute user subroutine: 'CLOSEDOCUMENT' */
         S191 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'OPENDOCUMENT' Routine */
         AV15Random = (int)(NumberUtil.Random( )*10000);
         AV11Filename = "EstadoProyectoWWExport-" + StringUtil.Trim( StringUtil.Str( (decimal)(AV15Random), 8, 0)) + ".xlsx";
         AV10ExcelDocument.Open(AV11Filename);
         /* Execute user subroutine: 'CHECKSTATUS' */
         S121 ();
         if (returnInSub) return;
         AV10ExcelDocument.Clear();
      }

      protected void S131( )
      {
         /* 'WRITEFILTERS' Routine */
         if ( AV32GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV29GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV32GridState.gxTpr_Dynamicfilters.Item(1));
            AV18DynamicFiltersSelector1 = AV29GridStateDynamicFilter.gxTpr_Selected;
            if ( StringUtil.StrCmp(AV18DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 )
            {
               AV19DynamicFiltersOperator1 = AV29GridStateDynamicFilter.gxTpr_Operator;
               AV20EstadoProyectoNombre1 = AV29GridStateDynamicFilter.gxTpr_Value;
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20EstadoProyectoNombre1)) )
               {
                  AV13CellRow = (int)(AV13CellRow+1);
                  AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
                  AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
                  if ( AV19DynamicFiltersOperator1 == 0 )
                  {
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                  }
                  else if ( AV19DynamicFiltersOperator1 == 1 )
                  {
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                  }
                  AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
                  AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Text = AV20EstadoProyectoNombre1;
               }
            }
            if ( AV32GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               AV21DynamicFiltersEnabled2 = true;
               AV29GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV32GridState.gxTpr_Dynamicfilters.Item(2));
               AV22DynamicFiltersSelector2 = AV29GridStateDynamicFilter.gxTpr_Selected;
               if ( StringUtil.StrCmp(AV22DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 )
               {
                  AV23DynamicFiltersOperator2 = AV29GridStateDynamicFilter.gxTpr_Operator;
                  AV24EstadoProyectoNombre2 = AV29GridStateDynamicFilter.gxTpr_Value;
                  if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24EstadoProyectoNombre2)) )
                  {
                     AV13CellRow = (int)(AV13CellRow+1);
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
                     if ( AV23DynamicFiltersOperator2 == 0 )
                     {
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                     }
                     else if ( AV23DynamicFiltersOperator2 == 1 )
                     {
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                     }
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
                     AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Text = AV24EstadoProyectoNombre2;
                  }
               }
               if ( AV32GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  AV25DynamicFiltersEnabled3 = true;
                  AV29GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV32GridState.gxTpr_Dynamicfilters.Item(3));
                  AV26DynamicFiltersSelector3 = AV29GridStateDynamicFilter.gxTpr_Selected;
                  if ( StringUtil.StrCmp(AV26DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 )
                  {
                     AV27DynamicFiltersOperator3 = AV29GridStateDynamicFilter.gxTpr_Operator;
                     AV28EstadoProyectoNombre3 = AV29GridStateDynamicFilter.gxTpr_Value;
                     if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28EstadoProyectoNombre3)) )
                     {
                        AV13CellRow = (int)(AV13CellRow+1);
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
                        if ( AV27DynamicFiltersOperator3 == 0 )
                        {
                           AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterLike", ""), "", "", "", "", "", "", "");
                        }
                        else if ( AV27DynamicFiltersOperator3 == 1 )
                        {
                           AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = StringUtil.Format( "%1 (%2)", context.GetMessage( "Proyecto Nombre", ""), context.GetMessage( "WWP_FilterContains", ""), "", "", "", "", "", "", "");
                        }
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
                        AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Text = AV28EstadoProyectoNombre3;
                     }
                  }
               }
            }
         }
         if ( ! ( (0==AV44TFEstadoProyectoID) && (0==AV45TFEstadoProyectoID_To) ) )
         {
            AV13CellRow = (int)(AV13CellRow+1);
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = context.GetMessage( "Proyecto ID", "");
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Number = AV44TFEstadoProyectoID;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+2, 1, 1).Bold = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+2, 1, 1).Color = 3;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+2, 1, 1).Text = context.GetMessage( "WWP_TSTo", "");
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+3, 1, 1).Italic = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+3, 1, 1).Number = AV45TFEstadoProyectoID_To;
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV47TFEstadoProyectoNombre_Sel)) ) )
         {
            AV13CellRow = (int)(AV13CellRow+1);
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = context.GetMessage( "Proyecto Nombre", "");
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Text = AV47TFEstadoProyectoNombre_Sel;
         }
         else
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV46TFEstadoProyectoNombre)) ) )
            {
               AV13CellRow = (int)(AV13CellRow+1);
               AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Bold = 1;
               AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Color = 3;
               AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn, 1, 1).Text = context.GetMessage( "Proyecto Nombre", "");
               AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Italic = 1;
               AV10ExcelDocument.get_Cells(AV13CellRow, AV14FirstColumn+1, 1, 1).Text = AV46TFEstadoProyectoNombre;
            }
         }
         AV13CellRow = (int)(AV13CellRow+2);
      }

      protected void S141( )
      {
         /* 'WRITECOLUMNTITLES' Routine */
         AV41VisibleColumnCount = 0;
         if ( StringUtil.StrCmp(AV30Session.Get("EstadoProyectoWWColumnsSelector"), "") != 0 )
         {
            AV36ColumnsSelectorXML = AV30Session.Get("EstadoProyectoWWColumnsSelector");
            AV34ColumnsSelector.FromXml(AV36ColumnsSelectorXML, null, "WWPColumnsSelector", "IS2");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S151 ();
            if (returnInSub) return;
         }
         if ( ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV34ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible )
         {
            AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV41VisibleColumnCount), 1, 1).Text = context.GetMessage( "Proyecto ID", "");
            AV41VisibleColumnCount = (long)(AV41VisibleColumnCount+1);
         }
         if ( ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV34ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible )
         {
            AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV41VisibleColumnCount), 1, 1).Text = context.GetMessage( "Proyecto Nombre", "");
            AV41VisibleColumnCount = (long)(AV41VisibleColumnCount+1);
         }
         AV48i = 1;
         while ( AV48i <= AV41VisibleColumnCount )
         {
            AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV48i-1), 1, 1).Bold = 1;
            AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV48i-1), 1, 1).Color = 11;
            AV48i = (long)(AV48i+1);
         }
      }

      protected void S161( )
      {
         /* 'WRITEDATA' Routine */
         AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV18DynamicFiltersSelector1;
         AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV19DynamicFiltersOperator1;
         AV54EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV20EstadoProyectoNombre1;
         AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV21DynamicFiltersEnabled2;
         AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV22DynamicFiltersSelector2;
         AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV23DynamicFiltersOperator2;
         AV58EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV24EstadoProyectoNombre2;
         AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV62EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV28EstadoProyectoNombre3;
         AV63EstadoProyectoWWDS_12_Tfestadoproyectoid = AV44TFEstadoProyectoID;
         AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV45TFEstadoProyectoID_To;
         AV65EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV46TFEstadoProyectoNombre;
         AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV47TFEstadoProyectoNombre_Sel;
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
                                              AV16OrderedBy ,
                                              AV17OrderedDsc } ,
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
         /* Using cursor P00102 */
         pr_default.execute(0, new Object[] {lV54EstadoProyectoWWDS_3_Estadoproyectonombre1, lV54EstadoProyectoWWDS_3_Estadoproyectonombre1, lV58EstadoProyectoWWDS_7_Estadoproyectonombre2, lV58EstadoProyectoWWDS_7_Estadoproyectonombre2, lV62EstadoProyectoWWDS_11_Estadoproyectonombre3, lV62EstadoProyectoWWDS_11_Estadoproyectonombre3, AV63EstadoProyectoWWDS_12_Tfestadoproyectoid, AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to, lV65EstadoProyectoWWDS_14_Tfestadoproyectonombre, AV66EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A7EstadoProyectoID = P00102_A7EstadoProyectoID[0];
            A34EstadoProyectoNombre = P00102_A34EstadoProyectoNombre[0];
            AV13CellRow = (int)(AV13CellRow+1);
            /* Execute user subroutine: 'BEFOREWRITELINE' */
            S172 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               returnInSub = true;
               if (true) return;
            }
            AV41VisibleColumnCount = 0;
            if ( ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV34ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible )
            {
               AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV41VisibleColumnCount), 1, 1).Number = A7EstadoProyectoID;
               AV41VisibleColumnCount = (long)(AV41VisibleColumnCount+1);
            }
            if ( ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV34ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible )
            {
               AV10ExcelDocument.get_Cells(AV13CellRow, (int)(AV14FirstColumn+AV41VisibleColumnCount), 1, 1).Text = A34EstadoProyectoNombre;
               AV41VisibleColumnCount = (long)(AV41VisibleColumnCount+1);
            }
            /* Execute user subroutine: 'AFTERWRITELINE' */
            S182 ();
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

      protected void S191( )
      {
         /* 'CLOSEDOCUMENT' Routine */
         AV10ExcelDocument.Save();
         /* Execute user subroutine: 'CHECKSTATUS' */
         S121 ();
         if (returnInSub) return;
         AV10ExcelDocument.Close();
      }

      protected void S121( )
      {
         /* 'CHECKSTATUS' Routine */
         if ( AV10ExcelDocument.ErrCode != 0 )
         {
            AV11Filename = "";
            AV12ErrorMessage = AV10ExcelDocument.ErrDescription;
            AV10ExcelDocument.Close();
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S151( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV34ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV34ColumnsSelector,  "Proyecto ID",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV34ColumnsSelector,  "Proyecto Nombre",  true) ;
         GXt_char1 = AV37UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "EstadoProyectoWWColumnsSelector", out  GXt_char1) ;
         AV37UserCustomValue = GXt_char1;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV37UserCustomValue)) ) )
         {
            AV35ColumnsSelectorAux.FromXml(AV37UserCustomValue, null, "WWPColumnsSelector", "IS2");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV35ColumnsSelectorAux, ref  AV34ColumnsSelector) ;
         }
      }

      protected void S201( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV30Session.Get("EstadoProyectoWWGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         AV16OrderedBy = AV32GridState.gxTpr_Orderedby;
         AV17OrderedDsc = AV32GridState.gxTpr_Ordereddsc;
         AV67GXV1 = 1;
         while ( AV67GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV67GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTOID") == 0 )
            {
               AV44TFEstadoProyectoID = (short)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
               AV45TFEstadoProyectoID_To = (short)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE") == 0 )
            {
               AV46TFEstadoProyectoNombre = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE_SEL") == 0 )
            {
               AV47TFEstadoProyectoNombre_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            AV67GXV1 = (int)(AV67GXV1+1);
         }
      }

      protected void S172( )
      {
         /* 'BEFOREWRITELINE' Routine */
      }

      protected void S182( )
      {
         /* 'AFTERWRITELINE' Routine */
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
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
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV10ExcelDocument = new ExcelDocumentI();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV29GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV18DynamicFiltersSelector1 = "";
         AV20EstadoProyectoNombre1 = "";
         AV22DynamicFiltersSelector2 = "";
         AV24EstadoProyectoNombre2 = "";
         AV26DynamicFiltersSelector3 = "";
         AV28EstadoProyectoNombre3 = "";
         AV47TFEstadoProyectoNombre_Sel = "";
         AV46TFEstadoProyectoNombre = "";
         AV30Session = context.GetSession();
         AV36ColumnsSelectorXML = "";
         AV34ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
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
         P00102_A7EstadoProyectoID = new short[1] ;
         P00102_A34EstadoProyectoNombre = new String[] {""} ;
         AV37UserCustomValue = "";
         GXt_char1 = "";
         AV35ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estadoproyectowwexport__default(),
            new Object[][] {
                new Object[] {
               P00102_A7EstadoProyectoID, P00102_A34EstadoProyectoNombre
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV19DynamicFiltersOperator1 ;
      private short AV23DynamicFiltersOperator2 ;
      private short AV27DynamicFiltersOperator3 ;
      private short AV44TFEstadoProyectoID ;
      private short AV45TFEstadoProyectoID_To ;
      private short AV53EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ;
      private short AV57EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ;
      private short AV61EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ;
      private short AV63EstadoProyectoWWDS_12_Tfestadoproyectoid ;
      private short AV64EstadoProyectoWWDS_13_Tfestadoproyectoid_to ;
      private short A7EstadoProyectoID ;
      private short AV16OrderedBy ;
      private int AV13CellRow ;
      private int AV14FirstColumn ;
      private int AV15Random ;
      private int AV67GXV1 ;
      private long AV41VisibleColumnCount ;
      private long AV48i ;
      private String AV20EstadoProyectoNombre1 ;
      private String AV24EstadoProyectoNombre2 ;
      private String AV28EstadoProyectoNombre3 ;
      private String AV47TFEstadoProyectoNombre_Sel ;
      private String AV46TFEstadoProyectoNombre ;
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
      private String GXt_char1 ;
      private bool returnInSub ;
      private bool AV21DynamicFiltersEnabled2 ;
      private bool AV25DynamicFiltersEnabled3 ;
      private bool AV55EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ;
      private bool AV59EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ;
      private bool AV17OrderedDsc ;
      private String AV36ColumnsSelectorXML ;
      private String AV37UserCustomValue ;
      private String AV12ErrorMessage ;
      private String AV11Filename ;
      private String AV18DynamicFiltersSelector1 ;
      private String AV22DynamicFiltersSelector2 ;
      private String AV26DynamicFiltersSelector3 ;
      private String AV52EstadoProyectoWWDS_1_Dynamicfiltersselector1 ;
      private String AV56EstadoProyectoWWDS_5_Dynamicfiltersselector2 ;
      private String AV60EstadoProyectoWWDS_9_Dynamicfiltersselector3 ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00102_A7EstadoProyectoID ;
      private String[] P00102_A34EstadoProyectoNombre ;
      private String aP0_Filename ;
      private String aP1_ErrorMessage ;
      private ExcelDocumentI AV10ExcelDocument ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV29GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV34ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV35ColumnsSelectorAux ;
   }

   public class estadoproyectowwexport__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00102( IGxContext context ,
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
                                             short AV16OrderedBy ,
                                             bool AV17OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [10] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
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
            GXv_int2[0] = 1;
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
            GXv_int2[1] = 1;
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
            GXv_int2[2] = 1;
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
            GXv_int2[3] = 1;
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
            GXv_int2[4] = 1;
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
            GXv_int2[5] = 1;
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
            GXv_int2[6] = 1;
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
            GXv_int2[7] = 1;
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
            GXv_int2[8] = 1;
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
            GXv_int2[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV16OrderedBy == 1 ) && ! AV17OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoNombre]";
         }
         else if ( ( AV16OrderedBy == 1 ) && ( AV17OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoNombre] DESC";
         }
         else if ( ( AV16OrderedBy == 2 ) && ! AV17OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoID]";
         }
         else if ( ( AV16OrderedBy == 2 ) && ( AV17OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoID] DESC";
         }
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00102(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (bool)dynConstraints[18] );
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
          Object[] prmP00102 ;
          prmP00102 = new Object[] {
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
              new CursorDef("P00102", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00102,100, GxCacheFrequency.OFF ,true,false )
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
