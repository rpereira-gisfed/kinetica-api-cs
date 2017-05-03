/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /show/tables/bytype.
    /// <br />
    /// Gets names of the tables whose type matches the given criteria. Each
    /// table has a particular type. This type is made out of the type label,
    /// schema of the table, and the semantic type of the table. This function
    /// allows a look up of the existing tables based on full or partial type
    /// information. The operation is synchronous.</summary>
    public class ShowTablesByTypeRequest : KineticaData
    {

        /// <summary>Type id returned by a call to /create/type.  </summary>
        public string type_id { get; set; }

        /// <summary>Optional user supplied label which can be used instead of
        /// the type_id to retrieve all tables with the given label.
        /// </summary>
        public string label { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a ShowTablesByTypeRequest object with default
        /// parameters.</summary>
        public ShowTablesByTypeRequest() { }

        /// <summary>Constructs a ShowTablesByTypeRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="type_id">Type id returned by a call to /create/type.
        /// </param>
        /// <param name="label">Optional user supplied label which can be used
        /// instead of the type_id to retrieve all tables with the given label.
        /// </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public ShowTablesByTypeRequest( string type_id,
                                        string label,
                                        IDictionary<string, string> options = null)
        {
            this.type_id = type_id ?? "";
            this.label = label ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class ShowTablesByTypeRequest



    /// <summary>A set of results returned by /show/tables/bytype.</summary>
    public class ShowTablesByTypeResponse : KineticaData
    {

        /// <summary>List of tables matching the input criteria.  </summary>
        public IList<string> table_names { get; set; } = new List<string>();

    } // end class ShowTablesByTypeResponse




}  // end namespace kinetica
