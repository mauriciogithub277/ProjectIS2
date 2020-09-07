/*
               File: HomeSampleDataStatus
        Description: HomeSampleDataStatus
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:28:9.33
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
   public class gxdomainhomesampledatastatus
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainhomesampledatastatus ()
      {
         domain[(short)1] = "Available";
         domain[(short)2] = "Missing";
         domain[(short)3] = "Comming Soon";
         domain[(short)4] = "Ordered";
      }

      public static string getDescription( IGxContext context ,
                                           short key )
      {
         String value ;
         value = (String)(domain[key]==null?"":domain[key]);
         return ((context!=null) ? context.GetMessage( value, "") : value) ;
      }

      public static GxSimpleCollection<short> getValues( )
      {
         GxSimpleCollection<short> value = new GxSimpleCollection<short>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (short key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static short getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["Available"] = (short)1;
            domainMap["Missing"] = (short)2;
            domainMap["Soon"] = (short)3;
            domainMap["Ordered"] = (short)4;
         }
         return (short)domainMap[key] ;
      }

   }

}
