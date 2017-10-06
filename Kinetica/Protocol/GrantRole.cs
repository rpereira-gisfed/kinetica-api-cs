/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.grantRole(string,string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Grants membership in a role to a user or role.</summary>
    public class GrantRoleRequest : KineticaData
    {

        /// <summary>Name of the role in which membership will be granted. Must
        /// be an existing role.  </summary>
        public string role { get; set; }

        /// <summary>Name of the user or role that will be granted membership
        /// in <paramref cref="GrantRoleRequest.role" />. Must be an existing
        /// user or role.  </summary>
        public string member { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a GrantRoleRequest object with default
        /// parameters.</summary>
        public GrantRoleRequest() { }

        /// <summary>Constructs a GrantRoleRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="role">Name of the role in which membership will be
        /// granted. Must be an existing role.  </param>
        /// <param name="member">Name of the user or role that will be granted
        /// membership in <paramref cref="GrantRoleRequest.role" />. Must be an
        /// existing user or role.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public GrantRoleRequest( string role,
                                 string member,
                                 IDictionary<string, string> options)
        {
            this.role = role ?? "";
            this.member = member ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class GrantRoleRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.grantRole(string,string,IDictionary{string, string})"
    /// />.</summary>
    public class GrantRoleResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="GrantRoleRequest.role" />.
        /// </summary>
        public string role { get; set; }

        /// <summary>Value of <paramref cref="GrantRoleRequest.member" />.
        /// </summary>
        public string member { get; set; }

    } // end class GrantRoleResponse




}  // end namespace kinetica
