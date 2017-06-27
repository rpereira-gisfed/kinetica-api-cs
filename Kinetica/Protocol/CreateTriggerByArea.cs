/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /create/trigger/byarea.
    /// <br />
    /// Sets up an area trigger mechanism for two column_names for one or more
    /// tables. (This function is essentially the two-dimensional version of
    /// /create/trigger/byrange.) Once the trigger has been activated, any
    /// record added to the listed tables(s) via /insert/records with the
    /// chosen columns' values falling within the specified region will trip
    /// the trigger. All such records will be queued at the trigger port (by
    /// default '9001', but able to be retrieved via /show/system/status) for
    /// any listening client to collect. Active triggers can be cancelled by
    /// using the /clear/trigger endpoint or by clearing all relevant tables.
    /// <br />
    /// The output returns the trigger handle as well as indicating success or
    /// failure of the trigger activation.</summary>
    public class CreateTriggerByAreaRequest : KineticaData
    {

        /// <summary>User-created ID for the trigger. The ID can be
        /// alphanumeric, contain symbols, and must contain at least one
        /// character.  </summary>
        public string request_id { get; set; }

        /// <summary>Names of the tables on which the trigger will be activated
        /// and maintained.  </summary>
        public IList<string> table_names { get; set; } = new List<string>();

        /// <summary>Name of a numeric column on which the trigger is
        /// activated. Usually 'x' for geospatial data points.  </summary>
        public string x_column_name { get; set; }

        /// <summary>The respective coordinate values for the region on which
        /// the trigger is activated. This usually translates to the
        /// x-coordinates of a geospatial region.  </summary>
        public IList<double> x_vector { get; set; } = new List<double>();

        /// <summary>Name of a second numeric column on which the trigger is
        /// activated. Usually 'y' for geospatial data points.  </summary>
        public string y_column_name { get; set; }

        /// <summary>The respective coordinate values for the region on which
        /// the trigger is activated. This usually translates to the
        /// y-coordinates of a geospatial region. Must be the same length as
        /// xvals.  </summary>
        public IList<double> y_vector { get; set; } = new List<double>();

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a CreateTriggerByAreaRequest object with
        /// default parameters.</summary>
        public CreateTriggerByAreaRequest() { }

        /// <summary>Constructs a CreateTriggerByAreaRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="request_id">User-created ID for the trigger. The ID
        /// can be alphanumeric, contain symbols, and must contain at least one
        /// character.  </param>
        /// <param name="table_names">Names of the tables on which the trigger
        /// will be activated and maintained.  </param>
        /// <param name="x_column_name">Name of a numeric column on which the
        /// trigger is activated. Usually 'x' for geospatial data points.
        /// </param>
        /// <param name="x_vector">The respective coordinate values for the
        /// region on which the trigger is activated. This usually translates
        /// to the x-coordinates of a geospatial region.  </param>
        /// <param name="y_column_name">Name of a second numeric column on
        /// which the trigger is activated. Usually 'y' for geospatial data
        /// points.  </param>
        /// <param name="y_vector">The respective coordinate values for the
        /// region on which the trigger is activated. This usually translates
        /// to the y-coordinates of a geospatial region. Must be the same
        /// length as xvals.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public CreateTriggerByAreaRequest( string request_id,
                                           IList<string> table_names,
                                           string x_column_name,
                                           IList<double> x_vector,
                                           string y_column_name,
                                           IList<double> y_vector,
                                           IDictionary<string, string> options = null)
        {
            this.request_id = request_id ?? "";
            this.table_names = table_names ?? new List<string>();
            this.x_column_name = x_column_name ?? "";
            this.x_vector = x_vector ?? new List<double>();
            this.y_column_name = y_column_name ?? "";
            this.y_vector = y_vector ?? new List<double>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class CreateTriggerByAreaRequest



    /// <summary>A set of results returned by /create/trigger/byarea.</summary>
    public class CreateTriggerByAreaResponse : KineticaData
    {

        /// <summary>Value of <paramref
        /// cref="CreateTriggerByAreaRequest.request_id" />.  </summary>
        public string trigger_id { get; set; }

    } // end class CreateTriggerByAreaResponse




}  // end namespace kinetica
