/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.adminAlterConfiguration(string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Update the system config file.  Updates to the config file are only
    /// permitted when the system is stopped.</summary>
    public class AdminAlterConfigurationRequest : KineticaData
    {

        /// <summary>updated contents of the config file.  </summary>
        public string config_string { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminAlterConfigurationRequest object with
        /// default parameters.</summary>
        public AdminAlterConfigurationRequest() { }

        /// <summary>Constructs an AdminAlterConfigurationRequest object with
        /// the specified parameters.</summary>
        /// 
        /// <param name="config_string">updated contents of the config file.
        /// </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AdminAlterConfigurationRequest( string config_string,
                                               IDictionary<string, string> options = null)
        {
            this.config_string = config_string ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminAlterConfigurationRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.adminAlterConfiguration(string,IDictionary{string, string})"
    /// />.</summary>
    public class AdminAlterConfigurationResponse : KineticaData
    {
        public string status { get; set; } = "OrderedDict()";

    } // end class AdminAlterConfigurationResponse




}  // end namespace kinetica