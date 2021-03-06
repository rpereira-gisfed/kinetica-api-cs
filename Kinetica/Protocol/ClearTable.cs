/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.clearTable(string,string,IDictionary{string, string})"
    /// />.
    /// <br />
    /// Clears (drops) one or all tables in the database cluster. The operation
    /// is synchronous meaning that the table will be cleared before the
    /// function returns. The response payload returns the status of the
    /// operation along with the name of the table that was cleared.</summary>
    public class ClearTableRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.NO_ERROR_IF_NOT_EXISTS">NO_ERROR_IF_NOT_EXISTS</see>:</term>
        ///         <description>If <i>true</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist no
        /// error is returned. If <i>false</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist
        /// then an error is returned.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>If <i>true</i> and if the table specified in <see
            /// cref="table_name" /> does not exist no error is returned. If
            /// <i>false</i> and if the table specified in <see
            /// cref="table_name" /> does not exist then an error is returned.
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="ClearTableRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="ClearTableRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="ClearTableRequest.Options.FALSE">FALSE</see>.</summary>
            public const string NO_ERROR_IF_NOT_EXISTS = "no_error_if_not_exists";
            public const string TRUE = "true";
            public const string FALSE = "false";
        } // end struct Options


        /// <summary>Name of the table to be cleared. Must be an existing
        /// table. Empty string clears all available tables, though this
        /// behavior is be prevented by default via gpudb.conf parameter
        /// 'disable_clear_all'.  </summary>
        public string table_name { get; set; } = "";

        /// <summary>No longer used. User can pass an empty string.  </summary>
        public string authorization { get; set; } = "";

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.NO_ERROR_IF_NOT_EXISTS">NO_ERROR_IF_NOT_EXISTS</see>:</term>
        ///         <description>If <i>true</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist no
        /// error is returned. If <i>false</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist
        /// then an error is returned.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a ClearTableRequest object with default
        /// parameters.</summary>
        public ClearTableRequest() { }

        /// <summary>Constructs a ClearTableRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="table_name">Name of the table to be cleared. Must be
        /// an existing table. Empty string clears all available tables, though
        /// this behavior is be prevented by default via gpudb.conf parameter
        /// 'disable_clear_all'.  </param>
        /// <param name="authorization">No longer used. User can pass an empty
        /// string.  </param>
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.NO_ERROR_IF_NOT_EXISTS">NO_ERROR_IF_NOT_EXISTS</see>:</term>
        ///         <description>If <i>true</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist no
        /// error is returned. If <i>false</i> and if the table specified in
        /// <paramref cref="ClearTableRequest.table_name" /> does not exist
        /// then an error is returned.
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="ClearTableRequest.Options.FALSE">FALSE</see>.</description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public ClearTableRequest( string table_name = null,
                                  string authorization = null,
                                  IDictionary<string, string> options = null)
        {
            this.table_name = table_name ?? "";
            this.authorization = authorization ?? "";
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class ClearTableRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.clearTable(string,string,IDictionary{string, string})"
    /// />.</summary>
    public class ClearTableResponse : KineticaData
    {

        /// <summary>Value of <paramref cref="ClearTableRequest.table_name" />
        /// for a given table, or 'ALL CLEARED' in case of clearing all tables.
        /// </summary>
        public string table_name { get; set; }

    } // end class ClearTableResponse




}  // end namespace kinetica
