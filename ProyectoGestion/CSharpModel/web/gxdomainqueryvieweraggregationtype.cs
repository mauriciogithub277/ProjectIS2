/*
               File: QueryViewerAggregationType
        Description: QueryViewerAggregationType
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:28:9.67
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
   public class gxdomainqueryvieweraggregationtype
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainqueryvieweraggregationtype ()
      {
         domain["Sum"] = "Sum";
         domain["Count"] = "Count";
         domain["Average"] = "Average";
         domain["Max"] = "Max";
         domain["Min"] = "Min";
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
            domainMap["Sum"] = "Sum";
            domainMap["Count"] = "Count";
            domainMap["Average"] = "Average";
            domainMap["Max"] = "Max";
            domainMap["Min"] = "Min";
         }
         return (String)domainMap[key] ;
      }

   }

}
