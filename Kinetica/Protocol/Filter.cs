/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.filter(string,string,string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Filters data based on the specified expression.  The results are stored
    /// in a <a href="../../concepts/filtered_views.html" target="_top">result
    /// set</a> with the given <see cref="view_name" />.
    /// <br />
    /// For details see <a href="../../concepts/expressions.html"
    /// target="_top">Expressions</a>.
    /// <br />
    /// The response message contains the number of points for which the
    /// expression evaluated to be true, which is equivalent to the size of the
    /// result view.</summary>
    public class FilterRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.VIEW_ID">VIEW_ID</see>:</term>
        ///         <description>view this filtered-view is part
        /// of</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a href="../../concepts/ttl.html"
        /// target="_top">TTL</a> of the view specified in <paramref
        /// cref="FilterRequest.view_name" />.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Name of a collection which is to contain the newly
            /// created view. If the collection provided is non-existent, the
            /// collection will be automatically created. If empty, then the
            /// newly created view will be top-level.</summary>
            public const string COLLECTION_NAME = "collection_name";

            /// <summary>view this filtered-view is part of</summary>
            public const string VIEW_ID = "view_id";

            /// <summary>Sets the <a href="../../concepts/ttl.html"
            /// target="_top">TTL</a> of the view specified in <see
            /// cref="view_name" />.</summary>
            public const string TTL = "ttl";
        } // end struct Options


        /// <summary>Name of the table to filter.  This may be the ID of a
        /// collection, table or a result set (for chaining queries). If
        /// filtering a collection, all child tables where the filter
        /// expression is valid will be filtered; the filtered result tables
        /// will then be placed in a collection specified by <paramref
        /// cref="FilterRequest.view_name" />.  </summary>
        public string table_name { get; set; }

        /// <summary>If provided, then this will be the name of the view
        /// containing the results. Has the same naming restrictions as <a
        /// href="../../concepts/tables.html" target="_top">tables</a>.
        /// </summary>
        public string view_name { get; set; } = "";

        /// <summary>The select expression to filter the specified table.  For
        /// details see <a href="../../concepts/expressions.html"
        /// target="_top">Expressions</a>.  </summary>
        public string expression { get; set; }

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.VIEW_ID">VIEW_ID</see>:</term>
        ///         <description>view this filtered-view is part
        /// of</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a href="../../concepts/ttl.html"
        /// target="_top">TTL</a> of the view specified in <paramref
        /// cref="FilterRequest.view_name" />.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a FilterRequest object with default
        /// parameters.</summary>
        public FilterRequest() { }

        /// <summary>Constructs a FilterRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table to filter.  This may be
        /// the ID of a collection, table or a result set (for chaining
        /// queries). If filtering a collection, all child tables where the
        /// filter expression is valid will be filtered; the filtered result
        /// tables will then be placed in a collection specified by <paramref
        /// cref="FilterRequest.view_name" />.  </param>
        /// <param name="view_name">If provided, then this will be the name of
        /// the view containing the results. Has the same naming restrictions
        /// as <a href="../../concepts/tables.html" target="_top">tables</a>.
        /// </param>
        /// <param name="expression">The select expression to filter the
        /// specified table.  For details see <a
        /// href="../../concepts/expressions.html"
        /// target="_top">Expressions</a>.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.VIEW_ID">VIEW_ID</see>:</term>
        ///         <description>view this filtered-view is part
        /// of</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a href="../../concepts/ttl.html"
        /// target="_top">TTL</a> of the view specified in <paramref
        /// cref="FilterRequest.view_name" />.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public FilterRequest( string table_name,
                              string view_name,
                              string expression,
                              IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.view_name = view_name ?? "";
            this.expression = expression ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class FilterRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.filter(string,string,string,IDictionary{string, string})"
    /// />.</summary>
    public class FilterResponse : KineticaData
    {

        /// <summary>The number of records that matched the given select
        /// expression.  </summary>
        public long count { get; set; }

    } // end class FilterResponse




}  // end namespace kinetica
