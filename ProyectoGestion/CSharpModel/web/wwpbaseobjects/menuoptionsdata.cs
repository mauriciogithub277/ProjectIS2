/*
               File: WWPBaseObjects.MenuOptionsData
        Description: Menu Options Data
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:48.73
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
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class menuoptionsdata : GXProcedure
   {
      public menuoptionsdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public menuoptionsdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "IS2") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> executeUdp( )
      {
         execute(out aP0_Gxm2rootcol);
         return Gxm2rootcol ;
      }

      public void executeSubmit( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_Gxm2rootcol )
      {
         menuoptionsdata objmenuoptionsdata;
         objmenuoptionsdata = new menuoptionsdata();
         objmenuoptionsdata.Gxm2rootcol = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "IS2") ;
         objmenuoptionsdata.context.SetSubmitInitialConfig(context);
         objmenuoptionsdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objmenuoptionsdata);
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((menuoptionsdata)stateInfo).executePrivate();
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
         AV5id = 0;
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm2rootcol.Add(Gxm1dvelop_menu, 0);
         AV5id = (short)(AV5id+1);
         Gxm1dvelop_menu.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm1dvelop_menu.gxTpr_Tooltip = "";
         Gxm1dvelop_menu.gxTpr_Link = "wwpbaseobjects.home.aspx";
         Gxm1dvelop_menu.gxTpr_Linktarget = "";
         Gxm1dvelop_menu.gxTpr_Iconclass = "menu-icon fa fa-home";
         Gxm1dvelop_menu.gxTpr_Caption = "Home";
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm2rootcol.Add(Gxm1dvelop_menu, 0);
         AV5id = (short)(AV5id+1);
         Gxm1dvelop_menu.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm1dvelop_menu.gxTpr_Tooltip = "";
         Gxm1dvelop_menu.gxTpr_Link = "";
         Gxm1dvelop_menu.gxTpr_Linktarget = "";
         Gxm1dvelop_menu.gxTpr_Iconclass = "menu-icon fa fa-tasks";
         Gxm1dvelop_menu.gxTpr_Caption = "Menu Option 1";
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
         Gxm3dvelop_menu_subitems.gxTpr_Link = "";
         Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
         Gxm3dvelop_menu_subitems.gxTpr_Caption = "Menu Option 1.1";
         Gxm3dvelop_menu_subitems.gxTpr_Authorizationkey = "";
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
         Gxm3dvelop_menu_subitems.gxTpr_Link = "";
         Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
         Gxm3dvelop_menu_subitems.gxTpr_Caption = "Menu Option 1.2";
         Gxm3dvelop_menu_subitems.gxTpr_Authorizationkey = "";
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
         Gxm3dvelop_menu_subitems.gxTpr_Link = "";
         Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
         Gxm3dvelop_menu_subitems.gxTpr_Caption = "Menu Option 1.3";
         Gxm3dvelop_menu_subitems.gxTpr_Authorizationkey = "";
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm2rootcol.Add(Gxm1dvelop_menu, 0);
         AV5id = (short)(AV5id+1);
         Gxm1dvelop_menu.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm1dvelop_menu.gxTpr_Tooltip = "";
         Gxm1dvelop_menu.gxTpr_Link = "";
         Gxm1dvelop_menu.gxTpr_Linktarget = "";
         Gxm1dvelop_menu.gxTpr_Iconclass = "menu-icon fa fa-key";
         Gxm1dvelop_menu.gxTpr_Caption = "Menu Option 2";
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
         Gxm3dvelop_menu_subitems.gxTpr_Link = "";
         Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
         Gxm3dvelop_menu_subitems.gxTpr_Iconclass = "";
         Gxm3dvelop_menu_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.1", "");
         Gxm4dvelop_menu_subitems_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm3dvelop_menu_subitems.gxTpr_Subitems.Add(Gxm4dvelop_menu_subitems_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Tooltip = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Link = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Linktarget = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.1.1", "");
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Authorizationkey = "";
         Gxm4dvelop_menu_subitems_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm3dvelop_menu_subitems.gxTpr_Subitems.Add(Gxm4dvelop_menu_subitems_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Tooltip = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Link = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Linktarget = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.1.2", "");
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Authorizationkey = "";
         Gxm4dvelop_menu_subitems_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm3dvelop_menu_subitems.gxTpr_Subitems.Add(Gxm4dvelop_menu_subitems_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Tooltip = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Link = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Linktarget = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.1.3", "");
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Authorizationkey = "";
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
         Gxm3dvelop_menu_subitems.gxTpr_Link = "";
         Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
         Gxm3dvelop_menu_subitems.gxTpr_Iconclass = "";
         Gxm3dvelop_menu_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.2", "");
         Gxm4dvelop_menu_subitems_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm3dvelop_menu_subitems.gxTpr_Subitems.Add(Gxm4dvelop_menu_subitems_subitems, 0);
         AV5id = (short)(AV5id+1);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Tooltip = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Link = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Linktarget = "";
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Caption = context.GetMessage( "Menu Option 2.2.1", "");
         Gxm4dvelop_menu_subitems_subitems.gxTpr_Authorizationkey = "";
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm2rootcol.Add(Gxm1dvelop_menu, 0);
         AV5id = (short)(AV5id+1);
         Gxm1dvelop_menu.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm1dvelop_menu.gxTpr_Tooltip = "";
         Gxm1dvelop_menu.gxTpr_Link = "";
         Gxm1dvelop_menu.gxTpr_Linktarget = "";
         Gxm1dvelop_menu.gxTpr_Iconclass = "menu-icon fa fa-briefcase";
         Gxm1dvelop_menu.gxTpr_Caption = "Menu Option 3";
         Gxm1dvelop_menu.gxTpr_Authorizationkey = "";
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm2rootcol.Add(Gxm1dvelop_menu, 0);
         AV5id = (short)(AV5id+1);
         Gxm1dvelop_menu.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
         Gxm1dvelop_menu.gxTpr_Tooltip = "";
         Gxm1dvelop_menu.gxTpr_Link = "";
         Gxm1dvelop_menu.gxTpr_Linktarget = "";
         Gxm1dvelop_menu.gxTpr_Iconclass = "menu-icon fa fa-edit";
         Gxm1dvelop_menu.gxTpr_Caption = "Developer Menu";
         Gxv5skipcount = 0;
         AV15GXV2 = 1;
         GXt_objcol_SdtProgramNames_ProgramName1 = AV14GXV1;
         new GeneXus.Programs.wwpbaseobjects.listwwpprograms(context ).execute( out  GXt_objcol_SdtProgramNames_ProgramName1) ;
         AV14GXV1 = GXt_objcol_SdtProgramNames_ProgramName1;
         while ( AV15GXV2 <= AV14GXV1.Count )
         {
            AV6ProgramName = ((GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName)AV14GXV1.Item(AV15GXV2));
            Gxv5skipcount = (int)(Gxv5skipcount+1);
            Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
            Gxm1dvelop_menu.gxTpr_Subitems.Add(Gxm3dvelop_menu_subitems, 0);
            AV5id = (short)(AV5id+1);
            Gxm3dvelop_menu_subitems.gxTpr_Id = StringUtil.Str( (decimal)(AV5id), 4, 0);
            Gxm3dvelop_menu_subitems.gxTpr_Tooltip = "";
            Gxm3dvelop_menu_subitems.gxTpr_Link = AV6ProgramName.gxTpr_Link;
            Gxm3dvelop_menu_subitems.gxTpr_Linktarget = "";
            Gxm3dvelop_menu_subitems.gxTpr_Iconclass = "";
            Gxm3dvelop_menu_subitems.gxTpr_Caption = AV6ProgramName.gxTpr_Description;
            if ( ( 20 != 0 ) && ( Gxv5skipcount >= 20 ) )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            AV15GXV2 = (int)(AV15GXV2+1);
         }
         this.cleanup();
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
         Gxm1dvelop_menu = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm3dvelop_menu_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         Gxm4dvelop_menu_subitems_subitems = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         AV14GXV1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "IS2");
         GXt_objcol_SdtProgramNames_ProgramName1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "IS2");
         AV6ProgramName = new GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV5id ;
      private int Gxv5skipcount ;
      private int AV15GXV2 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_Gxm2rootcol ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> AV14GXV1 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> GXt_objcol_SdtProgramNames_ProgramName1 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> Gxm2rootcol ;
      private GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName AV6ProgramName ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item Gxm1dvelop_menu ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item Gxm3dvelop_menu_subitems ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item Gxm4dvelop_menu_subitems_subitems ;
   }

}
