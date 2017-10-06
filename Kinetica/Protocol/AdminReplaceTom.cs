/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */




namespace kinetica
{

    /// <summary>@private
    /// A set of parameters for <see cref="Kinetica.adminReplaceTom(long,long)"
    /// />.
    /// <br />
    /// </summary>
    public class AdminReplaceTomRequest : KineticaData
    {

        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public long old_rank_tom { get; set; }

        /// <summary>@private
        /// </summary>
        public long new_rank_tom { get; set; }


        /// <summary>@private
        /// Constructs an AdminReplaceTomRequest object with default
        /// parameters.</summary>
        public AdminReplaceTomRequest() { }

        /// <summary>@private
        /// Constructs an AdminReplaceTomRequest object with the specified
        /// parameters.</summary>
        /// 
        /// <param name="old_rank_tom"></param>
        /// <param name="new_rank_tom"></param>
        /// 
        public AdminReplaceTomRequest( long old_rank_tom,
                                       long new_rank_tom)
        {
            this.old_rank_tom = old_rank_tom;
            this.new_rank_tom = new_rank_tom;
        } // end constructor


    /// <summary>@private
    /// </summary>
    } // end class AdminReplaceTomRequest



    /// <summary>@private
    /// A set of results returned by <see
    /// cref="Kinetica.adminReplaceTom(long,long)" />.</summary>
    public class AdminReplaceTomResponse : KineticaData
    {

        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public long old_rank_tom { get; set; }

        /// <summary>@private
        /// </summary>
        public long new_rank_tom { get; set; }


    /// <summary>@private
    /// </summary>
    } // end class AdminReplaceTomResponse




}  // end namespace kinetica
