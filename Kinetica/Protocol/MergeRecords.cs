/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.mergeRecords(string,IList{string},IList{IDictionary{string, string}},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Create a new empty result table (specified by <see cref="table_name"
    /// />), and insert all records from source tables (specified by <see
    /// cref="source_table_names" />) based on the field mapping information
    /// (specified by <see cref="field_maps" />). The field map (specified by
    /// <see cref="field_maps" />) holds the user specified maps of target
    /// table column names to source table columns.</summary>
    public class MergeRecordsRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />). If empty, then the newly
        /// created merged table will be a top-level table. If the collection
        /// does not allow duplicate types and it contains a table of the same
        /// type as the given one, then this table creation request will
        /// fail.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.IS_REPLICATED">IS_REPLICATED</see>:</term>
        ///         <description>For a merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />), indicates whether the
        /// table is to be replicated to all the database ranks. This may be
        /// necessary when the table is to be joined with other tables in a
        /// query.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the TTL of the merged table or collection
        /// (specified by <paramref cref="MergeRecordsRequest.table_name" />).
        /// The value must be the desired TTL in minutes.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>If provided this indicates the chunk size to
        /// be used for the merged table.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Name of a collection which is to contain the newly
            /// created merged table (specified by <see cref="table_name" />).
            /// If empty, then the newly created merged table will be a
            /// top-level table. If the collection does not allow duplicate
            /// types and it contains a table of the same type as the given
            /// one, then this table creation request will fail.</summary>
            public const string COLLECTION_NAME = "collection_name";

            /// <summary>For a merged table (specified by <see
            /// cref="table_name" />), indicates whether the table is to be
            /// replicated to all the database ranks. This may be necessary
            /// when the table is to be joined with other tables in a query.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="MergeRecordsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see>.</summary>
            public const string IS_REPLICATED = "is_replicated";
            public const string TRUE = "true";
            public const string FALSE = "false";

            /// <summary>Sets the TTL of the merged table or collection
            /// (specified by <see cref="table_name" />). The value must be the
            /// desired TTL in minutes.</summary>
            public const string TTL = "ttl";

            /// <summary>If provided this indicates the chunk size to be used
            /// for the merged table.</summary>
            public const string CHUNK_SIZE = "chunk_size";
        } // end struct Options


        /// <summary>The new result table name for the records to be merged.
        /// Must NOT be an existing table.  </summary>
        public string table_name { get; set; }

        /// <summary>The list of source table names to get the records from.
        /// Must be existing table names.  </summary>
        public IList<string> source_table_names { get; set; } = new List<string>();

        /// <summary>Contains the mapping of column names from result table
        /// (specified by <paramref cref="MergeRecordsRequest.table_name" />)
        /// as the keys, and corresponding column names from a table from
        /// source tables (specified by <paramref
        /// cref="MergeRecordsRequest.source_table_names" />). Must be existing
        /// column names in source table and target table, and their types must
        /// be matched.  </summary>
        public IList<IDictionary<string, string>> field_maps { get; set; } = new List<IDictionary<string, string>>();

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />). If empty, then the newly
        /// created merged table will be a top-level table. If the collection
        /// does not allow duplicate types and it contains a table of the same
        /// type as the given one, then this table creation request will
        /// fail.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.IS_REPLICATED">IS_REPLICATED</see>:</term>
        ///         <description>For a merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />), indicates whether the
        /// table is to be replicated to all the database ranks. This may be
        /// necessary when the table is to be joined with other tables in a
        /// query.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the TTL of the merged table or collection
        /// (specified by <paramref cref="MergeRecordsRequest.table_name" />).
        /// The value must be the desired TTL in minutes.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>If provided this indicates the chunk size to
        /// be used for the merged table.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a MergeRecordsRequest object with default
        /// parameters.</summary>
        public MergeRecordsRequest() { }

        /// <summary>Constructs a MergeRecordsRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">The new result table name for the records
        /// to be merged.  Must NOT be an existing table.  </param>
        /// <param name="source_table_names">The list of source table names to
        /// get the records from. Must be existing table names.  </param>
        /// <param name="field_maps">Contains the mapping of column names from
        /// result table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />) as the keys, and
        /// corresponding column names from a table from source tables
        /// (specified by <paramref
        /// cref="MergeRecordsRequest.source_table_names" />). Must be existing
        /// column names in source table and target table, and their types must
        /// be matched.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />). If empty, then the newly
        /// created merged table will be a top-level table. If the collection
        /// does not allow duplicate types and it contains a table of the same
        /// type as the given one, then this table creation request will
        /// fail.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.IS_REPLICATED">IS_REPLICATED</see>:</term>
        ///         <description>For a merged table (specified by <paramref
        /// cref="MergeRecordsRequest.table_name" />), indicates whether the
        /// table is to be replicated to all the database ranks. This may be
        /// necessary when the table is to be joined with other tables in a
        /// query.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="MergeRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the TTL of the merged table or collection
        /// (specified by <paramref cref="MergeRecordsRequest.table_name" />).
        /// The value must be the desired TTL in minutes.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="MergeRecordsRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>If provided this indicates the chunk size to
        /// be used for the merged table.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public MergeRecordsRequest( string table_name,
                                    IList<string> source_table_names,
                                    IList<IDictionary<string, string>> field_maps,
                                    IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.source_table_names = source_table_names ?? new List<string>();
            this.field_maps = field_maps ?? new List<IDictionary<string, string>>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class MergeRecordsRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.mergeRecords(string,IList{string},IList{IDictionary{string, string}},IDictionary{string, string})"
    /// />.</summary>
    public class MergeRecordsResponse : KineticaData
    {
        public string table_name { get; set; }

    } // end class MergeRecordsResponse




}  // end namespace kinetica
