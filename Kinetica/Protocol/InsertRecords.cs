/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.insertRecords{T}(string,IList{T},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Adds multiple records to the specified table. The operation is
    /// synchronous, meaning that a response will not be returned until all the
    /// records are fully inserted and available. The response payload provides
    /// the counts of the number of records actually inserted and/or updated,
    /// and can provide the unique identifier of each added record.
    /// <br />
    /// The <see cref="options" /> parameter can be used to customize this
    /// function's behavior.
    /// <br />
    /// The <i>update_on_existing_pk</i> option specifies the record collision
    /// policy for inserting into a table with a <a
    /// href="../../../../../concepts/tables.html#primary-keys"
    /// target="_top">primary key</a>, but is ignored if no primary key exists.
    /// <br />
    /// The <i>return_record_ids</i> option indicates that the database should
    /// return the unique identifiers of inserted records.
    /// <br />
    /// The <i>route_to_address</i> option directs that inserted records should
    /// be targeted for a particular database node.</summary>
    public class RawInsertRecordsRequest : KineticaData
    {

        /// <summary>The encoding of the records to be inserted.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see>.
        /// A set of string constants for the parameter <see
        /// cref="list_encoding" />.</summary>
        public struct ListEncoding
        {
            public const string BINARY = "binary";
            public const string JSON = "json";
        } // end struct ListEncoding


        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Specifies the record collision policy for inserting
            /// into a table with a <a
            /// href="../../../../../concepts/tables.html#primary-keys"
            /// target="_top">primary key</a>.  If set to <i>true</i>, any
            /// existing table record with primary key values that match those
            /// of a record being inserted will be replaced by that new record.
            /// If set to <i>false</i>, any existing table record with primary
            /// key values that match those of a record being inserted will
            /// remain unchanged and the new record discarded.  If the
            /// specified table does not have a primary key, then this option
            /// is ignored.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</summary>
            public const string UPDATE_ON_EXISTING_PK = "update_on_existing_pk";
            public const string TRUE = "true";
            public const string FALSE = "false";

            /// <summary>If <i>true</i> then return the internal record id
            /// along for each inserted record.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</summary>
            public const string RETURN_RECORD_IDS = "return_record_ids";

            /// <summary>Route to a specific rank/tom. Option not suitable for
            /// tables using primary/shard keys</summary>
            public const string ROUTE_TO_ADDRESS = "route_to_address";
        } // end struct Options


        /// <summary>Table to which the records are to be added. Must be an
        /// existing table.  </summary>
        public string table_name { get; set; }

        /// <summary>An array of binary-encoded data for the records to be
        /// added. All records must be of the same type as that of the table.
        /// Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>json</i>.
        /// </summary>
        public IList<byte[]> list { get; set; } = new List<byte[]>();

        /// <summary>An array of JSON encoded data for the records to be added.
        /// All records must be of the same type as that of the table. Empty
        /// array if <paramref cref="RawInsertRecordsRequest.list_encoding" />
        /// is <i>binary</i>.  </summary>
        public IList<string> list_str { get; set; } = new List<string>();

        /// <summary>The encoding of the records to be inserted.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see>.
        /// </summary>
        public string list_encoding { get; set; } = ListEncoding.BINARY;

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a RawInsertRecordsRequest object with default
        /// parameters.</summary>
        public RawInsertRecordsRequest() { }

        /// <summary>Constructs a RawInsertRecordsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Table to which the records are to be
        /// added. Must be an existing table.  </param>
        /// <param name="list">An array of binary-encoded data for the records
        /// to be added. All records must be of the same type as that of the
        /// table. Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>json</i>.
        /// </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public RawInsertRecordsRequest( string table_name,
                                        IList<byte[]> list,
                                        IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.list = list ?? new List<byte[]>();
            this.list_str = new List<string>();
            this.list_encoding = ListEncoding.BINARY;
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor


        /// <summary>Constructs a RawInsertRecordsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Table to which the records are to be
        /// added. Must be an existing table.  </param>
        /// <param name="list">An array of binary-encoded data for the records
        /// to be added. All records must be of the same type as that of the
        /// table. Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>json</i>.
        /// </param>
        /// <param name="list_str">An array of JSON encoded data for the
        /// records to be added. All records must be of the same type as that
        /// of the table. Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>binary</i>.
        /// </param>
        /// <param name="list_encoding">The encoding of the records to be
        /// inserted.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.ListEncoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.ListEncoding.BINARY">BINARY</see>.
        /// </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public RawInsertRecordsRequest( string table_name,
                                        IList<byte[]> list,
                                        IList<string> list_str,
                                        string list_encoding = null,
                                        IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.list = list ?? new List<byte[]>();
            this.list_str = list_str ?? new List<string>();
            this.list_encoding = list_encoding ?? ListEncoding.BINARY;
            this.options = options ?? new Dictionary<string, string>();
        } // end full constructor

    } // end class RawInsertRecordsRequest



    /// <summary>A set of parameters for <see
    /// cref="Kinetica.insertRecords{T}(string,IList{T},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Adds multiple records to the specified table. The operation is
    /// synchronous, meaning that a response will not be returned until all the
    /// records are fully inserted and available. The response payload provides
    /// the counts of the number of records actually inserted and/or updated,
    /// and can provide the unique identifier of each added record.
    /// <br />
    /// The <see cref="options" /> parameter can be used to customize this
    /// function's behavior.
    /// <br />
    /// The <i>update_on_existing_pk</i> option specifies the record collision
    /// policy for inserting into a table with a <a
    /// href="../../../../../concepts/tables.html#primary-keys"
    /// target="_top">primary key</a>, but is ignored if no primary key exists.
    /// <br />
    /// The <i>return_record_ids</i> option indicates that the database should
    /// return the unique identifiers of inserted records.
    /// <br />
    /// The <i>route_to_address</i> option directs that inserted records should
    /// be targeted for a particular database node.</summary>
    /// 
    /// <typeparam name="T">The type of object being processed.</typeparam>
    /// 
    public class InsertRecordsRequest<T> : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Specifies the record collision policy for inserting
            /// into a table with a <a
            /// href="../../../../../concepts/tables.html#primary-keys"
            /// target="_top">primary key</a>.  If set to <i>true</i>, any
            /// existing table record with primary key values that match those
            /// of a record being inserted will be replaced by that new record.
            /// If set to <i>false</i>, any existing table record with primary
            /// key values that match those of a record being inserted will
            /// remain unchanged and the new record discarded.  If the
            /// specified table does not have a primary key, then this option
            /// is ignored.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</summary>
            public const string UPDATE_ON_EXISTING_PK = "update_on_existing_pk";
            public const string TRUE = "true";
            public const string FALSE = "false";

            /// <summary>If <i>true</i> then return the internal record id
            /// along for each inserted record.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</summary>
            public const string RETURN_RECORD_IDS = "return_record_ids";

            /// <summary>Route to a specific rank/tom. Option not suitable for
            /// tables using primary/shard keys</summary>
            public const string ROUTE_TO_ADDRESS = "route_to_address";
        } // end struct Options


        /// <summary>Table to which the records are to be added. Must be an
        /// existing table.  </summary>
        public string table_name { get; set; }

        /// <summary>An array of binary-encoded data for the records to be
        /// added. All records must be of the same type as that of the table.
        /// Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>json</i>.
        /// </summary>
        public IList<T> data { get; set; } = new List<T>();

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an InsertRecordsRequest object with default
        /// parameters.</summary>
        public InsertRecordsRequest() { }

        /// <summary>Constructs an InsertRecordsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Table to which the records are to be
        /// added. Must be an existing table.  </param>
        /// <param name="data">An array of binary-encoded data for the records
        /// to be added. All records must be of the same type as that of the
        /// table. Empty array if <paramref
        /// cref="RawInsertRecordsRequest.list_encoding" /> is <i>json</i>.
        /// </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.UPDATE_ON_EXISTING_PK">UPDATE_ON_EXISTING_PK</see>:</term>
        ///         <description>Specifies the record collision policy for
        /// inserting into a table with a <a
        /// href="../../../../concepts/tables.html#primary-keys"
        /// target="_top">primary key</a>.  If set to <i>true</i>, any existing
        /// table record with primary key values that match those of a record
        /// being inserted will be replaced by that new record.  If set to
        /// <i>false</i>, any existing table record with primary key values
        /// that match those of a record being inserted will remain unchanged
        /// and the new record discarded.  If the specified table does not have
        /// a primary key, then this option is ignored.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If <i>true</i> then return the internal record
        /// id along for each inserted record.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="RawInsertRecordsRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="RawInsertRecordsRequest.Options.ROUTE_TO_ADDRESS">ROUTE_TO_ADDRESS</see>:</term>
        ///         <description>Route to a specific rank/tom. Option not
        /// suitable for tables using primary/shard keys</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public InsertRecordsRequest( string table_name,
                                     IList<T> data,
                                     IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.data = data ?? new List<T>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class InsertRecordsRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.insertRecords{T}(string,IList{T},IDictionary{string, string})"
    /// />.</summary>
    public class InsertRecordsResponse : KineticaData
    {

        /// <summary>An array containing the IDs with which the added records
        /// are identified internally.  </summary>
        public IList<string> record_ids { get; set; } = new List<string>();

        /// <summary>The number of records inserted.  </summary>
        public int count_inserted { get; set; }

        /// <summary>The number of records updated.  </summary>
        public int count_updated { get; set; }

    } // end class InsertRecordsResponse




}  // end namespace kinetica
