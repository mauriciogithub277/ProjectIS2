/*
               File: QueryViewerChartType
        Description: QueryViewerChartType
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:28:9.71
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomainqueryviewercharttype
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainqueryviewercharttype ()
      {
         domain["Column"] = "Column";
         domain["Column3D"] = "Column 3D";
         domain["StackedColumn"] = "Stacked column";
         domain["StackedColumn3D"] = "Stacked column 3D";
         domain["StackedColumn100"] = "100% stacked column";
         domain["Bar"] = "Bar";
         domain["StackedBar"] = "Stacked bar";
         domain["StackedBar100"] = "100% stacked bar";
         domain["Area"] = "Area";
         domain["StackedArea"] = "Stacked area";
         domain["StackedArea100"] = "100% stacked area";
         domain["SmoothArea"] = "Smooth area";
         domain["StepArea"] = "Step area";
         domain["Line"] = "Line";
         domain["StackedLine"] = "Stacked line";
         domain["StackedLine100"] = "100% stacked line";
         domain["SmoothLine"] = "Smooth line";
         domain["StepLine"] = "Step line";
         domain["Pie"] = "Pie";
         domain["Pie3D"] = "Pie 3D";
         domain["Doughnut"] = "Doughnut";
         domain["Doughnut3D"] = "Doughnut 3D";
         domain["LinearGauge"] = "Linear gauge";
         domain["CircularGauge"] = "Circular gauge";
         domain["Radar"] = "Radar";
         domain["FilledRadar"] = "Filled radar";
         domain["PolarArea"] = "Polar area";
         domain["Funnel"] = "Funnel";
         domain["Pyramid"] = "Pyramid";
         domain["ColumnLine"] = "Column & line";
         domain["Column3DLine"] = "Column 3D & line";
         domain["Timeline"] = "Timeline";
         domain["SmoothTimeline"] = "Smooth timeline";
         domain["StepTimeline"] = "Step timeline";
         domain["Sparkline"] = "Sparkline";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         String value ;
         rtkey = ((key==null) ? "" : StringUtil.Trim( (String)(key)));
         value = (String)(domain[rtkey]==null?"":domain[rtkey]);
         return context.GetMessage( value, "") ;
      }

      public static GxSimpleCollection<String> getValues( )
      {
         GxSimpleCollection<String> value = new GxSimpleCollection<String>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static String getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["Column"] = "Column";
            domainMap["Column3D"] = "Column3D";
            domainMap["StackedColumn"] = "StackedColumn";
            domainMap["StackedColumn3D"] = "StackedColumn3D";
            domainMap["StackedColumn100"] = "StackedColumn100";
            domainMap["Bar"] = "Bar";
            domainMap["StackedBar"] = "StackedBar";
            domainMap["StackedBar100"] = "StackedBar100";
            domainMap["Area"] = "Area";
            domainMap["StackedArea"] = "StackedArea";
            domainMap["StackedArea100"] = "StackedArea100";
            domainMap["SmoothArea"] = "SmoothArea";
            domainMap["StepArea"] = "StepArea";
            domainMap["Line"] = "Line";
            domainMap["StackedLine"] = "StackedLine";
            domainMap["StackedLine100"] = "StackedLine100";
            domainMap["SmoothLine"] = "SmoothLine";
            domainMap["StepLine"] = "StepLine";
            domainMap["Pie"] = "Pie";
            domainMap["Pie3D"] = "Pie3D";
            domainMap["Doughnut"] = "Doughnut";
            domainMap["Doughnut3D"] = "Doughnut3D";
            domainMap["LinearGauge"] = "LinearGauge";
            domainMap["CircularGauge"] = "CircularGauge";
            domainMap["Radar"] = "Radar";
            domainMap["FilledRadar"] = "FilledRadar";
            domainMap["PolarArea"] = "PolarArea";
            domainMap["Funnel"] = "Funnel";
            domainMap["Pyramid"] = "Pyramid";
            domainMap["ColumnLine"] = "ColumnLine";
            domainMap["Column3DLine"] = "Column3DLine";
            domainMap["Timeline"] = "Timeline";
            domainMap["SmoothTimeline"] = "SmoothTimeline";
            domainMap["StepTimeline"] = "StepTimeline";
            domainMap["Sparkline"] = "Sparkline";
         }
         return (String)domainMap[key] ;
      }

   }

}
