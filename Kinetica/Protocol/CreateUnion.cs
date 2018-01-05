/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.createUnion(string,IList{string},IList{IList{string}},IList{string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// Performs a <a href="../../../../../concepts/unions.html"
    /// target="_top">union</a> (concatenation) of one or more existing tables
    /// or views, the results of which are stored in a new table. It is
    /// equivalent to the SQL UNION ALL operator.  Non-charN 'string' and
    /// 'bytes' column types cannot be included in a union, neither can columns
    /// with the property 'store_only'. Though not explicitly unions, <a
    /// href="../../../../../concepts/intersect.html"
    /// target="_top">intersect</a> and <a
    /// href="../../../../../concepts/except.html" target="_top">except</a> are
    /// also available from this endpoint.</summary>
    public class CreateUnionRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// union. If the collection provided is non-existent, the collection
        /// will be automatically created. If empty, then the union will be a
        /// top-level table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MATERIALIZE_ON_GPU">MATERIALIZE_ON_GPU</see>:</term>
        ///         <description>If 'true' then the columns of the union will
        /// be cached on the GPU.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MODE">MODE</see>:</term>
        ///         <description>If 'merge_views' then this operation will
        /// merge (i.e. union) the provided views. All 'table_names' must be
        /// views from the same underlying base table.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>:</term>
        ///         <description>Retains all rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION">UNION</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables (synonym for 'union_distinct').</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_DISTINCT">UNION_DISTINCT</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.EXCEPT">EXCEPT</see>:</term>
        ///         <description>Retains all unique rows from the first table
        /// that do not appear in the second table (only works on 2
        /// tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.INTERSECT">INTERSECT</see>:</term>
        ///         <description>Retains all unique rows that appear in both of
        /// the specified tables (only works on 2 tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MERGE_VIEWS">MERGE_VIEWS</see>:</term>
        ///         <description>Merge two or more views (or views of views) of
        /// the same base data set into a new view. If this mode is selected
        /// <paramref cref="CreateUnionRequest.input_column_names" /> AND
        /// <paramref cref="CreateUnionRequest.output_column_names" /> must be
        /// empty. The resulting view would match the results of a SQL OR
        /// operation, e.g., if filter 1 creates a view using the expression 'x
        /// = 10' and filter 2 creates a view using the expression 'x <= 10',
        /// then the merge views operation creates a new view using the
        /// expression 'x = 10 OR x <= 10'.</description>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>Indicates the chunk size to be used for this
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a
        /// href="../../../../concepts/ttl.html" target="_top">TTL</a> of the
        /// table specified in <paramref cref="CreateUnionRequest.table_name"
        /// />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.PERSIST">PERSIST</see>:</term>
        ///         <description>If <i>true</i>, then the union specified in
        /// <paramref cref="CreateUnionRequest.table_name" /> will be persisted
        /// and will not expire unless a <i>ttl</i> is specified.   If
        /// <i>false</i>, then the union will be an in-memory table and will
        /// expire unless a <i>ttl</i> is specified otherwise.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>Name of a collection which is to contain the union. If
            /// the collection provided is non-existent, the collection will be
            /// automatically created. If empty, then the union will be a
            /// top-level table.</summary>
            public const string COLLECTION_NAME = "collection_name";

            /// <summary>If 'true' then the columns of the union will be cached
            /// on the GPU.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</summary>
            public const string MATERIALIZE_ON_GPU = "materialize_on_gpu";
            public const string TRUE = "true";
            public const string FALSE = "false";

            /// <summary>If 'merge_views' then this operation will merge (i.e.
            /// union) the provided views. All 'table_names' must be views from
            /// the same underlying base table.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>:</term>
            ///         <description>Retains all rows from the specified
            /// tables.</description>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.UNION">UNION</see>:</term>
            ///         <description>Retains all unique rows from the specified
            /// tables (synonym for 'union_distinct').</description>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.UNION_DISTINCT">UNION_DISTINCT</see>:</term>
            ///         <description>Retains all unique rows from the specified
            /// tables.</description>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.EXCEPT">EXCEPT</see>:</term>
            ///         <description>Retains all unique rows from the first
            /// table that do not appear in the second table (only works on 2
            /// tables).</description>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.INTERSECT">INTERSECT</see>:</term>
            ///         <description>Retains all unique rows that appear in
            /// both of the specified tables (only works on 2
            /// tables).</description>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.MERGE_VIEWS">MERGE_VIEWS</see>:</term>
            ///         <description>Merge two or more views (or views of
            /// views) of the same base data set into a new view. If this mode
            /// is selected <see cref="input_column_names" /> AND <see
            /// cref="output_column_names" /> must be empty. The resulting view
            /// would match the results of a SQL OR operation, e.g., if filter
            /// 1 creates a view using the expression 'x = 10' and filter 2
            /// creates a view using the expression 'x <= 10', then the merge
            /// views operation creates a new view using the expression 'x = 10
            /// OR x <= 10'.</description>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>.</summary>
            public const string MODE = "mode";

            /// <summary>Retains all rows from the specified tables.</summary>
            public const string UNION_ALL = "union_all";

            /// <summary>Retains all unique rows from the specified tables
            /// (synonym for 'union_distinct').</summary>
            public const string UNION = "union";

            /// <summary>Retains all unique rows from the specified
            /// tables.</summary>
            public const string UNION_DISTINCT = "union_distinct";

            /// <summary>Retains all unique rows from the first table that do
            /// not appear in the second table (only works on 2
            /// tables).</summary>
            public const string EXCEPT = "except";

            /// <summary>Retains all unique rows that appear in both of the
            /// specified tables (only works on 2 tables).</summary>
            public const string INTERSECT = "intersect";

            /// <summary>Merge two or more views (or views of views) of the
            /// same base data set into a new view. If this mode is selected
            /// <see cref="input_column_names" /> AND <see
            /// cref="output_column_names" /> must be empty. The resulting view
            /// would match the results of a SQL OR operation, e.g., if filter
            /// 1 creates a view using the expression 'x = 10' and filter 2
            /// creates a view using the expression 'x <= 10', then the merge
            /// views operation creates a new view using the expression 'x = 10
            /// OR x <= 10'.</summary>
            public const string MERGE_VIEWS = "merge_views";

            /// <summary>Indicates the chunk size to be used for this
            /// table.</summary>
            public const string CHUNK_SIZE = "chunk_size";

            /// <summary>Sets the <a href="../../../../../concepts/ttl.html"
            /// target="_top">TTL</a> of the table specified in <see
            /// cref="table_name" />.</summary>
            public const string TTL = "ttl";

            /// <summary>If <i>true</i>, then the union specified in <see
            /// cref="table_name" /> will be persisted and will not expire
            /// unless a <i>ttl</i> is specified.   If <i>false</i>, then the
            /// union will be an in-memory table and will expire unless a
            /// <i>ttl</i> is specified otherwise.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</summary>
            public const string PERSIST = "persist";
        } // end struct Options


        /// <summary>Name of the table to be created. Has the same naming
        /// restrictions as <a href="../../../../concepts/tables.html"
        /// target="_top">tables</a>.  </summary>
        public string table_name { get; set; }

        /// <summary>The list of table names making up the union. Must contain
        /// the names of one or more existing tables.  </summary>
        public IList<string> table_names { get; set; } = new List<string>();

        /// <summary>The list of columns from each of the corresponding input
        /// tables.  </summary>
        public IList<IList<string>> input_column_names { get; set; } = new List<IList<string>>();

        /// <summary>The list of names of the columns to be stored in the
        /// union.  </summary>
        public IList<string> output_column_names { get; set; } = new List<string>();

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// union. If the collection provided is non-existent, the collection
        /// will be automatically created. If empty, then the union will be a
        /// top-level table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MATERIALIZE_ON_GPU">MATERIALIZE_ON_GPU</see>:</term>
        ///         <description>If 'true' then the columns of the union will
        /// be cached on the GPU.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MODE">MODE</see>:</term>
        ///         <description>If 'merge_views' then this operation will
        /// merge (i.e. union) the provided views. All 'table_names' must be
        /// views from the same underlying base table.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>:</term>
        ///         <description>Retains all rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION">UNION</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables (synonym for 'union_distinct').</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_DISTINCT">UNION_DISTINCT</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.EXCEPT">EXCEPT</see>:</term>
        ///         <description>Retains all unique rows from the first table
        /// that do not appear in the second table (only works on 2
        /// tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.INTERSECT">INTERSECT</see>:</term>
        ///         <description>Retains all unique rows that appear in both of
        /// the specified tables (only works on 2 tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MERGE_VIEWS">MERGE_VIEWS</see>:</term>
        ///         <description>Merge two or more views (or views of views) of
        /// the same base data set into a new view. If this mode is selected
        /// <paramref cref="CreateUnionRequest.input_column_names" /> AND
        /// <paramref cref="CreateUnionRequest.output_column_names" /> must be
        /// empty. The resulting view would match the results of a SQL OR
        /// operation, e.g., if filter 1 creates a view using the expression 'x
        /// = 10' and filter 2 creates a view using the expression 'x <= 10',
        /// then the merge views operation creates a new view using the
        /// expression 'x = 10 OR x <= 10'.</description>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>Indicates the chunk size to be used for this
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a
        /// href="../../../../concepts/ttl.html" target="_top">TTL</a> of the
        /// table specified in <paramref cref="CreateUnionRequest.table_name"
        /// />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.PERSIST">PERSIST</see>:</term>
        ///         <description>If <i>true</i>, then the union specified in
        /// <paramref cref="CreateUnionRequest.table_name" /> will be persisted
        /// and will not expire unless a <i>ttl</i> is specified.   If
        /// <i>false</i>, then the union will be an in-memory table and will
        /// expire unless a <i>ttl</i> is specified otherwise.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a CreateUnionRequest object with default
        /// parameters.</summary>
        public CreateUnionRequest() { }

        /// <summary>Constructs a CreateUnionRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table to be created. Has the
        /// same naming restrictions as <a
        /// href="../../../../concepts/tables.html" target="_top">tables</a>.
        /// </param>
        /// <param name="table_names">The list of table names making up the
        /// union. Must contain the names of one or more existing tables.
        /// </param>
        /// <param name="input_column_names">The list of columns from each of
        /// the corresponding input tables.  </param>
        /// <param name="output_column_names">The list of names of the columns
        /// to be stored in the union.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.COLLECTION_NAME">COLLECTION_NAME</see>:</term>
        ///         <description>Name of a collection which is to contain the
        /// union. If the collection provided is non-existent, the collection
        /// will be automatically created. If empty, then the union will be a
        /// top-level table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MATERIALIZE_ON_GPU">MATERIALIZE_ON_GPU</see>:</term>
        ///         <description>If 'true' then the columns of the union will
        /// be cached on the GPU.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MODE">MODE</see>:</term>
        ///         <description>If 'merge_views' then this operation will
        /// merge (i.e. union) the provided views. All 'table_names' must be
        /// views from the same underlying base table.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>:</term>
        ///         <description>Retains all rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION">UNION</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables (synonym for 'union_distinct').</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.UNION_DISTINCT">UNION_DISTINCT</see>:</term>
        ///         <description>Retains all unique rows from the specified
        /// tables.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.EXCEPT">EXCEPT</see>:</term>
        ///         <description>Retains all unique rows from the first table
        /// that do not appear in the second table (only works on 2
        /// tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.INTERSECT">INTERSECT</see>:</term>
        ///         <description>Retains all unique rows that appear in both of
        /// the specified tables (only works on 2 tables).</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.MERGE_VIEWS">MERGE_VIEWS</see>:</term>
        ///         <description>Merge two or more views (or views of views) of
        /// the same base data set into a new view. If this mode is selected
        /// <paramref cref="CreateUnionRequest.input_column_names" /> AND
        /// <paramref cref="CreateUnionRequest.output_column_names" /> must be
        /// empty. The resulting view would match the results of a SQL OR
        /// operation, e.g., if filter 1 creates a view using the expression 'x
        /// = 10' and filter 2 creates a view using the expression 'x <= 10',
        /// then the merge views operation creates a new view using the
        /// expression 'x = 10 OR x <= 10'.</description>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.UNION_ALL">UNION_ALL</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.CHUNK_SIZE">CHUNK_SIZE</see>:</term>
        ///         <description>Indicates the chunk size to be used for this
        /// table.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TTL">TTL</see>:</term>
        ///         <description>Sets the <a
        /// href="../../../../concepts/ttl.html" target="_top">TTL</a> of the
        /// table specified in <paramref cref="CreateUnionRequest.table_name"
        /// />.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.PERSIST">PERSIST</see>:</term>
        ///         <description>If <i>true</i>, then the union specified in
        /// <paramref cref="CreateUnionRequest.table_name" /> will be persisted
        /// and will not expire unless a <i>ttl</i> is specified.   If
        /// <i>false</i>, then the union will be an in-memory table and will
        /// expire unless a <i>ttl</i> is specified otherwise.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="CreateUnionRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public CreateUnionRequest( string table_name,
                                   IList<string> table_names,
                                   IList<IList<string>> input_column_names,
                                   IList<string> output_column_names,
                                   IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.table_names = table_names ?? new List<string>();
            this.input_column_names = input_column_names ?? new List<IList<string>>();
            this.output_column_names = output_column_names ?? new List<string>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class CreateUnionRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.createUnion(string,IList{string},IList{IList{string}},IList{string},IDictionary{string, string})"
    /// />.</summary>
    public class CreateUnionResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="CreateUnionRequest.table_name"
        /// />.  </summary>
        public string table_name { get; set; }

    } // end class CreateUnionResponse




}  // end namespace kinetica
