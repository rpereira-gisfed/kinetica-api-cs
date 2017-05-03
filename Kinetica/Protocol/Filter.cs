/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /filter.
    /// <br />
    /// Filters data based on the specified expression.  The results are stored
    /// in a result set with the given <member name="view_name" />.
    /// <br />
    /// For details see <a href="../../../../../concepts/expressions.html"
    /// target="_top">concepts</a>.
    /// <br />
    /// The response message contains the number of points for which the
    /// expression evaluated to be true, which is equivalent to the size of the
    /// result view.</summary>
    public class FilterRequest : KineticaData
    {

        /// <summary>Name of the table to filter.  This may be the ID of a
        /// collection, table or a result set (for chaining queries).
        /// Collections may be filtered only if all tables within the
        /// collection have the same type ID.  </summary>
        public string table_name { get; set; }

        /// <summary>If provided, then this will be the name of the view
        /// containing the results. Has the same naming restrictions as <a
        /// href="../../../../concepts/tables.html" target="_top">tables</a>.
        /// </summary>
        public string view_name { get; set; } = "";

        /// <summary>The select expression to filter the specified table.  For
        /// details see <a href="../../../../concepts/expressions.html"
        /// target="_top">concepts</a>.  </summary>
        public string expression { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a FilterRequest object with default
        /// parameters.</summary>
        public FilterRequest() { }

        /// <summary>Constructs a FilterRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table to filter.  This may be
        /// the ID of a collection, table or a result set (for chaining
        /// queries).  Collections may be filtered only if all tables within
        /// the collection have the same type ID.  </param>
        /// <param name="view_name">If provided, then this will be the name of
        /// the view containing the results. Has the same naming restrictions
        /// as <a href="../../../../concepts/tables.html"
        /// target="_top">tables</a>.  </param>
        /// <param name="expression">The select expression to filter the
        /// specified table.  For details see <a
        /// href="../../../../concepts/expressions.html"
        /// target="_top">concepts</a>.  </param>
        /// <param name="options">Optional parameters.  </param>
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



    /// <summary>A set of results returned by /filter.</summary>
    public class FilterResponse : KineticaData
    {

        /// <summary>The number of records that matched the given select
        /// expression.  </summary>
        public long count { get; set; }

    } // end class FilterResponse




}  // end namespace kinetica
