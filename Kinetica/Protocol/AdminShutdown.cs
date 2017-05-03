/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /admin/shutdown.
    /// <br />
    /// Exits the database server application.</summary>
    public class AdminShutdownRequest : KineticaData
    {

        /// <summary>Reserved for future use. User can pass an empty string.
        /// </summary>
        public string exit_type { get; set; }

        /// <summary>No longer used. User can pass an empty string.  </summary>
        public string authorization { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminShutdownRequest object with default
        /// parameters.</summary>
        public AdminShutdownRequest() { }

        /// <summary>Constructs an AdminShutdownRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="exit_type">Reserved for future use. User can pass an
        /// empty string.  </param>
        /// <param name="authorization">No longer used. User can pass an empty
        /// string.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AdminShutdownRequest( string exit_type,
                                     string authorization,
                                     IDictionary<string, string> options = null)
        {
            this.exit_type = exit_type ?? "";
            this.authorization = authorization ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminShutdownRequest



    /// <summary>A set of results returned by /admin/shutdown.</summary>
    public class AdminShutdownResponse : KineticaData
    {

        /// <summary>'OK' upon (right before) successful exit.  </summary>
        public string exit_status { get; set; }

    } // end class AdminShutdownResponse




}  // end namespace kinetica
