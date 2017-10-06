/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.adminShowJobs(IDictionary{string, string})" />.
    /// <br />
    /// Get a list of the current jobs in GPUdb.</summary>
    public class AdminShowJobsRequest : KineticaData
    {

        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.SHOW_DETAILS">SHOW_DETAILS</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list></description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {

            /// <summary>
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="AdminShowJobsRequest.Options.TRUE">TRUE</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="AdminShowJobsRequest.Options.FALSE">FALSE</see></term>
            ///     </item>
            /// </list></summary>
            public const string SHOW_DETAILS = "show_details";
            public const string TRUE = "true";
            public const string FALSE = "false";
        } // end struct Options


        /// <summary>Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.SHOW_DETAILS">SHOW_DETAILS</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list></description>
        ///     </item>
        /// </list>
        ///   </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminShowJobsRequest object with default
        /// parameters.</summary>
        public AdminShowJobsRequest() { }

        /// <summary>Constructs an AdminShowJobsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="options">Optional parameters.
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.SHOW_DETAILS">SHOW_DETAILS</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.TRUE">TRUE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="AdminShowJobsRequest.Options.FALSE">FALSE</see></term>
        ///     </item>
        /// </list></description>
        ///     </item>
        /// </list>
        ///   </param>
        /// 
        public AdminShowJobsRequest( IDictionary<string, string> options = null)
        {
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminShowJobsRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.adminShowJobs(IDictionary{string, string})"
    /// />.</summary>
    public class AdminShowJobsResponse : KineticaData
    {
        public IList<int> job_id { get; set; } = new List<int>();
        public IList<string> status { get; set; } = new List<string>();
        public IList<string> endpoint_name { get; set; } = new List<string>();
        public IList<long> time_received { get; set; } = new List<long>();
        public IList<string> auth_id { get; set; } = new List<string>();
        public IList<string> user_data { get; set; } = new List<string>();

    } // end class AdminShowJobsResponse




}  // end namespace kinetica