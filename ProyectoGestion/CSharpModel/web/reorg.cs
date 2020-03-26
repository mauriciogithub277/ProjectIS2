/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 3/22/2020 21:1:36.93
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public reorg( IGxContext context )
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

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizeUsuario( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Usuario */
         cmdBuffer=" ALTER TABLE [Usuario] ALTER COLUMN [Name] nchar(40) NOT NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      public void ReorganizeRoles( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Roles */
         cmdBuffer=" ALTER TABLE [Roles] ALTER COLUMN [RolesName] nchar(40) NOT NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      public void ReorganizeModulos( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Modulos */
         cmdBuffer=" ALTER TABLE [Modulos] ALTER COLUMN [ModulosName] nchar(40) NOT NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      public void ReorganizeProyecto( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Proyecto */
         cmdBuffer=" ALTER TABLE [Proyecto] ALTER COLUMN [ProyectoNombre] nchar(40) NOT NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      public void ReorganizeTarea( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Tarea */
         cmdBuffer=" ALTER TABLE [Tarea] ALTER COLUMN [TareaName] nchar(40) NOT NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            UsuarioCount = P00012_AUsuarioCount[0];
            pr_default.close(0);
            PrintRecordCount ( "Usuario" ,  UsuarioCount );
            /* Using cursor P00023 */
            pr_default.execute(1);
            RolesCount = P00023_ARolesCount[0];
            pr_default.close(1);
            PrintRecordCount ( "Roles" ,  RolesCount );
            /* Using cursor P00034 */
            pr_default.execute(2);
            ModulosCount = P00034_AModulosCount[0];
            pr_default.close(2);
            PrintRecordCount ( "Modulos" ,  ModulosCount );
            /* Using cursor P00045 */
            pr_default.execute(3);
            ProyectoCount = P00045_AProyectoCount[0];
            pr_default.close(3);
            PrintRecordCount ( "Proyecto" ,  ProyectoCount );
            /* Using cursor P00056 */
            pr_default.execute(4);
            TareaCount = P00056_ATareaCount[0];
            pr_default.close(4);
            PrintRecordCount ( "Tarea" ,  TareaCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00067 */
            pr_default.execute(5);
            while ( (pr_default.getStatus(5) != 101) )
            {
               sSchemaVar = P00067_AsSchemaVar[0];
               nsSchemaVar = P00067_nsSchemaVar[0];
               pr_default.readNext(5);
            }
            pr_default.close(5);
         }
         else
         {
            /* Using cursor P00078 */
            pr_default.execute(6);
            while ( (pr_default.getStatus(6) != 101) )
            {
               sSchemaVar = P00078_AsSchemaVar[0];
               nsSchemaVar = P00078_nsSchemaVar[0];
               pr_default.readNext(6);
            }
            pr_default.close(6);
         }
         return true ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizeUsuario" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "ReorganizeRoles" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "ReorganizeModulos" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 4 ,  "ReorganizeProyecto" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 5 ,  "ReorganizeTarea" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Usuario", ""}) );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Roles", ""}) );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Modulos", ""}) );
         GXReorganization.SetMsg( 4 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Proyecto", ""}) );
         GXReorganization.SetMsg( 5 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Tarea", ""}) );
      }

      private void SetPrecedenceris( )
      {
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00012_AUsuarioCount = new int[1] ;
         P00023_ARolesCount = new int[1] ;
         P00034_AModulosCount = new int[1] ;
         P00045_AProyectoCount = new int[1] ;
         P00056_ATareaCount = new int[1] ;
         sSchemaVar = "";
         nsSchemaVar = false;
         P00067_AsSchemaVar = new String[] {""} ;
         P00067_nsSchemaVar = new bool[] {false} ;
         P00078_AsSchemaVar = new String[] {""} ;
         P00078_nsSchemaVar = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AUsuarioCount
               }
               , new Object[] {
               P00023_ARolesCount
               }
               , new Object[] {
               P00034_AModulosCount
               }
               , new Object[] {
               P00045_AProyectoCount
               }
               , new Object[] {
               P00056_ATareaCount
               }
               , new Object[] {
               P00067_AsSchemaVar
               }
               , new Object[] {
               P00078_AsSchemaVar
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int UsuarioCount ;
      protected int RolesCount ;
      protected int ModulosCount ;
      protected int ProyectoCount ;
      protected int TareaCount ;
      protected String scmdbuf ;
      protected String sSchemaVar ;
      protected bool nsSchemaVar ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_AUsuarioCount ;
      protected int[] P00023_ARolesCount ;
      protected int[] P00034_AModulosCount ;
      protected int[] P00045_AProyectoCount ;
      protected int[] P00056_ATareaCount ;
      protected String[] P00067_AsSchemaVar ;
      protected bool[] P00067_nsSchemaVar ;
      protected String[] P00078_AsSchemaVar ;
      protected bool[] P00078_nsSchemaVar ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          } ;
          Object[] prmP00045 ;
          prmP00045 = new Object[] {
          } ;
          Object[] prmP00056 ;
          prmP00056 = new Object[] {
          } ;
          Object[] prmP00067 ;
          prmP00067 = new Object[] {
          } ;
          Object[] prmP00078 ;
          prmP00078 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM [Usuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00023", "SELECT COUNT(*) FROM [Roles] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00034", "SELECT COUNT(*) FROM [Modulos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00045", "SELECT COUNT(*) FROM [Proyecto] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00056", "SELECT COUNT(*) FROM [Tarea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00056,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00067", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00067,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00078", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00078,100, GxCacheFrequency.OFF ,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
