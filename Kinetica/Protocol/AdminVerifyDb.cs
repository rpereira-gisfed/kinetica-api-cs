/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for /admin/verifydb.
    /// <br />
    /// Verify database is in a consistent state.  When inconsistencies or
    /// errors are found, the verified_ok flag in the response is set to false
    /// and the list of errors found is provided in the error_list.</summary>
    public class AdminVerifyDbRequest : KineticaData
    {

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminVerifyDbRequest object with default
        /// parameters.</summary>
        public AdminVerifyDbRequest() { }

        /// <summary>Constructs an AdminVerifyDbRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AdminVerifyDbRequest( IDictionary<string, string> options = null)
        {
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminVerifyDbRequest



    /// <summary>A set of results returned by /admin/verifydb.</summary>
    public class AdminVerifyDbResponse : KineticaData
    {

        /// <summary>True if no errors were found, false otherwise.  </summary>
        public bool verified_ok { get; set; } = false;

        /// <summary>List of errors found while validating the database
        /// internal state.  </summary>
        public IList<string> error_list { get; set; } = new List<string>();

    } // end class AdminVerifyDbResponse




}  // end namespace kinetica
