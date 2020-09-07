using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"wwpbaseobjects\gethomesampledata", "dll");
      sc.Add( @"wwpbaseobjects\gethomesamplenamevaluedata", "dll");
      sc.Add( @"estadoproyectowwgetfilterdata", "dll");
      sc.Add( @"estadoproyectowwexportreport", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"wwpbaseobjects\notauthorized", "dll");
      sc.Add( @"wwpbaseobjects\home", "dll");
      sc.Add( @"wwpbaseobjects\home", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"wwusuario", "dll");
      sc.Add( @"viewroles", "dll");
      sc.Add( @"wwroles", "dll");
      sc.Add( @"wwproyecto", "dll");
      sc.Add( @"wwproyect", "dll");
      sc.Add( @"wlogin", "dll");
      sc.Add( @"wwdasboard", "dll");
      sc.Add( @"wwadmin", "dll");
      sc.Add( @"wconfig", "dll");
      sc.Add( @"viewusuario", "dll");
      sc.Add( @"usuariogeneral", "dll");
      sc.Add( @"rolesgeneral", "dll");
      sc.Add( @"rolesusuariowc", "dll");
      sc.Add( @"wwtarea", "dll");
      sc.Add( @"viewproyecto", "dll");
      sc.Add( @"proyectogeneral", "dll");
      sc.Add( @"proyectogestionproyectwc", "dll");
      sc.Add( @"viewtarea", "dll");
      sc.Add( @"tareageneral", "dll");
      sc.Add( @"wlineabase", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"gx0070", "dll");
      sc.Add( @"gx0081", "dll");
      sc.Add( @"gx0060", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsarrowwc", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsbulletwc", "dll");
      sc.Add( @"wwpbaseobjects\addressdisplay", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"wwpbaseobjects\managefilters", "dll");
      sc.Add( @"wwpbaseobjects\promptgeolocation", "dll");
      sc.Add( @"wwpbaseobjects\savefilteras", "dll");
      sc.Add( @"wwpbaseobjects\wwptabbedview", "dll");
      sc.Add( @"wwpbaseobjects\homeprogressbarcirclewc", "dll");
      sc.Add( @"wwpbaseobjects\homeprogressbarwc", "dll");
      sc.Add( @"wwpbaseobjects\masterpageframe", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpageprompt", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpage", "dll");
      sc.Add( @"estadoproyectoview", "dll");
      sc.Add( @"estadoproyectoww", "dll");
      sc.Add( @"estadoproyectoprompt", "dll");
      sc.Add( @"estadoproyectogeneral", "dll");
      sc.Add( @"viewestadoproyecto", "dll");
      sc.Add( @"wwestadoproyecto", "dll");
      sc.Add( @"usuario", "dll");
      sc.Add( @"roles", "dll");
      sc.Add( @"proyecto", "dll");
      sc.Add( @"gestionproyect", "dll");
      sc.Add( @"modulos", "dll");
      sc.Add( @"tarea", "dll");
      sc.Add( @"estadoproyecto", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtRoles.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraxisordertype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraxistype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerconditionoperator.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerexpandcollapse.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerfiltertype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerobjecttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewersubtotals.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewershowdatalabelsin.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainpage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpdomains.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainexporttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\gxdomainsplitscreen_action.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainhomesampledatastatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpcardsmenusize.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\gxdomainwwpcardsmenuoptiontype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewercharttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweroutputtype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerplotseries.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewershowdataas.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerorientation.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewertrendperiod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerxaxislabels.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraggregationtype.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

