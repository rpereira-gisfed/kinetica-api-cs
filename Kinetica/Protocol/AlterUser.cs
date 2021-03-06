/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.alterUser(string,string,string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Alters a user.</summary>
    public class AlterUserRequest : KineticaData
    {

        /// <summary>Modification operation to be applied to the user.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AlterUserRequest.Action.SET_PASSWORD">SET_PASSWORD</see>:</term>
        ///         <description>Sets the password of the user. The user must
        /// be an internal user.</description>
        ///     </item>
        /// </list>
        /// A set of string constants for the parameter <see cref="action"
        /// />.</summary>
        public struct Action
        {

            /// <summary>Sets the password of the user. The user must be an
            /// internal user.</summary>
            public const string SET_PASSWORD = "set_password";
        } // end struct Action


        /// <summary>Name of the user to be altered. Must be an existing user.
        /// </summary>
        public string name { get; set; }

        /// <summary>Modification operation to be applied to the user.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AlterUserRequest.Action.SET_PASSWORD">SET_PASSWORD</see>:</term>
        ///         <description>Sets the password of the user. The user must
        /// be an internal user.</description>
        ///     </item>
        /// </list>  </summary>
        public string action { get; set; }

        /// <summary>The value of the modification, depending on <paramref
        /// cref="AlterUserRequest.action" />.  </summary>
        public string _value { get; set; }

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AlterUserRequest object with default
        /// parameters.</summary>
        public AlterUserRequest() { }

        /// <summary>Constructs an AlterUserRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="name">Name of the user to be altered. Must be an
        /// existing user.  </param>
        /// <param name="action">Modification operation to be applied to the
        /// user.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AlterUserRequest.Action.SET_PASSWORD">SET_PASSWORD</see>:</term>
        ///         <description>Sets the password of the user. The user must
        /// be an internal user.</description>
        ///     </item>
        /// </list>  </param>
        /// <param name="_value">The value of the modification, depending on
        /// <paramref cref="AlterUserRequest.action" />.  </param>
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AlterUserRequest( string name,
                                 string action,
                                 string _value,
                                 IDictionary<string, string> options = null)
        {
            this.name = name ?? "";
            this.action = action ?? "";
            this._value = _value ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AlterUserRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.alterUser(string,string,string,IDictionary{string, string})"
    /// />.</summary>
    public class AlterUserResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="AlterUserRequest.name" />.
        /// </summary>
        public string name { get; set; }

    } // end class AlterUserResponse




}  // end namespace kinetica
