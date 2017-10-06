/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.deleteRecords(string,IList{string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Deletes record(s) matching the provided criteria from the given table.
    /// The record selection criteria can either be one or more  <see
    /// cref="expressions" /> (matching multiple records) or a single record
    /// identified by <i>record_id</i> options.  Note that the two selection
    /// criteria are mutually exclusive.  This operation cannot be run on a
    /// collection or a view.  The operation is synchronous meaning that a
    /// response will not be available until the request is completely
    /// processed and all the matching records are deleted.</summary>
    public class DeleteRecordsRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.GLOBAL_EXPRESSION">GLOBAL_EXPRESSION</see>:</term>
        ///         <description>An optional global expression to reduce the
        /// search space of the <paramref
        /// cref="DeleteRecordsRequest.expressions" />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.RECORD_ID">RECORD_ID</see>:</term>
        ///         <description>A record id identifying a single record,
        /// obtained at the time of /insert/records or by calling
        /// /get/records/fromcollection with the *return_record_ids*
        /// option.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>An optional global expression to reduce the search
            /// space of the <see cref="expressions" />.</summary>
            public const string GLOBAL_EXPRESSION = "global_expression";

            /// <summary>A record id identifying a single record, obtained at
            /// the time of <see
            /// cref="Kinetica.insertRecords{T}(string,IList{T},IDictionary{string, string})">insertion
            /// of the record</see> or by calling <see
            /// cref="Kinetica.getRecordsFromCollection{T}(string,long,long,IDictionary{string, string})"
            /// /> with the *return_record_ids* option.</summary>
            public const string RECORD_ID = "record_id";
        } // end struct Options


        /// <summary>Name of the table from which to delete records. The set
        /// must be a currently existing table and not a collection or a view.
        /// </summary>
        public string table_name { get; set; }

        /// <summary>A list of the actual predicates, one for each select;
        /// format should follow the guidelines provided /filter. Specifying
        /// one or more <paramref cref="DeleteRecordsRequest.expressions" /> is
        /// mutually exclusive to specifying <i>record_id</i> in the <paramref
        /// cref="DeleteRecordsRequest.options" />.  </summary>
        public IList<string> expressions { get; set; } = new List<string>();

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.GLOBAL_EXPRESSION">GLOBAL_EXPRESSION</see>:</term>
        ///         <description>An optional global expression to reduce the
        /// search space of the <paramref
        /// cref="DeleteRecordsRequest.expressions" />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.RECORD_ID">RECORD_ID</see>:</term>
        ///         <description>A record id identifying a single record,
        /// obtained at the time of /insert/records or by calling
        /// /get/records/fromcollection with the *return_record_ids*
        /// option.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a DeleteRecordsRequest object with default
        /// parameters.</summary>
        public DeleteRecordsRequest() { }

        /// <summary>Constructs a DeleteRecordsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table from which to delete
        /// records. The set must be a currently existing table and not a
        /// collection or a view.  </param>
        /// <param name="expressions">A list of the actual predicates, one for
        /// each select; format should follow the guidelines provided /filter.
        /// Specifying one or more <paramref
        /// cref="DeleteRecordsRequest.expressions" /> is mutually exclusive to
        /// specifying <i>record_id</i> in the <paramref
        /// cref="DeleteRecordsRequest.options" />.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.GLOBAL_EXPRESSION">GLOBAL_EXPRESSION</see>:</term>
        ///         <description>An optional global expression to reduce the
        /// search space of the <paramref
        /// cref="DeleteRecordsRequest.expressions" />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="DeleteRecordsRequest.Options.RECORD_ID">RECORD_ID</see>:</term>
        ///         <description>A record id identifying a single record,
        /// obtained at the time of /insert/records or by calling
        /// /get/records/fromcollection with the *return_record_ids*
        /// option.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public DeleteRecordsRequest( string table_name,
                                     IList<string> expressions,
                                     IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.expressions = expressions ?? new List<string>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class DeleteRecordsRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.deleteRecords(string,IList{string},IDictionary{string, string})"
    /// />.</summary>
    public class DeleteRecordsResponse : KineticaData
    {

        /// <summary>Total number of records deleted across all expressions.
        /// </summary>
        public long count_deleted { get; set; }

        /// <summary>Total number of records deleted per expression.
        /// </summary>
        public IList<long> counts_deleted { get; set; } = new List<long>();

    } // end class DeleteRecordsResponse




}  // end namespace kinetica
