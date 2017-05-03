/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /clear/trigger.
    /// <br />
    /// Clears or cancels the trigger identified by the specified handle. The
    /// output returns the handle of the trigger cleared as well as indicating
    /// success or failure of the trigger deactivation.</summary>
    public class ClearTriggerRequest : KineticaData
    {

        /// <summary>ID for the trigger to be deactivated.  </summary>
        public string trigger_id { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a ClearTriggerRequest object with default
        /// parameters.</summary>
        public ClearTriggerRequest() { }

        /// <summary>Constructs a ClearTriggerRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="trigger_id">ID for the trigger to be deactivated.
        /// </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public ClearTriggerRequest( string trigger_id,
                                    IDictionary<string, string> options = null)
        {
            this.trigger_id = trigger_id ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class ClearTriggerRequest



    /// <summary>A set of results returned by /clear/trigger.</summary>
    public class ClearTriggerResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="ClearTriggerRequest.trigger_id"
        /// />.  </summary>
        public string trigger_id { get; set; }

    } // end class ClearTriggerResponse




}  // end namespace kinetica
