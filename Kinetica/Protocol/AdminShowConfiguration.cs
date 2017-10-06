/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.adminShowConfiguration(IDictionary{string, string})"
    /// />.
    /// <br />
    /// Show the current system configuration file.</summary>
    public class AdminShowConfigurationRequest : KineticaData
    {

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminShowConfigurationRequest object with
        /// default parameters.</summary>
        public AdminShowConfigurationRequest() { }

        /// <summary>Constructs an AdminShowConfigurationRequest object with
        /// the specified parameters.</summary>
        /// 
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AdminShowConfigurationRequest( IDictionary<string, string> options = null)
        {
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminShowConfigurationRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.adminShowConfiguration(IDictionary{string, string})"
    /// />.</summary>
    public class AdminShowConfigurationResponse : KineticaData
    {

        /// <summary>contents of the file  </summary>
        public string config_string { get; set; }

    } // end class AdminShowConfigurationResponse




}  // end namespace kinetica