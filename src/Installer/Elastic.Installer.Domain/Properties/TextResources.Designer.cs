﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elastic.Installer.Domain.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TextResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TextResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Elastic.Installer.Domain.Properties.TextResources", typeof(TextResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Base Path.
        /// </summary>
        public static string ConfigurationModelValidator_BasePath {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_BasePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cluster name must be set..
        /// </summary>
        public static string ConfigurationModelValidator_ClusterName_NotEmpty {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_ClusterName_NotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Route.
        /// </summary>
        public static string ConfigurationModelValidator_DefaultRoute {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_DefaultRoute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP and transport cannot be bound to the same port: {0}.
        /// </summary>
        public static string ConfigurationModelValidator_EqualPorts {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_EqualPorts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A host name must be specified..
        /// </summary>
        public static string ConfigurationModelValidator_HostNameMustNotBeEmpty {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_HostNameMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP port must be empty or a value greater than {0}.
        /// </summary>
        public static string ConfigurationModelValidator_HttpPortMinimum {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_HttpPortMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We generally advise allocating 50% of the total available memory
        ///leaving the other half for the file system..
        /// </summary>
        public static string ConfigurationModelValidator_MaxMemory_50Percent {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_MaxMemory_50Percent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to min_master_nodes can not be less then 0.
        /// </summary>
        public static string ConfigurationModelValidator_NegativeMinimumMasterNodes {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_NegativeMinimumMasterNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node name must be set..
        /// </summary>
        public static string ConfigurationModelValidator_NodeName_NotEmpty {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_NodeName_NotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ports must be empty and may not exceed the port range with a maximum of {0}.
        /// </summary>
        public static string ConfigurationModelValidator_PortMaximum {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_PortMaximum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid route format.  Routes cannot start or end with &apos;/`..
        /// </summary>
        public static string ConfigurationModelValidator_RouteFormatMustBeValid {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_RouteFormatMustBeValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected memory is less than 250mb.
        ///Elasticsearch generally works better the more memory you allocate to it..
        /// </summary>
        public static string ConfigurationModelValidator_SelectedMemory_GreaterThanOrEqual250MB {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_SelectedMemory_GreaterThanOrEqual250MB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not allocate more then 32GB for Elasticsearch.
        ///Java won&apos;t used compressed pointers..
        /// </summary>
        public static string ConfigurationModelValidator_SelectedMemory_LessThan32GB {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_SelectedMemory_LessThan32GB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transport port must be empty or a value greater then {0}.
        /// </summary>
        public static string ConfigurationModelValidator_TransportPortMinimum {
            get {
                return ResourceManager.GetString("ConfigurationModelValidator_TransportPortMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A URL to Elasticsearch must be specified..
        /// </summary>
        public static string ConnectingModelValidator_ElasticsearchUrlMustBeSpecified {
            get {
                return ResourceManager.GetString("ConnectingModelValidator_ElasticsearchUrlMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An index must be specified..
        /// </summary>
        public static string ConnectingModelValidator_IndexMustBeSpecified {
            get {
                return ResourceManager.GetString("ConnectingModelValidator_IndexMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more sub models are not valid.
        /// </summary>
        public static string InstallationModelValidator_NotAllModelsAreValid {
            get {
                return ResourceManager.GetString("InstallationModelValidator_NotAllModelsAreValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration.
        /// </summary>
        public static string LocationsModelValidator_Configuration {
            get {
                return ResourceManager.GetString("LocationsModelValidator_Configuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data.
        /// </summary>
        public static string LocationsModelValidator_Data {
            get {
                return ResourceManager.GetString("LocationsModelValidator_Data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} directory must be a sub folder of {1} because the place in same folder flag was also set..
        /// </summary>
        public static string LocationsModelValidator_DirectoryMustBeChildOf {
            get {
                return ResourceManager.GetString("LocationsModelValidator_DirectoryMustBeChildOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} directory must be specified..
        /// </summary>
        public static string LocationsModelValidator_DirectoryMustBeSpecified {
            get {
                return ResourceManager.GetString("LocationsModelValidator_DirectoryMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} directory must not be relative..
        /// </summary>
        public static string LocationsModelValidator_DirectoryMustNotBeRelative {
            get {
                return ResourceManager.GetString("LocationsModelValidator_DirectoryMustNotBeRelative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} set to an unwritable program files location..
        /// </summary>
        public static string LocationsModelValidator_DirectorySetToNonWritableLocation {
            get {
                return ResourceManager.GetString("LocationsModelValidator_DirectorySetToNonWritableLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} directory uses unknown drive: {1}.
        /// </summary>
        public static string LocationsModelValidator_DirectoryUsesUnknownDrive {
            get {
                return ResourceManager.GetString("LocationsModelValidator_DirectoryUsesUnknownDrive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation.
        /// </summary>
        public static string LocationsModelValidator_Installation {
            get {
                return ResourceManager.GetString("LocationsModelValidator_Installation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logs.
        /// </summary>
        public static string LocationsModelValidator_Logs {
            get {
                return ResourceManager.GetString("LocationsModelValidator_Logs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previously installed version: {0}.
        /// </summary>
        public static string NoticeModel_ExistingVersion {
            get {
                return ResourceManager.GetString("NoticeModel_ExistingVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data created in prerelease versions of elasticsearch might not be migratable to stable versions.
        /// </summary>
        public static string NoticeModel_FromPrerelease {
            get {
                return ResourceManager.GetString("NoticeModel_FromPrerelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upgrading from a prerelease considerations.
        /// </summary>
        public static string NoticeModel_FromPrerelease_Header {
            get {
                return ResourceManager.GetString("NoticeModel_FromPrerelease_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chances are very high that the data will no longer be valid in this downgraded full major version.
        ///Please take this time to make sure you have offloaded any data to a different cluster through snapshot and restore and that the data folders
        ///in this cluster are empty. To migrate this data back into the downgraded cluster you need to perform a reindex..
        /// </summary>
        public static string NoticeModel_MajorDown {
            get {
                return ResourceManager.GetString("NoticeModel_MajorDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Major Downgrade considerations.
        /// </summary>
        public static string NoticeModel_MajorDown_Header {
            get {
                return ResourceManager.GetString("NoticeModel_MajorDown_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are running a major upgrade please take this time to read more about the best practices.
        /// </summary>
        public static string NoticeModel_MajorUp {
            get {
                return ResourceManager.GetString("NoticeModel_MajorUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Major Upgrade considerations.
        /// </summary>
        public static string NoticeModel_MajorUp_Header {
            get {
                return ResourceManager.GetString("NoticeModel_MajorUp_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chances are high that the data will no longer be valid in this downgraded minor version.
        ///Please take this time to make sure you have offloaded any data to a different cluster through snapshot and restore and that the data folders
        ///in this cluster are empty. To migrate this data back into the downgraded cluster you need to perform a reindex..
        /// </summary>
        public static string NoticeModel_MinorDown {
            get {
                return ResourceManager.GetString("NoticeModel_MinorDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minor Downgrade considerations.
        /// </summary>
        public static string NoticeModel_MinorDown_Header {
            get {
                return ResourceManager.GetString("NoticeModel_MinorDown_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are running a minor upgrade please take this time to read more about the best practices.
        /// </summary>
        public static string NoticeModel_MinorUp {
            get {
                return ResourceManager.GetString("NoticeModel_MinorUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minor Upgrade considerations.
        /// </summary>
        public static string NoticeModel_MinorUp_Header {
            get {
                return ResourceManager.GetString("NoticeModel_MinorUp_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chances are high that the data will no longer be valid in this downgraded patch version.
        ///Please take this time to make sure you have offloaded any data to a different cluster through snapshot and restore and that the data folders
        ///in this cluster are empty. To migrate this data back into the downgraded cluster you need to perform a reindex..
        /// </summary>
        public static string NoticeModel_PatchDown {
            get {
                return ResourceManager.GetString("NoticeModel_PatchDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patch Downgrade considerations.
        /// </summary>
        public static string NoticeModel_PatchDown_Header {
            get {
                return ResourceManager.GetString("NoticeModel_PatchDown_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please do not run elasticsearch prereleases in production.
        /// </summary>
        public static string NoticeModel_ToPrerelease {
            get {
                return ResourceManager.GetString("NoticeModel_ToPrerelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running a prerelease considerations.
        /// </summary>
        public static string NoticeModel_ToPrerelease_Header {
            get {
                return ResourceManager.GetString("NoticeModel_ToPrerelease_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This version is already installed.  Please uninstall first..
        /// </summary>
        public static string NoticeModelValidator_AlreadyInstalled {
            get {
                return ResourceManager.GetString("NoticeModelValidator_AlreadyInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The elasticsearch.yml file we found in ES_PATH_CONF appears to be 
        ///invalid  and prevented seeding current values..
        /// </summary>
        public static string NoticeModelValidator_BadElasticsearchYamlFile {
            get {
                return ResourceManager.GetString("NoticeModelValidator_BadElasticsearchYamlFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A higher version is already installed.  In order to downgrade, you must uninstall this version first.
        ///PLEASE NOTE: an uninstall will always remove the data folder be sure you move it elsewhere if you need to keep it..
        /// </summary>
        public static string NoticeModelValidator_HigherVersionInstalled {
            get {
                return ResourceManager.GetString("NoticeModelValidator_HigherVersionInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a valid Java installation..
        /// </summary>
        public static string NoticeModelValidator_JavaInstalled {
            get {
                return ResourceManager.GetString("NoticeModelValidator_JavaInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JAVA_HOME is set for both this user and the system.  Please choose the desired Java installation 
        ///by removing one of these environment variables..
        /// </summary>
        public static string NoticeModelValidator_JavaMisconfigured {
            get {
                return ResourceManager.GetString("NoticeModelValidator_JavaMisconfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found a 32 bit java installation as the default in the registry, elasticsearch requires a 64bit JVM.
        /// </summary>
        public static string NoticeModelValidator_Using32BitJava {
            get {
                return ResourceManager.GetString("NoticeModelValidator_Using32BitJava", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure Discovery plugin uses the Azure API for unicast discovery..
        /// </summary>
        public static string PluginsModel_AzureDiscovery {
            get {
                return ResourceManager.GetString("PluginsModel_AzureDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure Repository plugin adds support for using Azure as a repository for Snapshot/Restore..
        /// </summary>
        public static string PluginsModel_AzureRepository {
            get {
                return ResourceManager.GetString("PluginsModel_AzureRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An elasticsearch plugin written in Clojure that provides clojure as a scripting language for elasticsearch queries..
        /// </summary>
        public static string PluginsModel_ClojureLanguagePlugin {
            get {
                return ResourceManager.GetString("PluginsModel_ClojureLanguagePlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EC2 discovery plugin uses the AWS API for unicast discovery..
        /// </summary>
        public static string PluginsModel_EC2Discovery {
            get {
                return ResourceManager.GetString("PluginsModel_EC2Discovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Google Compute Engine Discovery plugin uses the GCE API for unicast discovery..
        /// </summary>
        public static string PluginsModel_GCEDiscovery {
            get {
                return ResourceManager.GetString("PluginsModel_GCEDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows Elasticsearch to use the Haddop file-system as a repository for snapshot/restore..
        /// </summary>
        public static string PluginsModel_HdfsRepository {
            get {
                return ResourceManager.GetString("PluginsModel_HdfsRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ICU Analysis plugin integrates Lucene ICU module into elasticsearch, adding ICU relates analysis components..
        /// </summary>
        public static string PluginsModel_ICUAnalysis {
            get {
                return ResourceManager.GetString("PluginsModel_ICUAnalysis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ingest attachment plugin lets Elasticsearch extract file attachments in common formats (such as PPT, XLS, and PDF) by using the Apache text extraction library Tika.  You can use the ingest attachment plugin as a replacement for the mapper attachment plugin..
        /// </summary>
        public static string PluginsModel_IngestAttachment {
            get {
                return ResourceManager.GetString("PluginsModel_IngestAttachment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The GeoIP processor adds information about the geographical location of IP addresses, based on data from the Maxmind databases. This processor adds this information by default under the geoip field..
        /// </summary>
        public static string PluginsModel_IngestGeoIP {
            get {
                return ResourceManager.GetString("PluginsModel_IngestGeoIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Japanese (kuromoji) Analysis plugin integrates Lucene kuromoji analysis module into elasticsearch..
        /// </summary>
        public static string PluginsModel_JapaneseAnalysis {
            get {
                return ResourceManager.GetString("PluginsModel_JapaneseAnalysis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The JavaScript language plugin allows to have javascript (or js) as the language of scripts to execute..
        /// </summary>
        public static string PluginsModel_JavaScriptLanguagePlugin {
            get {
                return ResourceManager.GetString("PluginsModel_JavaScriptLanguagePlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mapper attachments plugin adds the attachment type to Elasticsearch using Apache Tika. The attachment type allows to index different \&quot;attachment\&quot; type field (encoded as base64), for example, microsoft office formats, open document formats, ePub, HTML, and so on..
        /// </summary>
        public static string PluginsModel_MapperAttachments {
            get {
                return ResourceManager.GetString("PluginsModel_MapperAttachments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mapper-murmur3 plugin provides the ability to compute hash of field values at index-time and store them in the index. This can sometimes be helpful when running cardinality aggregations on high-cardinality and large string fields..
        /// </summary>
        public static string PluginsModel_MapperMurmur3 {
            get {
                return ResourceManager.GetString("PluginsModel_MapperMurmur3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mapper-size plugin provides the _size meta field which, when enabled, indexes the size in bytes of the original _source field..
        /// </summary>
        public static string PluginsModel_MapperSize {
            get {
                return ResourceManager.GetString("PluginsModel_MapperSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Phonetic Analysis plugin provides token filters which convert tokens to their phonetic representation using Soundex, Metaphone, and a variety of other algorithms..
        /// </summary>
        public static string PluginsModel_Phonetic {
            get {
                return ResourceManager.GetString("PluginsModel_Phonetic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Python (jython) language plugin allows to have python as the language of scripts to execute..
        /// </summary>
        public static string PluginsModel_PythonLanguagePlugin {
            get {
                return ResourceManager.GetString("PluginsModel_PythonLanguagePlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows Elasticsearch to use AWS S3 as a repository for snapshot/restore..
        /// </summary>
        public static string PluginsModel_S3Repository {
            get {
                return ResourceManager.GetString("PluginsModel_S3Repository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Smart Chinese Analysis plugin integrates Lucene Smart Chinese analysis module into elasticsearch..
        /// </summary>
        public static string PluginsModel_SmartChineseAnalysis {
            get {
                return ResourceManager.GetString("PluginsModel_SmartChineseAnalysis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Stempel (Polish) Analysis plugin integrates Lucene stempel (Polish) analysis module into elasticsearch..
        /// </summary>
        public static string PluginsModel_StempelPolishAnalysis {
            get {
                return ResourceManager.GetString("PluginsModel_StempelPolishAnalysis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Store SMB plugin works around for a bug in Windows SMB and Java on Windows..
        /// </summary>
        public static string PluginsModel_StoreSmb {
            get {
                return ResourceManager.GetString("PluginsModel_StoreSmb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to X-Pack is an Elastic Stack extension that bundles security, alerting, monitoring, reporting, and graph capabilities into one easy-to-install package. While the X-Pack components are designed to work together seamlessly, you can easily enable or disable the features you want to use. X-Pack is a proprietary plugin that falls under the Elastic EULA. By selecting to install X-Pack, A 30 day fully featured trial license is applied upon installation..
        /// </summary>
        public static string PluginsModel_XPack {
            get {
                return ResourceManager.GetString("PluginsModel_XPack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plugin installation is online, meaning you need a connection to the 
        ///    internet to commence. Either deselect all plugins or connect 
        ///    to the internet and refresh the installer..
        /// </summary>
        public static string PluginsModelValidator_NoInternet {
            get {
                return ResourceManager.GetString("PluginsModelValidator_NoInternet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis.
        /// </summary>
        public static string PluginType_Analysis {
            get {
                return ResourceManager.GetString("PluginType_Analysis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API Extensions.
        /// </summary>
        public static string PluginType_ApiExtensions {
            get {
                return ResourceManager.GetString("PluginType_ApiExtensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discovery.
        /// </summary>
        public static string PluginType_Discovery {
            get {
                return ResourceManager.GetString("PluginType_Discovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ingest.
        /// </summary>
        public static string PluginType_Ingest {
            get {
                return ResourceManager.GetString("PluginType_Ingest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapper.
        /// </summary>
        public static string PluginType_Mapper {
            get {
                return ResourceManager.GetString("PluginType_Mapper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scripting.
        /// </summary>
        public static string PluginType_Scripting {
            get {
                return ResourceManager.GetString("PluginType_Scripting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Snapshot.
        /// </summary>
        public static string PluginType_Snapshot {
            get {
                return ResourceManager.GetString("PluginType_Snapshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store.
        /// </summary>
        public static string PluginType_Store {
            get {
                return ResourceManager.GetString("PluginType_Store", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to X-Pack.
        /// </summary>
        public static string PluginType_XPack {
            get {
                return ResourceManager.GetString("PluginType_XPack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided windows account credentials are not valid..
        /// </summary>
        public static string ServiceModelValidator_CredentialsFailed {
            get {
                return ResourceManager.GetString("ServiceModelValidator_CredentialsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple run as flags have been specified causing an ambiguity which to use..
        /// </summary>
        public static string ServiceModelValidator_MultipleRunAsTypes {
            get {
                return ResourceManager.GetString("ServiceModelValidator_MultipleRunAsTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must be specified when using an existing user..
        /// </summary>
        public static string ServiceModelValidator_Password_NotEmpty_WhenUseExistingUser {
            get {
                return ResourceManager.GetString("ServiceModelValidator_Password_NotEmpty_WhenUseExistingUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service name must be specified..
        /// </summary>
        public static string ServiceModelValidator_ServiceName_NotEmpty {
            get {
                return ResourceManager.GetString("ServiceModelValidator_ServiceName_NotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username must be specified when using an existing user..
        /// </summary>
        public static string ServiceModelValidator_User_NotEmpty_WhenUseExistingUser {
            get {
                return ResourceManager.GetString("ServiceModelValidator_User_NotEmpty_WhenUseExistingUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User or Password is incorrect.
        /// </summary>
        public static string ServiceModelValidator_User_Or_Password_Incorrect {
            get {
                return ResourceManager.GetString("ServiceModelValidator_User_Or_Password_Incorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        public static string SetupView_ExitText {
            get {
                return ResourceManager.GetString("SetupView_ExitText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install.
        /// </summary>
        public static string SetupView_InstallText {
            get {
                return ResourceManager.GetString("SetupView_InstallText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Next.
        /// </summary>
        public static string SetupView_NextText {
            get {
                return ResourceManager.GetString("SetupView_NextText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;elastic&apos; password needs to be atleast 6 characters.
        /// </summary>
        public static string XPackModelValidator_ElasticPasswordRequired {
            get {
                return ResourceManager.GetString("XPackModelValidator_ElasticPasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;kibana&apos; password needs to be atleast 6 characters.
        /// </summary>
        public static string XPackModelValidator_KibanaPasswordRequired {
            get {
                return ResourceManager.GetString("XPackModelValidator_KibanaPasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;logstash_system&apos; password needs to be atleast 6 characters.
        /// </summary>
        public static string XPackModelValidator_LogstashPasswordRequired {
            get {
                return ResourceManager.GetString("XPackModelValidator_LogstashPasswordRequired", resourceCulture);
            }
        }
    }
}
