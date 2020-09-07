/*
               File: WWPBaseObjects.WWPCardsMenuOptionType
        Description: WWPCardsMenuOptionType
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:28:10.1
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class gxdomainwwpcardsmenuoptiontype
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainwwpcardsmenuoptiontype ()
      {
         domain[(short)1] = "Icon And Title";
         domain[(short)2] = "Progress Bar";
         domain[(short)3] = "Progress Circle";
         domain[(short)4] = "Custom Web Component";
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
            domainMap["IconAndTitle"] = (short)1;
            domainMap["ProgressBar"] = (short)2;
            domainMap["ProgressCircle"] = (short)3;
            domainMap["CustomWebComponent"] = (short)4;
         }
         return (short)domainMap[key] ;
      }

   }

}
