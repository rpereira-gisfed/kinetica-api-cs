/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.deleteUser(string,IDictionary{string, string})" />.
    /// <br />
    /// Deletes an existing user.</summary>
    public class DeleteUserRequest : KineticaData
    {

        /// <summary>Name of the user to be deleted. Must be an existing user.
        /// </summary>
        public string name { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a DeleteUserRequest object with default
        /// parameters.</summary>
        public DeleteUserRequest() { }

        /// <summary>Constructs a DeleteUserRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="name">Name of the user to be deleted. Must be an
        /// existing user.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public DeleteUserRequest( string name,
                                  IDictionary<string, string> options)
        {
            this.name = name ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class DeleteUserRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.deleteUser(string,IDictionary{string, string})"
    /// />.</summary>
    public class DeleteUserResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="DeleteUserRequest.name" />.
        /// </summary>
        public string name { get; set; }

    } // end class DeleteUserResponse




}  // end namespace kinetica
