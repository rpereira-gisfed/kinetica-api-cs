/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.filterByString(string,string,string,string,IList{string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Calculates which objects from a table, collection, or view match a
    /// string expression for the given string columns. The options
    /// 'case_sensitive' can be used to modify the behavior for all modes
    /// except 'search'. For 'search' mode details and limitations, see <a
    /// href="../../concepts/full_text_search.html" target="_top">Full Text
    /// Search</a>.</summary>
    public class FilterByStringRequest : KineticaData
    {

        /// <summary>The string filtering mode to apply. See below for details.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.SEARCH">SEARCH</see>:</term>
        ///         <description>Full text search query with wildcards and
        /// boolean operators. Note that for this mode, no column can be
        /// specified in <paramref cref="FilterByStringRequest.column_names"
        /// />; all string columns of the table that have text search enabled
        /// will be searched.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.EQUALS">EQUALS</see>:</term>
        ///         <description>Exact whole-string match
        /// (accelerated).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Partial substring match (not accelerated).  If
        /// the column is a string type (non-charN) and the number of records
        /// is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.STARTS_WITH">STARTS_WITH</see>:</term>
        ///         <description>Strings that start with the given expression
        /// (not accelerated). If the column is a string type (non-charN) and
        /// the number of records is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.REGEX">REGEX</see>:</term>
        ///         <description>Full regular expression search (not
        /// accelerated). If the column is a string type (non-charN) and the
        /// number of records is too large, it will return 0.</description>
        ///     </item>
        /// </list>
        /// A set of string constants for the parameter <see cref="mode"
        /// />.</summary>
        public struct Mode
        {

            /// <summary>Full text search query with wildcards and boolean
            /// operators. Note that for this mode, no column can be specified
            /// in <see cref="column_names" />; all string columns of the table
            /// that have text search enabled will be searched.</summary>
            public const string SEARCH = "search";

            /// <summary>Exact whole-string match (accelerated).</summary>
            public const string EQUALS = "equals";

            /// <summary>Partial substring match (not accelerated).  If the
            /// column is a string type (non-charN) and the number of records
            /// is too large, it will return 0.</summary>
            public const string CONTAINS = "contains";

            /// <summary>Strings that start with the given expression (not
            /// accelerated). If the column is a string type (non-charN) and
            /// the number of records is too large, it will return 0.</summary>
            public const string STARTS_WITH = "starts_with";

            /// <summary>Full regular expression search (not accelerated). If
            /// the column is a string type (non-charN) and the number of
            /// records is too large, it will return 0.</summary>
            public const string REGEX = "regex";
        } // end struct Mode


        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.CASE_SENSITIVE">CASE_SENSITIVE</see>:</term>
        ///         <description>If 'false' then string filtering will ignore
        /// case. Does not apply to 'search' mode.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see>.</description>
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

            /// <summary>If 'false' then string filtering will ignore case.
            /// Does not apply to 'search' mode.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="FilterByStringRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="FilterByStringRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="FilterByStringRequest.Options.TRUE">TRUE</see>.</summary>
            public const string CASE_SENSITIVE = "case_sensitive";
            public const string TRUE = "true";
            public const string FALSE = "false";
        } // end struct Options


        /// <summary>Name of the table on which the filter operation will be
        /// performed.  Must be an existing table, collection or view.
        /// </summary>
        public string table_name { get; set; }

        /// <summary>If provided, then this will be the name of the view
        /// containing the results. Has the same naming restrictions as <a
        /// href="../../concepts/tables.html" target="_top">tables</a>.
        /// </summary>
        public string view_name { get; set; } = "";

        /// <summary>The expression with which to filter the table.  </summary>
        public string expression { get; set; }

        /// <summary>The string filtering mode to apply. See below for details.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.SEARCH">SEARCH</see>:</term>
        ///         <description>Full text search query with wildcards and
        /// boolean operators. Note that for this mode, no column can be
        /// specified in <paramref cref="FilterByStringRequest.column_names"
        /// />; all string columns of the table that have text search enabled
        /// will be searched.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.EQUALS">EQUALS</see>:</term>
        ///         <description>Exact whole-string match
        /// (accelerated).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Partial substring match (not accelerated).  If
        /// the column is a string type (non-charN) and the number of records
        /// is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.STARTS_WITH">STARTS_WITH</see>:</term>
        ///         <description>Strings that start with the given expression
        /// (not accelerated). If the column is a string type (non-charN) and
        /// the number of records is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.REGEX">REGEX</see>:</term>
        ///         <description>Full regular expression search (not
        /// accelerated). If the column is a string type (non-charN) and the
        /// number of records is too large, it will return 0.</description>
        ///     </item>
        /// </list>  </summary>
        public string mode { get; set; }

        /// <summary>List of columns on which to apply the filter. Ignored for
        /// 'search' mode.  </summary>
        public IList<string> column_names { get; set; } = new List<string>();

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.CASE_SENSITIVE">CASE_SENSITIVE</see>:</term>
        ///         <description>If 'false' then string filtering will ignore
        /// case. Does not apply to 'search' mode.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see>.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a FilterByStringRequest object with default
        /// parameters.</summary>
        public FilterByStringRequest() { }

        /// <summary>Constructs a FilterByStringRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table on which the filter
        /// operation will be performed.  Must be an existing table, collection
        /// or view.  </param>
        /// <param name="view_name">If provided, then this will be the name of
        /// the view containing the results. Has the same naming restrictions
        /// as <a href="../../concepts/tables.html" target="_top">tables</a>.
        /// </param>
        /// <param name="expression">The expression with which to filter the
        /// table.  </param>
        /// <param name="mode">The string filtering mode to apply. See below
        /// for details.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.SEARCH">SEARCH</see>:</term>
        ///         <description>Full text search query with wildcards and
        /// boolean operators. Note that for this mode, no column can be
        /// specified in <paramref cref="FilterByStringRequest.column_names"
        /// />; all string columns of the table that have text search enabled
        /// will be searched.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.EQUALS">EQUALS</see>:</term>
        ///         <description>Exact whole-string match
        /// (accelerated).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Partial substring match (not accelerated).  If
        /// the column is a string type (non-charN) and the number of records
        /// is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.STARTS_WITH">STARTS_WITH</see>:</term>
        ///         <description>Strings that start with the given expression
        /// (not accelerated). If the column is a string type (non-charN) and
        /// the number of records is too large, it will return 0.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Mode.REGEX">REGEX</see>:</term>
        ///         <description>Full regular expression search (not
        /// accelerated). If the column is a string type (non-charN) and the
        /// number of records is too large, it will return 0.</description>
        ///     </item>
        /// </list>  </param>
        /// <param name="column_names">List of columns on which to apply the
        /// filter. Ignored for 'search' mode.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// newly created view. If the collection provided is non-existent, the
        /// collection will be automatically created. If empty, then the newly
        /// created view will be top-level.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.CASE_SENSITIVE">CASE_SENSITIVE</see>:</term>
        ///         <description>If 'false' then string filtering will ignore
        /// case. Does not apply to 'search' mode.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByStringRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="FilterByStringRequest.Options.TRUE">TRUE</see>.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public FilterByStringRequest( string table_name,
                                      string view_name,
                                      string expression,
                                      string mode,
                                      IList<string> column_names,
                                      IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.view_name = view_name ?? "";
            this.expression = expression ?? "";
            this.mode = mode ?? "";
            this.column_names = column_names ?? new List<string>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class FilterByStringRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.filterByString(string,string,string,string,IList{string},IDictionary{string, string})"
    /// />.</summary>
    public class FilterByStringResponse : KineticaData
    {

        /// <summary>The number of records that passed the string filter.
        /// </summary>
        public long count { get; set; }

    } // end class FilterByStringResponse




}  // end namespace kinetica
