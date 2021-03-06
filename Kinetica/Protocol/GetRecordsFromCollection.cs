/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.getRecordsFromCollection{T}(string,long,long,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Retrieves records from a collection. The operation can optionally
    /// return the record IDs which can be used in certain queries such as <see
    /// cref="Kinetica.deleteRecords(string,IList{string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// This operation supports paging through the data via the <see
    /// cref="offset" /> and <see cref="limit" /> parameters.
    /// <br />
    /// Note that when using the Java API, it is not possible to retrieve
    /// records from join tables using this operation.</summary>
    public class GetRecordsFromCollectionRequest : KineticaData
    {

        /// <summary>Specifies the encoding for returned records; either
        /// 'binary' or 'json'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see>.
        /// A set of string constants for the parameter <see cref="encoding"
        /// />.</summary>
        public struct Encoding
        {
            public const string BINARY = "binary";
            public const string JSON = "json";
        } // end struct Encoding


        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If 'true' then return the internal record ID
        /// along with each returned record. Default is 'false'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>If 'true' then return the internal record ID along
            /// with each returned record. Default is 'false'.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="GetRecordsFromCollectionRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see>.</summary>
            public const string RETURN_RECORD_IDS = "return_record_ids";
            public const string TRUE = "true";
            public const string FALSE = "false";
        } // end struct Options


        /// <summary>Name of the collection or table from which records are to
        /// be retrieved. Must be an existing collection or table.  </summary>
        public string table_name { get; set; }

        /// <summary>A positive integer indicating the number of initial
        /// results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </summary>
        public long offset { get; set; } = 0;

        /// <summary>A positive integer indicating the maximum number of
        /// results to be returned, or END_OF_SET (-9999) to indicate that the
        /// max number of results should be returned.  </summary>
        public long limit { get; set; } = 10000;

        /// <summary>Specifies the encoding for returned records; either
        /// 'binary' or 'json'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see>.
        /// </summary>
        public string encoding { get; set; } = Encoding.BINARY;

        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If 'true' then return the internal record ID
        /// along with each returned record. Default is 'false'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a GetRecordsFromCollectionRequest object with
        /// default parameters.</summary>
        public GetRecordsFromCollectionRequest() { }

        /// <summary>Constructs a GetRecordsFromCollectionRequest object with
        /// the specified parameters.</summary>
        /// 
        /// <param name="table_name">Name of the collection or table from which
        /// records are to be retrieved. Must be an existing collection or
        /// table.  </param>
        /// <param name="offset">A positive integer indicating the number of
        /// initial results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </param>
        /// <param name="limit">A positive integer indicating the maximum
        /// number of results to be returned, or END_OF_SET (-9999) to indicate
        /// that the max number of results should be returned.  </param>
        /// <param name="options">
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If 'true' then return the internal record ID
        /// along with each returned record. Default is 'false'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public GetRecordsFromCollectionRequest( string table_name,
                                                long offset = 0,
                                                long limit = 10000,
                                                IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.offset = offset;
            this.limit = limit;
            this.encoding = Encoding.BINARY;
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor


        /// <summary>Constructs a GetRecordsFromCollectionRequest object with
        /// the specified parameters.</summary>
        /// 
        /// <param name="table_name">Name of the collection or table from which
        /// records are to be retrieved. Must be an existing collection or
        /// table.  </param>
        /// <param name="offset">A positive integer indicating the number of
        /// initial results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </param>
        /// <param name="limit">A positive integer indicating the maximum
        /// number of results to be returned, or END_OF_SET (-9999) to indicate
        /// that the max number of results should be returned.  </param>
        /// <param name="encoding">Specifies the encoding for returned records;
        /// either 'binary' or 'json'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Encoding.JSON">JSON</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Encoding.BINARY">BINARY</see>.
        /// </param>
        /// <param name="options">
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.RETURN_RECORD_IDS">RETURN_RECORD_IDS</see>:</term>
        ///         <description>If 'true' then return the internal record ID
        /// along with each returned record. Default is 'false'.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="GetRecordsFromCollectionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public GetRecordsFromCollectionRequest( string table_name,
                                                long offset = 0,
                                                long limit = 10000,
                                                string encoding = null,
                                                IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.offset = offset;
            this.limit = limit;
            this.encoding = encoding ?? Encoding.BINARY;
            this.options = options ?? new Dictionary<string, string>();
        } // end full constructor

    } // end class GetRecordsFromCollectionRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.getRecordsFromCollection{T}(string,long,long,IDictionary{string, string})"
    /// />.</summary>
    public class RawGetRecordsFromCollectionResponse : KineticaData
    {

        /// <summary>Value of <paramref
        /// cref="GetRecordsFromCollectionRequest.table_name" />.  </summary>
        public string table_name { get; set; }

        /// <summary>The type IDs of the corresponding records in <member
        /// name="records_binary" /> or <member name="records_json" />. This is
        /// useful when <paramref
        /// cref="GetRecordsFromCollectionRequest.table_name" /> is a
        /// heterogeneous collection (collections containing tables of
        /// different types).  </summary>
        public IList<string> type_names { get; set; } = new List<string>();

        /// <summary>If the encoding parameter of the request was 'binary' then
        /// this list contains the binary encoded records retrieved from the
        /// table/collection. Otherwise, empty list.  </summary>
        public IList<byte[]> records_binary { get; set; } = new List<byte[]>();

        /// <summary>If the encoding parameter of the request was 'json', then
        /// this list contains the JSON encoded records retrieved from the
        /// table/collection. Otherwise, empty list.  </summary>
        public IList<string> records_json { get; set; } = new List<string>();

        /// <summary>If the 'return_record_ids' option of the request was
        /// 'true', then this list contains the internal ID for each object.
        /// Otherwise it will be empty.  </summary>
        public IList<string> record_ids { get; set; } = new List<string>();

    } // end class RawGetRecordsFromCollectionResponse



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.getRecordsFromCollection{T}(string,long,long,IDictionary{string, string})"
    /// />.</summary>
    /// 
    /// <typeparam name="T">The type of object being processed.</typeparam>
    /// 
    public class GetRecordsFromCollectionResponse<T> : KineticaData
    {

        /// <summary>Value of <paramref
        /// cref="GetRecordsFromCollectionRequest.table_name" />.  </summary>
        public string table_name { get; set; }

        /// <summary>The type IDs of the corresponding records in <member
        /// name="records_binary" /> or <member name="records_json" />. This is
        /// useful when <paramref
        /// cref="GetRecordsFromCollectionRequest.table_name" /> is a
        /// heterogeneous collection (collections containing tables of
        /// different types).  </summary>
        public IList<string> type_names { get; set; } = new List<string>();

        /// <summary>If the encoding parameter of the request was 'binary' then
        /// this list contains the binary encoded records retrieved from the
        /// table/collection. Otherwise, empty list.  </summary>
        public IList<T> data { get; set; } = new List<T>();

        /// <summary>If the 'return_record_ids' option of the request was
        /// 'true', then this list contains the internal ID for each object.
        /// Otherwise it will be empty.  </summary>
        public IList<string> record_ids { get; set; } = new List<string>();

    } // end class GetRecordsFromCollectionResponse




}  // end namespace kinetica
