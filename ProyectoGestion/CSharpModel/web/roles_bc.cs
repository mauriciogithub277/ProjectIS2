/*
               File: Roles_BC
        Description: Roles
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:52.97
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class roles_bc : GXHttpHandler, IGxSilentTrn
   {
      public roles_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public roles_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow022( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey022( ) ;
         standaloneModal( ) ;
         AddRow022( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               Z2RolesID = A2RolesID;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               if ( AnyError == 0 )
               {
                  ZM022( 3) ;
               }
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12022( )
      {
         /* Start Routine */
      }

      protected void E11022( )
      {
         /* After Trn Routine */
      }

      protected void E13022( )
      {
         /* 'ATRAS' Routine */
         CallWebObject(formatLink("wwroles.aspx") );
         context.wjLocDisableFrm = 1;
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z15RolesName = A15RolesName;
            Z3ModulosID = A3ModulosID;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z18ModulosName = A18ModulosName;
         }
         if ( GX_JID == -2 )
         {
            Z2RolesID = A2RolesID;
            Z15RolesName = A15RolesName;
            Z3ModulosID = A3ModulosID;
            Z18ModulosName = A18ModulosName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load022( )
      {
         /* Using cursor BC00025 */
         pr_default.execute(3, new Object[] {A2RolesID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
            A15RolesName = BC00025_A15RolesName[0];
            A18ModulosName = BC00025_A18ModulosName[0];
            A3ModulosID = BC00025_A3ModulosID[0];
            ZM022( -2) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         nIsDirty_2 = 0;
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A15RolesName)) )
         {
            GX_msglist.addItem(context.GetMessage( "Campo Obligatorio", ""), 1, "");
            AnyError = 1;
         }
         /* Using cursor BC00024 */
         pr_default.execute(2, new Object[] {A3ModulosID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_ForeignKeyNotFound", ""), context.GetMessage( "Modulos", ""), "", "", "", "", "", "", "", ""), "ForeignKeyNotFound", 1, "MODULOSID");
            AnyError = 1;
         }
         A18ModulosName = BC00024_A18ModulosName[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey022( )
      {
         /* Using cursor BC00026 */
         pr_default.execute(4, new Object[] {A2RolesID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00023 */
         pr_default.execute(1, new Object[] {A2RolesID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 2) ;
            RcdFound2 = 1;
            A2RolesID = BC00023_A2RolesID[0];
            A15RolesName = BC00023_A15RolesName[0];
            A3ModulosID = BC00023_A3ModulosID[0];
            Z2RolesID = A2RolesID;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode2;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_020( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00022 */
            pr_default.execute(0, new Object[] {A2RolesID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Roles"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z15RolesName, BC00022_A15RolesName[0]) != 0 ) || ( Z3ModulosID != BC00022_A3ModulosID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Roles"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00027 */
                     pr_default.execute(5, new Object[] {A15RolesName, A3ModulosID});
                     A2RolesID = BC00027_A2RolesID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("Roles") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00028 */
                     pr_default.execute(6, new Object[] {A15RolesName, A3ModulosID, A2RolesID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Roles") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Roles"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00029 */
                  pr_default.execute(7, new Object[] {A2RolesID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("Roles") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel022( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000210 */
            pr_default.execute(8, new Object[] {A3ModulosID});
            A18ModulosName = BC000210_A18ModulosName[0];
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000211 */
            pr_default.execute(9, new Object[] {A2RolesID});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {context.GetMessage( "Usuario", "")}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel022( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart022( )
      {
         /* Scan By routine */
         /* Using cursor BC000212 */
         pr_default.execute(10, new Object[] {A2RolesID});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound2 = 1;
            A2RolesID = BC000212_A2RolesID[0];
            A15RolesName = BC000212_A15RolesName[0];
            A18ModulosName = BC000212_A18ModulosName[0];
            A3ModulosID = BC000212_A3ModulosID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound2 = 0;
         ScanKeyLoad022( ) ;
      }

      protected void ScanKeyLoad022( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound2 = 1;
            A2RolesID = BC000212_A2RolesID[0];
            A15RolesName = BC000212_A15RolesName[0];
            A18ModulosName = BC000212_A18ModulosName[0];
            A3ModulosID = BC000212_A3ModulosID[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd022( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void AddRow022( )
      {
         VarsToRow2( bcRoles) ;
      }

      protected void ReadRow022( )
      {
         RowToVars2( bcRoles, 1) ;
      }

      protected void InitializeNonKey022( )
      {
         A15RolesName = "";
         A3ModulosID = 0;
         A18ModulosName = "";
         Z15RolesName = "";
         Z3ModulosID = 0;
      }

      protected void InitAll022( )
      {
         A2RolesID = 0;
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void VarsToRow2( SdtRoles obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Rolesname = A15RolesName;
         obj2.gxTpr_Modulosid = A3ModulosID;
         obj2.gxTpr_Modulosname = A18ModulosName;
         obj2.gxTpr_Rolesid = A2RolesID;
         obj2.gxTpr_Rolesid_Z = Z2RolesID;
         obj2.gxTpr_Rolesname_Z = Z15RolesName;
         obj2.gxTpr_Modulosid_Z = Z3ModulosID;
         obj2.gxTpr_Modulosname_Z = Z18ModulosName;
         obj2.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow2( SdtRoles obj2 )
      {
         obj2.gxTpr_Rolesid = A2RolesID;
         return  ;
      }

      public void RowToVars2( SdtRoles obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A15RolesName = obj2.gxTpr_Rolesname;
         A3ModulosID = obj2.gxTpr_Modulosid;
         A18ModulosName = obj2.gxTpr_Modulosname;
         A2RolesID = obj2.gxTpr_Rolesid;
         Z2RolesID = obj2.gxTpr_Rolesid_Z;
         Z15RolesName = obj2.gxTpr_Rolesname_Z;
         Z3ModulosID = obj2.gxTpr_Modulosid_Z;
         Z18ModulosName = obj2.gxTpr_Modulosname_Z;
         Gx_mode = obj2.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A2RolesID = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey022( ) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2RolesID = A2RolesID;
         }
         ZM022( -2) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars2( bcRoles, 0) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2RolesID = A2RolesID;
         }
         ZM022( -2) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            Insert022( ) ;
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A2RolesID != Z2RolesID )
               {
                  A2RolesID = Z2RolesID;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update022( ) ;
               }
            }
            else
            {
               if ( IsDlt( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A2RolesID != Z2RolesID )
                  {
                     if ( IsUpd( ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcRoles, 0) ;
         SaveImpl( ) ;
         VarsToRow2( bcRoles) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcRoles, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         AfterTrn( ) ;
         VarsToRow2( bcRoles) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( IsUpd( ) )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtRoles auxBC = new SdtRoles(context) ;
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            auxBC.Load(A2RolesID);
            if ( auxTrn.Errors() == 0 )
            {
               auxBC.UpdateDirties(bcRoles);
               auxBC.Save();
            }
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            context.GX_msglist = LclMsgLst;
            if ( auxTrn.Errors() == 0 )
            {
               Gx_mode = auxTrn.GetMode();
               AfterTrn( ) ;
            }
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcRoles, 0) ;
         UpdateImpl( ) ;
         VarsToRow2( bcRoles) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcRoles, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         if ( AnyError == 1 )
         {
            if ( StringUtil.StrCmp(context.GX_msglist.getItemValue(1), "DuplicatePrimaryKey") == 0 )
            {
               AnyError = 0;
               context.GX_msglist.removeAllItems();
               UpdateImpl( ) ;
            }
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow2( bcRoles) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars2( bcRoles, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A2RolesID != Z2RolesID )
            {
               A2RolesID = Z2RolesID;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( IsDlt( ) )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A2RolesID != Z2RolesID )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( IsUpd( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(8);
         context.RollbackDataStores("roles_bc",pr_default);
         VarsToRow2( bcRoles) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcRoles.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcRoles.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcRoles )
         {
            bcRoles = (SdtRoles)(sdt);
            if ( StringUtil.StrCmp(bcRoles.gxTpr_Mode, "") == 0 )
            {
               bcRoles.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow2( bcRoles) ;
            }
            else
            {
               RowToVars2( bcRoles, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcRoles.gxTpr_Mode, "") == 0 )
            {
               bcRoles.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars2( bcRoles, 1) ;
         return  ;
      }

      public void ForceCommitOnExit( )
      {
         mustCommit = true;
         return  ;
      }

      public SdtRoles Roles_BC
      {
         get {
            return bcRoles ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(8);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z15RolesName = "";
         A15RolesName = "";
         Z18ModulosName = "";
         A18ModulosName = "";
         BC00025_A2RolesID = new short[1] ;
         BC00025_A15RolesName = new String[] {""} ;
         BC00025_A18ModulosName = new String[] {""} ;
         BC00025_A3ModulosID = new short[1] ;
         BC00024_A18ModulosName = new String[] {""} ;
         BC00026_A2RolesID = new short[1] ;
         BC00023_A2RolesID = new short[1] ;
         BC00023_A15RolesName = new String[] {""} ;
         BC00023_A3ModulosID = new short[1] ;
         sMode2 = "";
         BC00022_A2RolesID = new short[1] ;
         BC00022_A15RolesName = new String[] {""} ;
         BC00022_A3ModulosID = new short[1] ;
         BC00027_A2RolesID = new short[1] ;
         BC000210_A18ModulosName = new String[] {""} ;
         BC000211_A1UsuarioID = new short[1] ;
         BC000212_A2RolesID = new short[1] ;
         BC000212_A15RolesName = new String[] {""} ;
         BC000212_A18ModulosName = new String[] {""} ;
         BC000212_A3ModulosID = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.roles_bc__default(),
            new Object[][] {
                new Object[] {
               BC00022_A2RolesID, BC00022_A15RolesName, BC00022_A3ModulosID
               }
               , new Object[] {
               BC00023_A2RolesID, BC00023_A15RolesName, BC00023_A3ModulosID
               }
               , new Object[] {
               BC00024_A18ModulosName
               }
               , new Object[] {
               BC00025_A2RolesID, BC00025_A15RolesName, BC00025_A18ModulosName, BC00025_A3ModulosID
               }
               , new Object[] {
               BC00026_A2RolesID
               }
               , new Object[] {
               BC00027_A2RolesID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000210_A18ModulosName
               }
               , new Object[] {
               BC000211_A1UsuarioID
               }
               , new Object[] {
               BC000212_A2RolesID, BC000212_A15RolesName, BC000212_A18ModulosName, BC000212_A3ModulosID
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12022 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z2RolesID ;
      private short A2RolesID ;
      private short GX_JID ;
      private short Z3ModulosID ;
      private short A3ModulosID ;
      private short RcdFound2 ;
      private short nIsDirty_2 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String Z15RolesName ;
      private String A15RolesName ;
      private String Z18ModulosName ;
      private String A18ModulosName ;
      private String sMode2 ;
      private bool mustCommit ;
      private SdtRoles bcRoles ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00025_A2RolesID ;
      private String[] BC00025_A15RolesName ;
      private String[] BC00025_A18ModulosName ;
      private short[] BC00025_A3ModulosID ;
      private String[] BC00024_A18ModulosName ;
      private short[] BC00026_A2RolesID ;
      private short[] BC00023_A2RolesID ;
      private String[] BC00023_A15RolesName ;
      private short[] BC00023_A3ModulosID ;
      private short[] BC00022_A2RolesID ;
      private String[] BC00022_A15RolesName ;
      private short[] BC00022_A3ModulosID ;
      private short[] BC00027_A2RolesID ;
      private String[] BC000210_A18ModulosName ;
      private short[] BC000211_A1UsuarioID ;
      private short[] BC000212_A2RolesID ;
      private String[] BC000212_A15RolesName ;
      private String[] BC000212_A18ModulosName ;
      private short[] BC000212_A3ModulosID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class roles_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00025 ;
          prmBC00025 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00024 ;
          prmBC00024 = new Object[] {
          new Object[] {"@ModulosID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00026 ;
          prmBC00026 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00023 ;
          prmBC00023 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00022 ;
          prmBC00022 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00027 ;
          prmBC00027 = new Object[] {
          new Object[] {"@RolesName",SqlDbType.NChar,40,0} ,
          new Object[] {"@ModulosID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00028 ;
          prmBC00028 = new Object[] {
          new Object[] {"@RolesName",SqlDbType.NChar,40,0} ,
          new Object[] {"@ModulosID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00029 ;
          prmBC00029 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000210 ;
          prmBC000210 = new Object[] {
          new Object[] {"@ModulosID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000211 ;
          prmBC000211 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000212 ;
          prmBC000212 = new Object[] {
          new Object[] {"@RolesID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00022", "SELECT [RolesID], [RolesName], [ModulosID] FROM [Roles] WITH (UPDLOCK) WHERE [RolesID] = @RolesID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00022,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00023", "SELECT [RolesID], [RolesName], [ModulosID] FROM [Roles] WHERE [RolesID] = @RolesID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00023,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00024", "SELECT [ModulosName] FROM [Modulos] WHERE [ModulosID] = @ModulosID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00024,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00025", "SELECT TM1.[RolesID], TM1.[RolesName], T2.[ModulosName], TM1.[ModulosID] FROM ([Roles] TM1 INNER JOIN [Modulos] T2 ON T2.[ModulosID] = TM1.[ModulosID]) WHERE TM1.[RolesID] = @RolesID ORDER BY TM1.[RolesID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00025,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00026", "SELECT [RolesID] FROM [Roles] WHERE [RolesID] = @RolesID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00026,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00027", "INSERT INTO [Roles]([RolesName], [ModulosID]) VALUES(@RolesName, @ModulosID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00027)
             ,new CursorDef("BC00028", "UPDATE [Roles] SET [RolesName]=@RolesName, [ModulosID]=@ModulosID  WHERE [RolesID] = @RolesID", GxErrorMask.GX_NOMASK,prmBC00028)
             ,new CursorDef("BC00029", "DELETE FROM [Roles]  WHERE [RolesID] = @RolesID", GxErrorMask.GX_NOMASK,prmBC00029)
             ,new CursorDef("BC000210", "SELECT [ModulosName] FROM [Modulos] WHERE [ModulosID] = @ModulosID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000210,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000211", "SELECT TOP 1 [UsuarioID] FROM [Usuario] WHERE [RolesID] = @RolesID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000211,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000212", "SELECT TM1.[RolesID], TM1.[RolesName], T2.[ModulosName], TM1.[ModulosID] FROM ([Roles] TM1 INNER JOIN [Modulos] T2 ON T2.[ModulosID] = TM1.[ModulosID]) WHERE TM1.[RolesID] = @RolesID ORDER BY TM1.[RolesID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000212,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
