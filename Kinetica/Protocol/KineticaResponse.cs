/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */




namespace kinetica
{

    /// <summary>A set of parameters for the raw wrapper for Kinetica
    /// responses.</summary>
    public class KineticaResponse : KineticaData
    {
        public string status { get; set; }
        public string message { get; set; }
        public string data_type { get; set; }
        public byte[] data { get; set; }
        public string data_str { get; set; }

    } // end class KineticaResponse




}  // end namespace kinetica
