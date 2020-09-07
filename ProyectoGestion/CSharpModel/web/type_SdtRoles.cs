/*
               File: type_SdtRoles
        Description: Roles
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 8/24/2020 21:27:53.40
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Roles" )]
   [XmlType(TypeName =  "Roles" , Namespace = "IS2" )]
   [Serializable]
   public class SdtRoles : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtRoles( )
      {
      }

      public SdtRoles( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( short AV2RolesID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV2RolesID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"RolesID", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Roles");
         metadata.Set("BT", "Roles");
         metadata.Set("PK", "[ \"RolesID\" ]");
         metadata.Set("PKAssigned", "[ \"RolesID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ModulosID\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Rolesid_Z");
         state.Add("gxTpr_Rolesname_Z");
         state.Add("gxTpr_Modulosid_Z");
         state.Add("gxTpr_Modulosname_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtRoles sdt ;
         sdt = (SdtRoles)(source);
         gxTv_SdtRoles_Rolesid = sdt.gxTv_SdtRoles_Rolesid ;
         gxTv_SdtRoles_Rolesname = sdt.gxTv_SdtRoles_Rolesname ;
         gxTv_SdtRoles_Modulosid = sdt.gxTv_SdtRoles_Modulosid ;
         gxTv_SdtRoles_Modulosname = sdt.gxTv_SdtRoles_Modulosname ;
         gxTv_SdtRoles_Mode = sdt.gxTv_SdtRoles_Mode ;
         gxTv_SdtRoles_Initialized = sdt.gxTv_SdtRoles_Initialized ;
         gxTv_SdtRoles_Rolesid_Z = sdt.gxTv_SdtRoles_Rolesid_Z ;
         gxTv_SdtRoles_Rolesname_Z = sdt.gxTv_SdtRoles_Rolesname_Z ;
         gxTv_SdtRoles_Modulosid_Z = sdt.gxTv_SdtRoles_Modulosid_Z ;
         gxTv_SdtRoles_Modulosname_Z = sdt.gxTv_SdtRoles_Modulosname_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         ToJSON( includeState, true) ;
         return  ;
      }

      public override void ToJSON( bool includeState ,
                                   bool includeNonInitialized )
      {
         AddObjectProperty("RolesID", gxTv_SdtRoles_Rolesid, false, includeNonInitialized);
         AddObjectProperty("RolesName", gxTv_SdtRoles_Rolesname, false, includeNonInitialized);
         AddObjectProperty("ModulosID", gxTv_SdtRoles_Modulosid, false, includeNonInitialized);
         AddObjectProperty("ModulosName", gxTv_SdtRoles_Modulosname, false, includeNonInitialized);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtRoles_Mode, false, includeNonInitialized);
            AddObjectProperty("Initialized", gxTv_SdtRoles_Initialized, false, includeNonInitialized);
            AddObjectProperty("RolesID_Z", gxTv_SdtRoles_Rolesid_Z, false, includeNonInitialized);
            AddObjectProperty("RolesName_Z", gxTv_SdtRoles_Rolesname_Z, false, includeNonInitialized);
            AddObjectProperty("ModulosID_Z", gxTv_SdtRoles_Modulosid_Z, false, includeNonInitialized);
            AddObjectProperty("ModulosName_Z", gxTv_SdtRoles_Modulosname_Z, false, includeNonInitialized);
         }
         return  ;
      }

      public void UpdateDirties( SdtRoles sdt )
      {
         if ( sdt.IsDirty("RolesID") )
         {
            gxTv_SdtRoles_Rolesid = sdt.gxTv_SdtRoles_Rolesid ;
         }
         if ( sdt.IsDirty("RolesName") )
         {
            gxTv_SdtRoles_Rolesname = sdt.gxTv_SdtRoles_Rolesname ;
         }
         if ( sdt.IsDirty("ModulosID") )
         {
            gxTv_SdtRoles_Modulosid = sdt.gxTv_SdtRoles_Modulosid ;
         }
         if ( sdt.IsDirty("ModulosName") )
         {
            gxTv_SdtRoles_Modulosname = sdt.gxTv_SdtRoles_Modulosname ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "RolesID" )]
      [  XmlElement( ElementName = "RolesID"   )]
      public short gxTpr_Rolesid
      {
         get {
            return gxTv_SdtRoles_Rolesid ;
         }

         set {
            if ( gxTv_SdtRoles_Rolesid != value )
            {
               gxTv_SdtRoles_Mode = "INS";
               this.gxTv_SdtRoles_Rolesid_Z_SetNull( );
               this.gxTv_SdtRoles_Rolesname_Z_SetNull( );
               this.gxTv_SdtRoles_Modulosid_Z_SetNull( );
               this.gxTv_SdtRoles_Modulosname_Z_SetNull( );
            }
            gxTv_SdtRoles_Rolesid = value;
            SetDirty("Rolesid");
         }

      }

      [  SoapElement( ElementName = "RolesName" )]
      [  XmlElement( ElementName = "RolesName"   )]
      public String gxTpr_Rolesname
      {
         get {
            return gxTv_SdtRoles_Rolesname ;
         }

         set {
            gxTv_SdtRoles_Rolesname = value;
            SetDirty("Rolesname");
         }

      }

      [  SoapElement( ElementName = "ModulosID" )]
      [  XmlElement( ElementName = "ModulosID"   )]
      public short gxTpr_Modulosid
      {
         get {
            return gxTv_SdtRoles_Modulosid ;
         }

         set {
            gxTv_SdtRoles_Modulosid = value;
            SetDirty("Modulosid");
         }

      }

      [  SoapElement( ElementName = "ModulosName" )]
      [  XmlElement( ElementName = "ModulosName"   )]
      public String gxTpr_Modulosname
      {
         get {
            return gxTv_SdtRoles_Modulosname ;
         }

         set {
            gxTv_SdtRoles_Modulosname = value;
            SetDirty("Modulosname");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtRoles_Mode ;
         }

         set {
            gxTv_SdtRoles_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtRoles_Mode_SetNull( )
      {
         gxTv_SdtRoles_Mode = "";
         return  ;
      }

      public bool gxTv_SdtRoles_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtRoles_Initialized ;
         }

         set {
            gxTv_SdtRoles_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtRoles_Initialized_SetNull( )
      {
         gxTv_SdtRoles_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtRoles_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RolesID_Z" )]
      [  XmlElement( ElementName = "RolesID_Z"   )]
      public short gxTpr_Rolesid_Z
      {
         get {
            return gxTv_SdtRoles_Rolesid_Z ;
         }

         set {
            gxTv_SdtRoles_Rolesid_Z = value;
            SetDirty("Rolesid_Z");
         }

      }

      public void gxTv_SdtRoles_Rolesid_Z_SetNull( )
      {
         gxTv_SdtRoles_Rolesid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtRoles_Rolesid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RolesName_Z" )]
      [  XmlElement( ElementName = "RolesName_Z"   )]
      public String gxTpr_Rolesname_Z
      {
         get {
            return gxTv_SdtRoles_Rolesname_Z ;
         }

         set {
            gxTv_SdtRoles_Rolesname_Z = value;
            SetDirty("Rolesname_Z");
         }

      }

      public void gxTv_SdtRoles_Rolesname_Z_SetNull( )
      {
         gxTv_SdtRoles_Rolesname_Z = "";
         return  ;
      }

      public bool gxTv_SdtRoles_Rolesname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ModulosID_Z" )]
      [  XmlElement( ElementName = "ModulosID_Z"   )]
      public short gxTpr_Modulosid_Z
      {
         get {
            return gxTv_SdtRoles_Modulosid_Z ;
         }

         set {
            gxTv_SdtRoles_Modulosid_Z = value;
            SetDirty("Modulosid_Z");
         }

      }

      public void gxTv_SdtRoles_Modulosid_Z_SetNull( )
      {
         gxTv_SdtRoles_Modulosid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtRoles_Modulosid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ModulosName_Z" )]
      [  XmlElement( ElementName = "ModulosName_Z"   )]
      public String gxTpr_Modulosname_Z
      {
         get {
            return gxTv_SdtRoles_Modulosname_Z ;
         }

         set {
            gxTv_SdtRoles_Modulosname_Z = value;
            SetDirty("Modulosname_Z");
         }

      }

      public void gxTv_SdtRoles_Modulosname_Z_SetNull( )
      {
         gxTv_SdtRoles_Modulosname_Z = "";
         return  ;
      }

      public bool gxTv_SdtRoles_Modulosname_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtRoles_Rolesname = "";
         gxTv_SdtRoles_Modulosname = "";
         gxTv_SdtRoles_Mode = "";
         gxTv_SdtRoles_Rolesname_Z = "";
         gxTv_SdtRoles_Modulosname_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "roles", "GeneXus.Programs.roles_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtRoles_Rolesid ;
      private short gxTv_SdtRoles_Modulosid ;
      private short gxTv_SdtRoles_Initialized ;
      private short gxTv_SdtRoles_Rolesid_Z ;
      private short gxTv_SdtRoles_Modulosid_Z ;
      private String gxTv_SdtRoles_Rolesname ;
      private String gxTv_SdtRoles_Modulosname ;
      private String gxTv_SdtRoles_Mode ;
      private String gxTv_SdtRoles_Rolesname_Z ;
      private String gxTv_SdtRoles_Modulosname_Z ;
   }

   [DataContract(Name = @"Roles", Namespace = "IS2")]
   public class SdtRoles_RESTInterface : GxGenericCollectionItem<SdtRoles>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtRoles_RESTInterface( ) : base()
      {
      }

      public SdtRoles_RESTInterface( SdtRoles psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "RolesID" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Rolesid
      {
         get {
            return sdt.gxTpr_Rolesid ;
         }

         set {
            sdt.gxTpr_Rolesid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "RolesName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Rolesname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Rolesname) ;
         }

         set {
            sdt.gxTpr_Rolesname = value;
         }

      }

      [DataMember( Name = "ModulosID" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Modulosid
      {
         get {
            return sdt.gxTpr_Modulosid ;
         }

         set {
            sdt.gxTpr_Modulosid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ModulosName" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Modulosname
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Modulosname) ;
         }

         set {
            sdt.gxTpr_Modulosname = value;
         }

      }

      public SdtRoles sdt
      {
         get {
            return (SdtRoles)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtRoles() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
