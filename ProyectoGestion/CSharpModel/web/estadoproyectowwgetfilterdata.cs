/*
               File: EstadoProyectoWWGetFilterData
        Description: Estado Proyecto WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:50.58
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estadoproyectowwgetfilterdata : GXProcedure
   {
      public estadoproyectowwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public estadoproyectowwgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV16DDOName = aP0_DDOName;
         this.AV14SearchTxt = aP1_SearchTxt;
         this.AV15SearchTxtTo = aP2_SearchTxtTo;
         this.AV20OptionsJson = "" ;
         this.AV23OptionsDescJson = "" ;
         this.AV25OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         execute(aP0_DDOName, aP1_SearchTxt, aP2_SearchTxtTo, out aP3_OptionsJson, out aP4_OptionsDescJson, out aP5_OptionIndexesJson);
         return AV25OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         estadoproyectowwgetfilterdata objestadoproyectowwgetfilterdata;
         objestadoproyectowwgetfilterdata = new estadoproyectowwgetfilterdata();
         objestadoproyectowwgetfilterdata.AV16DDOName = aP0_DDOName;
         objestadoproyectowwgetfilterdata.AV14SearchTxt = aP1_SearchTxt;
         objestadoproyectowwgetfilterdata.AV15SearchTxtTo = aP2_SearchTxtTo;
         objestadoproyectowwgetfilterdata.AV20OptionsJson = "" ;
         objestadoproyectowwgetfilterdata.AV23OptionsDescJson = "" ;
         objestadoproyectowwgetfilterdata.AV25OptionIndexesJson = "" ;
         objestadoproyectowwgetfilterdata.context.SetSubmitInitialConfig(context);
         objestadoproyectowwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objestadoproyectowwgetfilterdata);
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((estadoproyectowwgetfilterdata)stateInfo).executePrivate();
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
         AV19Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV22OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV24OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV16DDOName), "DDO_ESTADOPROYECTONOMBRE") == 0 )
         {
            /* Execute user subroutine: 'LOADESTADOPROYECTONOMBREOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV20OptionsJson = AV19Options.ToJSonString(false);
         AV23OptionsDescJson = AV22OptionsDesc.ToJSonString(false);
         AV25OptionIndexesJson = AV24OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV27Session.Get("EstadoProyectoWWGridState"), "") == 0 )
         {
            AV29GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         else
         {
            AV29GridState.FromXml(AV27Session.Get("EstadoProyectoWWGridState"), null, "WWPGridState", "IS2");
         }
         AV45GXV1 = 1;
         while ( AV45GXV1 <= AV29GridState.gxTpr_Filtervalues.Count )
         {
            AV30GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV29GridState.gxTpr_Filtervalues.Item(AV45GXV1));
            if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTOID") == 0 )
            {
               AV10TFEstadoProyectoID = (short)(NumberUtil.Val( AV30GridStateFilterValue.gxTpr_Value, "."));
               AV11TFEstadoProyectoID_To = (short)(NumberUtil.Val( AV30GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE") == 0 )
            {
               AV12TFEstadoProyectoNombre = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFESTADOPROYECTONOMBRE_SEL") == 0 )
            {
               AV13TFEstadoProyectoNombre_Sel = AV30GridStateFilterValue.gxTpr_Value;
            }
            AV45GXV1 = (int)(AV45GXV1+1);
         }
         if ( AV29GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV31GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV29GridState.gxTpr_Dynamicfilters.Item(1));
            AV32DynamicFiltersSelector1 = AV31GridStateDynamicFilter.gxTpr_Selected;
            if ( StringUtil.StrCmp(AV32DynamicFiltersSelector1, "ESTADOPROYECTONOMBRE") == 0 )
            {
               AV33DynamicFiltersOperator1 = AV31GridStateDynamicFilter.gxTpr_Operator;
               AV34EstadoProyectoNombre1 = AV31GridStateDynamicFilter.gxTpr_Value;
            }
            if ( AV29GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               AV35DynamicFiltersEnabled2 = true;
               AV31GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV29GridState.gxTpr_Dynamicfilters.Item(2));
               AV36DynamicFiltersSelector2 = AV31GridStateDynamicFilter.gxTpr_Selected;
               if ( StringUtil.StrCmp(AV36DynamicFiltersSelector2, "ESTADOPROYECTONOMBRE") == 0 )
               {
                  AV37DynamicFiltersOperator2 = AV31GridStateDynamicFilter.gxTpr_Operator;
                  AV38EstadoProyectoNombre2 = AV31GridStateDynamicFilter.gxTpr_Value;
               }
               if ( AV29GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  AV39DynamicFiltersEnabled3 = true;
                  AV31GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV29GridState.gxTpr_Dynamicfilters.Item(3));
                  AV40DynamicFiltersSelector3 = AV31GridStateDynamicFilter.gxTpr_Selected;
                  if ( StringUtil.StrCmp(AV40DynamicFiltersSelector3, "ESTADOPROYECTONOMBRE") == 0 )
                  {
                     AV41DynamicFiltersOperator3 = AV31GridStateDynamicFilter.gxTpr_Operator;
                     AV42EstadoProyectoNombre3 = AV31GridStateDynamicFilter.gxTpr_Value;
                  }
               }
            }
         }
      }

      protected void S121( )
      {
         /* 'LOADESTADOPROYECTONOMBREOPTIONS' Routine */
         AV12TFEstadoProyectoNombre = AV14SearchTxt;
         AV13TFEstadoProyectoNombre_Sel = "";
         AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1 = AV32DynamicFiltersSelector1;
         AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 = AV33DynamicFiltersOperator1;
         AV49EstadoProyectoWWDS_3_Estadoproyectonombre1 = AV34EstadoProyectoNombre1;
         AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 = AV35DynamicFiltersEnabled2;
         AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2 = AV36DynamicFiltersSelector2;
         AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 = AV37DynamicFiltersOperator2;
         AV53EstadoProyectoWWDS_7_Estadoproyectonombre2 = AV38EstadoProyectoNombre2;
         AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 = AV39DynamicFiltersEnabled3;
         AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3 = AV40DynamicFiltersSelector3;
         AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 = AV41DynamicFiltersOperator3;
         AV57EstadoProyectoWWDS_11_Estadoproyectonombre3 = AV42EstadoProyectoNombre3;
         AV58EstadoProyectoWWDS_12_Tfestadoproyectoid = AV10TFEstadoProyectoID;
         AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to = AV11TFEstadoProyectoID_To;
         AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre = AV12TFEstadoProyectoNombre;
         AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = AV13TFEstadoProyectoNombre_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                              AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                              AV49EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                              AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                              AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                              AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                              AV53EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                              AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                              AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                              AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                              AV57EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                              AV58EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                              AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                              AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                              AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                              A34EstadoProyectoNombre ,
                                              A7EstadoProyectoID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT
                                              }
         } ) ;
         lV49EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV49EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV49EstadoProyectoWWDS_3_Estadoproyectonombre1 = StringUtil.PadR( StringUtil.RTrim( AV49EstadoProyectoWWDS_3_Estadoproyectonombre1), 40, "%");
         lV53EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV53EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV53EstadoProyectoWWDS_7_Estadoproyectonombre2 = StringUtil.PadR( StringUtil.RTrim( AV53EstadoProyectoWWDS_7_Estadoproyectonombre2), 40, "%");
         lV57EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV57EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV57EstadoProyectoWWDS_11_Estadoproyectonombre3 = StringUtil.PadR( StringUtil.RTrim( AV57EstadoProyectoWWDS_11_Estadoproyectonombre3), 40, "%");
         lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre = StringUtil.PadR( StringUtil.RTrim( AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre), 40, "%");
         /* Using cursor P000Z2 */
         pr_default.execute(0, new Object[] {lV49EstadoProyectoWWDS_3_Estadoproyectonombre1, lV49EstadoProyectoWWDS_3_Estadoproyectonombre1, lV53EstadoProyectoWWDS_7_Estadoproyectonombre2, lV53EstadoProyectoWWDS_7_Estadoproyectonombre2, lV57EstadoProyectoWWDS_11_Estadoproyectonombre3, lV57EstadoProyectoWWDS_11_Estadoproyectonombre3, AV58EstadoProyectoWWDS_12_Tfestadoproyectoid, AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to, lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre, AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0Z2 = false;
            A34EstadoProyectoNombre = P000Z2_A34EstadoProyectoNombre[0];
            A7EstadoProyectoID = P000Z2_A7EstadoProyectoID[0];
            AV26count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000Z2_A34EstadoProyectoNombre[0], A34EstadoProyectoNombre) == 0 ) )
            {
               BRK0Z2 = false;
               A7EstadoProyectoID = P000Z2_A7EstadoProyectoID[0];
               AV26count = (long)(AV26count+1);
               BRK0Z2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A34EstadoProyectoNombre)) )
            {
               AV18Option = A34EstadoProyectoNombre;
               AV19Options.Add(AV18Option, 0);
               AV24OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV26count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV19Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0Z2 )
            {
               BRK0Z2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
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
         AV19Options = new GxSimpleCollection<String>();
         AV22OptionsDesc = new GxSimpleCollection<String>();
         AV24OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV27Session = context.GetSession();
         AV29GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV30GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV12TFEstadoProyectoNombre = "";
         AV13TFEstadoProyectoNombre_Sel = "";
         AV31GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV32DynamicFiltersSelector1 = "";
         AV34EstadoProyectoNombre1 = "";
         AV36DynamicFiltersSelector2 = "";
         AV38EstadoProyectoNombre2 = "";
         AV40DynamicFiltersSelector3 = "";
         AV42EstadoProyectoNombre3 = "";
         AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1 = "";
         AV49EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2 = "";
         AV53EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3 = "";
         AV57EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel = "";
         scmdbuf = "";
         lV49EstadoProyectoWWDS_3_Estadoproyectonombre1 = "";
         lV53EstadoProyectoWWDS_7_Estadoproyectonombre2 = "";
         lV57EstadoProyectoWWDS_11_Estadoproyectonombre3 = "";
         lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre = "";
         A34EstadoProyectoNombre = "";
         P000Z2_A34EstadoProyectoNombre = new String[] {""} ;
         P000Z2_A7EstadoProyectoID = new short[1] ;
         AV18Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estadoproyectowwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000Z2_A34EstadoProyectoNombre, P000Z2_A7EstadoProyectoID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10TFEstadoProyectoID ;
      private short AV11TFEstadoProyectoID_To ;
      private short AV33DynamicFiltersOperator1 ;
      private short AV37DynamicFiltersOperator2 ;
      private short AV41DynamicFiltersOperator3 ;
      private short AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ;
      private short AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ;
      private short AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ;
      private short AV58EstadoProyectoWWDS_12_Tfestadoproyectoid ;
      private short AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to ;
      private short A7EstadoProyectoID ;
      private int AV45GXV1 ;
      private long AV26count ;
      private String AV12TFEstadoProyectoNombre ;
      private String AV13TFEstadoProyectoNombre_Sel ;
      private String AV34EstadoProyectoNombre1 ;
      private String AV38EstadoProyectoNombre2 ;
      private String AV42EstadoProyectoNombre3 ;
      private String AV49EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String AV53EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String AV57EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ;
      private String scmdbuf ;
      private String lV49EstadoProyectoWWDS_3_Estadoproyectonombre1 ;
      private String lV53EstadoProyectoWWDS_7_Estadoproyectonombre2 ;
      private String lV57EstadoProyectoWWDS_11_Estadoproyectonombre3 ;
      private String lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre ;
      private String A34EstadoProyectoNombre ;
      private bool returnInSub ;
      private bool AV35DynamicFiltersEnabled2 ;
      private bool AV39DynamicFiltersEnabled3 ;
      private bool AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ;
      private bool AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ;
      private bool BRK0Z2 ;
      private String AV25OptionIndexesJson ;
      private String AV20OptionsJson ;
      private String AV23OptionsDescJson ;
      private String AV16DDOName ;
      private String AV14SearchTxt ;
      private String AV15SearchTxtTo ;
      private String AV32DynamicFiltersSelector1 ;
      private String AV36DynamicFiltersSelector2 ;
      private String AV40DynamicFiltersSelector3 ;
      private String AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1 ;
      private String AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2 ;
      private String AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3 ;
      private String AV18Option ;
      private IGxSession AV27Session ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000Z2_A34EstadoProyectoNombre ;
      private short[] P000Z2_A7EstadoProyectoID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV19Options ;
      private GxSimpleCollection<String> AV22OptionsDesc ;
      private GxSimpleCollection<String> AV24OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV29GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV30GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV31GridStateDynamicFilter ;
   }

   public class estadoproyectowwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000Z2( IGxContext context ,
                                             String AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1 ,
                                             short AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 ,
                                             String AV49EstadoProyectoWWDS_3_Estadoproyectonombre1 ,
                                             bool AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 ,
                                             String AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2 ,
                                             short AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 ,
                                             String AV53EstadoProyectoWWDS_7_Estadoproyectonombre2 ,
                                             bool AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 ,
                                             String AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3 ,
                                             short AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 ,
                                             String AV57EstadoProyectoWWDS_11_Estadoproyectonombre3 ,
                                             short AV58EstadoProyectoWWDS_12_Tfestadoproyectoid ,
                                             short AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to ,
                                             String AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel ,
                                             String AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre ,
                                             String A34EstadoProyectoNombre ,
                                             short A7EstadoProyectoID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [EstadoProyectoNombre], [EstadoProyectoID] FROM [EstadoProyecto]";
         if ( ( StringUtil.StrCmp(AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV49EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV49EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV47EstadoProyectoWWDS_1_Dynamicfiltersselector1, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV48EstadoProyectoWWDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49EstadoProyectoWWDS_3_Estadoproyectonombre1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV49EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV49EstadoProyectoWWDS_3_Estadoproyectonombre1)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV53EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV53EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( AV50EstadoProyectoWWDS_4_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV51EstadoProyectoWWDS_5_Dynamicfiltersselector2, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV52EstadoProyectoWWDS_6_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53EstadoProyectoWWDS_7_Estadoproyectonombre2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV53EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV53EstadoProyectoWWDS_7_Estadoproyectonombre2)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV57EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV57EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( AV54EstadoProyectoWWDS_8_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV55EstadoProyectoWWDS_9_Dynamicfiltersselector3, context.GetMessage( "ESTADOPROYECTONOMBRE", "")) == 0 ) && ( AV56EstadoProyectoWWDS_10_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57EstadoProyectoWWDS_11_Estadoproyectonombre3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like '%' + @lV57EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like '%' + @lV57EstadoProyectoWWDS_11_Estadoproyectonombre3)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV58EstadoProyectoWWDS_12_Tfestadoproyectoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] >= @AV58EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] >= @AV58EstadoProyectoWWDS_12_Tfestadoproyectoid)";
            }
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( ! (0==AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoID] <= @AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoID] <= @AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to)";
            }
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60EstadoProyectoWWDS_14_Tfestadoproyectonombre)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] like @lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] like @lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre)";
            }
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([EstadoProyectoNombre] = @AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([EstadoProyectoNombre] = @AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [EstadoProyectoNombre]";
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
                     return conditional_P000Z2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] );
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
          Object[] prmP000Z2 ;
          prmP000Z2 = new Object[] {
          new Object[] {"@lV49EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV49EstadoProyectoWWDS_3_Estadoproyectonombre1",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV53EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV53EstadoProyectoWWDS_7_Estadoproyectonombre2",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV57EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@lV57EstadoProyectoWWDS_11_Estadoproyectonombre3",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV58EstadoProyectoWWDS_12_Tfestadoproyectoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV59EstadoProyectoWWDS_13_Tfestadoproyectoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV60EstadoProyectoWWDS_14_Tfestadoproyectonombre",SqlDbType.NChar,40,0} ,
          new Object[] {"@AV61EstadoProyectoWWDS_15_Tfestadoproyectonombre_sel",SqlDbType.NChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z2,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.estadoproyectowwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class estadoproyectowwgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("estadoproyectowwgetfilterdata") )
          {
             return  ;
          }
          estadoproyectowwgetfilterdata worker = new estadoproyectowwgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
