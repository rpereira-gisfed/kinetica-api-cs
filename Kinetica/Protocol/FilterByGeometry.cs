/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.filterByGeometry(string,string,string,string,string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Applies a geometry filter against a geospatial geometry column in a
    /// given table, collection or view. The filtering geometry is provided by
    /// <see cref="input_wkt" />.</summary>
    public class FilterByGeometryRequest : KineticaData
    {

        /// <summary>The geometric filtering operation to perform
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Matches records that contain the given WKT in
        /// <paramref cref="FilterByGeometryRequest.input_wkt" />, i.e. the
        /// given WKT is within the bounds of a record's
        /// geometry.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CROSSES">CROSSES</see>:</term>
        ///         <description>Matches records that cross the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.DISJOINT">DISJOINT</see>:</term>
        ///         <description>Matches records that are disjoint from the
        /// given WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.EQUALS">EQUALS</see>:</term>
        ///         <description>Matches records that are the same as the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.INTERSECTS">INTERSECTS</see>:</term>
        ///         <description>Matches records that intersect the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.OVERLAPS">OVERLAPS</see>:</term>
        ///         <description>Matches records that overlap the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.TOUCHES">TOUCHES</see>:</term>
        ///         <description>Matches records that touch the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.WITHIN">WITHIN</see>:</term>
        ///         <description>Matches records that are within the given
        /// WKT.</description>
        ///     </item>
        /// </list>
        /// A set of string constants for the parameter <see cref="operation"
        /// />.</summary>
        public struct Operation
        {

            /// <summary>Matches records that contain the given WKT in <see
            /// cref="input_wkt" />, i.e. the given WKT is within the bounds of
            /// a record's geometry.</summary>
            public const string CONTAINS = "contains";

            /// <summary>Matches records that cross the given WKT.</summary>
            public const string CROSSES = "crosses";

            /// <summary>Matches records that are disjoint from the given
            /// WKT.</summary>
            public const string DISJOINT = "disjoint";

            /// <summary>Matches records that are the same as the given
            /// WKT.</summary>
            public const string EQUALS = "equals";

            /// <summary>Matches records that intersect the given
            /// WKT.</summary>
            public const string INTERSECTS = "intersects";

            /// <summary>Matches records that overlap the given WKT.</summary>
            public const string OVERLAPS = "overlaps";

            /// <summary>Matches records that touch the given WKT.</summary>
            public const string TOUCHES = "touches";

            /// <summary>Matches records that are within the given
            /// WKT.</summary>
            public const string WITHIN = "within";
        } // end struct Operation


        /// <summary>Name of the table on which the filter by geometry will be
        /// performed.  Must be an existing table, collection or view
        /// containing a geospatial geometry column.  </summary>
        public string table_name { get; set; }

        /// <summary>If provided, then this will be the name of the view
        /// containing the results. Has the same naming restrictions as <a
        /// href="../../../../concepts/tables.html" target="_top">tables</a>.
        /// </summary>
        public string view_name { get; set; } = "";

        /// <summary>Name of the column to be used in the filter. Must be a
        /// geospatial geometry column.  </summary>
        public string column_name { get; set; }

        /// <summary>A geometry in WKT format that will be used to filter the
        /// objects in <paramref cref="FilterByGeometryRequest.table_name" />.
        /// </summary>
        public string input_wkt { get; set; } = "";

        /// <summary>The geometric filtering operation to perform
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Matches records that contain the given WKT in
        /// <paramref cref="FilterByGeometryRequest.input_wkt" />, i.e. the
        /// given WKT is within the bounds of a record's
        /// geometry.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CROSSES">CROSSES</see>:</term>
        ///         <description>Matches records that cross the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.DISJOINT">DISJOINT</see>:</term>
        ///         <description>Matches records that are disjoint from the
        /// given WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.EQUALS">EQUALS</see>:</term>
        ///         <description>Matches records that are the same as the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.INTERSECTS">INTERSECTS</see>:</term>
        ///         <description>Matches records that intersect the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.OVERLAPS">OVERLAPS</see>:</term>
        ///         <description>Matches records that overlap the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.TOUCHES">TOUCHES</see>:</term>
        ///         <description>Matches records that touch the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.WITHIN">WITHIN</see>:</term>
        ///         <description>Matches records that are within the given
        /// WKT.</description>
        ///     </item>
        /// </list>  </summary>
        public string operation { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a FilterByGeometryRequest object with default
        /// parameters.</summary>
        public FilterByGeometryRequest() { }

        /// <summary>Constructs a FilterByGeometryRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table on which the filter by
        /// geometry will be performed.  Must be an existing table, collection
        /// or view containing a geospatial geometry column.  </param>
        /// <param name="view_name">If provided, then this will be the name of
        /// the view containing the results. Has the same naming restrictions
        /// as <a href="../../../../concepts/tables.html"
        /// target="_top">tables</a>.  </param>
        /// <param name="column_name">Name of the column to be used in the
        /// filter. Must be a geospatial geometry column.  </param>
        /// <param name="input_wkt">A geometry in WKT format that will be used
        /// to filter the objects in <paramref
        /// cref="FilterByGeometryRequest.table_name" />.  </param>
        /// <param name="operation">The geometric filtering operation to
        /// perform
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CONTAINS">CONTAINS</see>:</term>
        ///         <description>Matches records that contain the given WKT in
        /// <paramref cref="FilterByGeometryRequest.input_wkt" />, i.e. the
        /// given WKT is within the bounds of a record's
        /// geometry.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.CROSSES">CROSSES</see>:</term>
        ///         <description>Matches records that cross the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.DISJOINT">DISJOINT</see>:</term>
        ///         <description>Matches records that are disjoint from the
        /// given WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.EQUALS">EQUALS</see>:</term>
        ///         <description>Matches records that are the same as the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.INTERSECTS">INTERSECTS</see>:</term>
        ///         <description>Matches records that intersect the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.OVERLAPS">OVERLAPS</see>:</term>
        ///         <description>Matches records that overlap the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.TOUCHES">TOUCHES</see>:</term>
        ///         <description>Matches records that touch the given
        /// WKT.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="FilterByGeometryRequest.Operation.WITHIN">WITHIN</see>:</term>
        ///         <description>Matches records that are within the given
        /// WKT.</description>
        ///     </item>
        /// </list>  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public FilterByGeometryRequest( string table_name,
                                        string view_name,
                                        string column_name,
                                        string input_wkt,
                                        string operation,
                                        IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.view_name = view_name ?? "";
            this.column_name = column_name ?? "";
            this.input_wkt = input_wkt ?? "";
            this.operation = operation ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class FilterByGeometryRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.filterByGeometry(string,string,string,string,string,IDictionary{string, string})"
    /// />.</summary>
    public class FilterByGeometryResponse : KineticaData
    {

        /// <summary>The number of records passing the geometry filter.
        /// </summary>
        public long count { get; set; }

    } // end class FilterByGeometryResponse




}  // end namespace kinetica
