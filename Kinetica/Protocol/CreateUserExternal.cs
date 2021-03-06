/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.createUserExternal(string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Creates a new external user (a user whose credentials are managed by an
    /// external LDAP).</summary>
    public class CreateUserExternalRequest : KineticaData
    {

        /// <summary>Name of the user to be created. Must exactly match the
        /// user's name in the external LDAP, prefixed with a @. Must not be
        /// the same name as an existing user.  </summary>
        public string name { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a CreateUserExternalRequest object with default
        /// parameters.</summary>
        public CreateUserExternalRequest() { }

        /// <summary>Constructs a CreateUserExternalRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="name">Name of the user to be created. Must exactly
        /// match the user's name in the external LDAP, prefixed with a @. Must
        /// not be the same name as an existing user.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public CreateUserExternalRequest( string name,
                                          IDictionary<string, string> options = null)
        {
            this.name = name ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class CreateUserExternalRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.createUserExternal(string,IDictionary{string, string})"
    /// />.</summary>
    public class CreateUserExternalResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="CreateUserExternalRequest.name"
        /// />.  </summary>
        public string name { get; set; }

    } // end class CreateUserExternalResponse




}  // end namespace kinetica
