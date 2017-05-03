/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>@private
    /// A set of parameters for /admin/getshardassignments.
    /// <br />
    /// </summary>
    public class AdminGetShardAssignmentsRequest : KineticaData
    {

        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>@private
        /// Constructs an AdminGetShardAssignmentsRequest object with default
        /// parameters.</summary>
        public AdminGetShardAssignmentsRequest() { }

        /// <summary>@private
        /// Constructs an AdminGetShardAssignmentsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="options"></param>
        /// 
        public AdminGetShardAssignmentsRequest( IDictionary<string, string> options = null)
        {
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor


    /// <summary>@private
    /// </summary>
    } // end class AdminGetShardAssignmentsRequest



    /// <summary>@private
    /// A set of results returned by /admin/getshardassignments.</summary>
    public class AdminGetShardAssignmentsResponse : KineticaData
    {

        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public long version { get; set; }

        /// <summary>@private
        /// </summary>
        public IList<int> shard_assignments_rank { get; set; } = new List<int>();

        /// <summary>@private
        /// </summary>
        public IList<int> shard_assignments_tom { get; set; } = new List<int>();


    /// <summary>@private
    /// </summary>
    } // end class AdminGetShardAssignmentsResponse




}  // end namespace kinetica
