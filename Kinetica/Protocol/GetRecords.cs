/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /get/records.
    /// <br />
    /// Retrieves records from a given table, optionally filtered by an
    /// expression and/or sorted by a column. This operation can be performed
    /// on tables, views, or on homogeneous collections (collections containing
    /// tables of all the same type). Records can be returned encoded as binary
    /// or json.
    /// <br />
    /// This operation supports paging through the data via the <member
    /// name="offset" /> and <member name="limit" /> parameters. Note that when
    /// paging through a table, if the table (or the underlying table in case
    /// of a view) is updated (records are inserted, deleted or modified) the
    /// records retrieved may differ between calls based on the updates
    /// applied.</summary>
    public class GetRecordsRequest : KineticaData
    {

        /// <summary>Specifies the encoding for returned records. Values:
        /// binary, json.
        /// <br />
        /// A set of string constants for the parameter <member name="encoding"
        /// />.</summary>
        public struct Encoding
        {
            public const string BINARY = "binary";
            public const string JSON = "json";
        } // end struct Encoding


        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term>expression</term>
        ///         <description>Optional filter expression to apply to the
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term>fast_index_lookup</term>
        ///         <description>Indicates if indexes should be used to perform
        /// the lookup for a given expression if possible. Only applicable if
        /// there is no sorting, the expression contains only equivalence
        /// comparisons based on existing tables indexes and the range of
        /// requested values is from [0 to END_OF_SET]. The default value is
        /// true.</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_by</term>
        ///         <description>Optional column that the data should be sorted
        /// by. Empty by default (i.e. no sorting is applied).</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_order</term>
        ///         <description>String indicating how the returned values
        /// should be sorted - ascending or descending. If sort_order is
        /// provided, sort_by has to be provided. Values: ascending,
        /// descending.
        /// </description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <member name="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Optional filter expression to apply to the
            /// table.</summary>
            public const string EXPRESSION = "expression";

            /// <summary>Indicates if indexes should be used to perform the
            /// lookup for a given expression if possible. Only applicable if
            /// there is no sorting, the expression contains only equivalence
            /// comparisons based on existing tables indexes and the range of
            /// requested values is from [0 to END_OF_SET]. The default value
            /// is true.</summary>
            public const string FAST_INDEX_LOOKUP = "fast_index_lookup";

            /// <summary>Optional column that the data should be sorted by.
            /// Empty by default (i.e. no sorting is applied).</summary>
            public const string SORT_BY = "sort_by";

            /// <summary>String indicating how the returned values should be
            /// sorted - ascending or descending. If sort_order is provided,
            /// sort_by has to be provided. Values: ascending, descending.
            /// </summary>
            public const string SORT_ORDER = "sort_order";
            public const string ASCENDING = "ascending";
            public const string DESCENDING = "descending";
        } // end struct Options


        /// <summary>Name of the table from which the records will be fetched.
        /// Must be a table, view or homogeneous collection.  </summary>
        public string table_name { get; set; }

        /// <summary>A positive integer indicating the number of initial
        /// results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </summary>
        public long offset { get; set; } = 0;

        /// <summary>A positive integer indicating the maximum number of
        /// results to be returned. Or END_OF_SET (-9999) to indicate that the
        /// max number of results should be returned.  </summary>
        public long limit { get; set; } = 10000;

        /// <summary>Specifies the encoding for returned records. Values:
        /// binary, json.
        ///   </summary>
        public string encoding { get; set; } = Encoding.BINARY;

        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term>expression</term>
        ///         <description>Optional filter expression to apply to the
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term>fast_index_lookup</term>
        ///         <description>Indicates if indexes should be used to perform
        /// the lookup for a given expression if possible. Only applicable if
        /// there is no sorting, the expression contains only equivalence
        /// comparisons based on existing tables indexes and the range of
        /// requested values is from [0 to END_OF_SET]. The default value is
        /// true.</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_by</term>
        ///         <description>Optional column that the data should be sorted
        /// by. Empty by default (i.e. no sorting is applied).</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_order</term>
        ///         <description>String indicating how the returned values
        /// should be sorted - ascending or descending. If sort_order is
        /// provided, sort_by has to be provided. Values: ascending,
        /// descending.
        /// </description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a GetRecordsRequest object with default
        /// parameters.</summary>
        public GetRecordsRequest() { }

        /// <summary>Constructs a GetRecordsRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table from which the records
        /// will be fetched. Must be a table, view or homogeneous collection.
        /// </param>
        /// <param name="offset">A positive integer indicating the number of
        /// initial results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </param>
        /// <param name="limit">A positive integer indicating the maximum
        /// number of results to be returned. Or END_OF_SET (-9999) to indicate
        /// that the max number of results should be returned.  </param>
        /// <param name="options">
        /// <list type="bullet">
        ///     <item>
        ///         <term>expression</term>
        ///         <description>Optional filter expression to apply to the
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term>fast_index_lookup</term>
        ///         <description>Indicates if indexes should be used to perform
        /// the lookup for a given expression if possible. Only applicable if
        /// there is no sorting, the expression contains only equivalence
        /// comparisons based on existing tables indexes and the range of
        /// requested values is from [0 to END_OF_SET]. The default value is
        /// true.</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_by</term>
        ///         <description>Optional column that the data should be sorted
        /// by. Empty by default (i.e. no sorting is applied).</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_order</term>
        ///         <description>String indicating how the returned values
        /// should be sorted - ascending or descending. If sort_order is
        /// provided, sort_by has to be provided. Values: ascending,
        /// descending.
        /// </description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public GetRecordsRequest( string table_name,
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


        /// <summary>Constructs a GetRecordsRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table from which the records
        /// will be fetched. Must be a table, view or homogeneous collection.
        /// </param>
        /// <param name="offset">A positive integer indicating the number of
        /// initial results to skip (this can be useful for paging through the
        /// results).  The minimum allowed value is 0. The maximum allowed
        /// value is MAX_INT. </param>
        /// <param name="limit">A positive integer indicating the maximum
        /// number of results to be returned. Or END_OF_SET (-9999) to indicate
        /// that the max number of results should be returned.  </param>
        /// <param name="encoding">Specifies the encoding for returned records.
        /// Values: binary, json.
        ///   </param>
        /// <param name="options">
        /// <list type="bullet">
        ///     <item>
        ///         <term>expression</term>
        ///         <description>Optional filter expression to apply to the
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term>fast_index_lookup</term>
        ///         <description>Indicates if indexes should be used to perform
        /// the lookup for a given expression if possible. Only applicable if
        /// there is no sorting, the expression contains only equivalence
        /// comparisons based on existing tables indexes and the range of
        /// requested values is from [0 to END_OF_SET]. The default value is
        /// true.</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_by</term>
        ///         <description>Optional column that the data should be sorted
        /// by. Empty by default (i.e. no sorting is applied).</description>
        ///     </item>
        ///     <item>
        ///         <term>sort_order</term>
        ///         <description>String indicating how the returned values
        /// should be sorted - ascending or descending. If sort_order is
        /// provided, sort_by has to be provided. Values: ascending,
        /// descending.
        /// </description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public GetRecordsRequest( string table_name,
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

    } // end class GetRecordsRequest



    /// <summary>A set of results returned by /get/records.</summary>
    public class RawGetRecordsResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="GetRecordsRequest.table_name" />.
        /// </summary>
        public string table_name { get; set; }
        public string type_name { get; set; }

        /// <summary>Avro schema of <member name="records_binary" /> or <member
        /// name="records_json" />  </summary>
        public string type_schema { get; set; }

        /// <summary>If the <paramref cref="GetRecordsRequest.encoding" /> was
        /// 'binary', then this list contains the JSON encoded records
        /// retrieved from the set, otherwise not populated.  </summary>
        public IList<byte[]> records_binary { get; set; } = new List<byte[]>();

        /// <summary>If the <paramref cref="GetRecordsRequest.encoding" /> was
        /// 'json', then this list contains the JSON encoded records retrieved
        /// from the set, otherwise not populated.  </summary>
        public IList<string> records_json { get; set; } = new List<string>();

        /// <summary>Total/Filtered number of records.  </summary>
        public long total_number_of_records { get; set; }

        /// <summary>Too many records. Returned a partial set.  </summary>
        public bool has_more_records { get; set; }

    } // end class RawGetRecordsResponse



    /// <summary>A set of results returned by /get/records.</summary>
    /// 
    /// <typeparam name="T">The type of object being processed.</typeparam>
    /// 
    public class GetRecordsResponse<T> : KineticaData
    {

        /// <summary>Value of <paramref cref="GetRecordsRequest.table_name" />.
        /// </summary>
        public string table_name { get; set; }
        public string type_name { get; set; }

        /// <summary>Avro schema of <member name="records_binary" /> or <member
        /// name="records_json" />  </summary>
        public string type_schema { get; set; }

        /// <summary>If the <paramref cref="GetRecordsRequest.encoding" /> was
        /// 'binary', then this list contains the JSON encoded records
        /// retrieved from the set, otherwise not populated.  </summary>
        public IList<T> data { get; set; } = new List<T>();

        /// <summary>Total/Filtered number of records.  </summary>
        public long total_number_of_records { get; set; }

        /// <summary>Too many records. Returned a partial set.  </summary>
        public bool has_more_records { get; set; }

    } // end class GetRecordsResponse




}  // end namespace kinetica
