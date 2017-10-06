/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>A set of parameters for <see
    /// cref="Kinetica.adminShowShards(IDictionary{string, string})" />.
    /// <br />
    /// Show the mapping of shards to the corresponding rank and tom.  The
    /// response message contains list of 16384 (total number of shards in the
    /// system) Rank and TOM numbers corresponding to each shard.</summary>
    public class AdminShowShardsRequest : KineticaData
    {

        /// <summary>Optional parameters.  </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs an AdminShowShardsRequest object with default
        /// parameters.</summary>
        public AdminShowShardsRequest() { }

        /// <summary>Constructs an AdminShowShardsRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="options">Optional parameters.  </param>
        /// 
        public AdminShowShardsRequest( IDictionary<string, string> options = null)
        {
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class AdminShowShardsRequest



    /// <summary>A set of results returned by <see
    /// cref="Kinetica.adminShowShards(IDictionary{string, string})"
    /// />.</summary>
    public class AdminShowShardsResponse : KineticaData
    {

        /// <summary>Current shard array version number.  </summary>
        public long version { get; set; }

        /// <summary>Array of ranks indexed by the shard number.  </summary>
        public IList<int> rank { get; set; } = new List<int>();

        /// <summary>Array of toms to which the corresponding shard belongs.
        /// </summary>
        public IList<int> tom { get; set; } = new List<int>();

    } // end class AdminShowShardsResponse




}  // end namespace kinetica
