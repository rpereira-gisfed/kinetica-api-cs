/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{
    /// @cond NO_DOCS
    /// <summary>A set of parameters for <see
    /// cref="Kinetica.visualizeImageContour(IList{string},string,string,string,double,double,double,double,int,int,string,IDictionary{string, string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// </summary>
    public class VisualizeImageContourRequest : KineticaData
    {

        /// <summary>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.
        /// A set of string constants for the parameter <see cref="projection"
        /// />.</summary>
        public struct Projection
        {
            public const string _3857 = "3857";
            public const string _102100 = "102100";
            public const string _900913 = "900913";
            public const string EPSG_4326 = "EPSG:4326";
            public const string PLATE_CARREE = "PLATE_CARREE";
            public const string EPSG_900913 = "EPSG:900913";
            public const string EPSG_102100 = "EPSG:102100";
            public const string EPSG_3857 = "EPSG:3857";
            public const string WEB_MERCATOR = "WEB_MERCATOR";
        } // end struct Projection


        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.LINE_SIZE">LINE_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLOR">COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see
        /// cref="style_options" />.</summary>
        public struct StyleOptions
        {
            public const string LINE_SIZE = "line_size";
            public const string COLOR = "color";
            public const string BG_COLOR = "bg_color";

            /// <summary>
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.HOT">HOT</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.HSV">HSV</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.GRAY">GRAY</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.BLUES">BLUES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.GREENS">GREENS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.GREYS">GREYS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.ORANGES">ORANGES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.PURPLES">PURPLES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.REDS">REDS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see>.</summary>
            public const string COLORMAP = "colormap";
            public const string JET = "jet";
            public const string HOT = "hot";
            public const string HSV = "hsv";
            public const string GRAY = "gray";
            public const string BLUES = "blues";
            public const string GREENS = "greens";
            public const string GREYS = "greys";
            public const string ORANGES = "oranges";
            public const string PURPLES = "purples";
            public const string REDS = "reds";
            public const string VIRIDIS = "viridis";
        } // end struct StyleOptions


        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_LEVEL">MIN_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_LEVEL">MAX_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.NUM_LEVELS">NUM_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_LEVELS">ADJUST_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SEARCH_RADIUS">SEARCH_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_SEARCH_CELLS">MAX_SEARCH_CELLS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRIDDING_METHOD">GRIDDING_METHOD</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_CURV">MIN_CURV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.KRIGING">KRIGING</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.PASS_THROUGH">PASS_THROUGH</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.FILL_RATIO">FILL_RATIO</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SMOOTHING_FACTOR">SMOOTHING_FACTOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRID_SIZE">GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID">ADJUST_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_NEIGH">ADJUST_GRID_NEIGH</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_SIZE">ADJUST_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_GRID_SIZE">MAX_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_GRID_SIZE">MIN_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.RENDER_OUTPUT_GRID">RENDER_OUTPUT_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see cref="options"
        /// />.</summary>
        public struct Options
        {
            public const string MIN_LEVEL = "min_level";
            public const string MAX_LEVEL = "max_level";
            public const string NUM_LEVELS = "num_levels";
            public const string ADJUST_LEVELS = "adjust_levels";
            public const string SEARCH_RADIUS = "search_radius";
            public const string MAX_SEARCH_CELLS = "max_search_cells";

            /// <summary>
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.Options.MIN_CURV">MIN_CURV</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.Options.KRIGING">KRIGING</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.Options.PASS_THROUGH">PASS_THROUGH</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageContourRequest.Options.FILL_RATIO">FILL_RATIO</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see>.</summary>
            public const string GRIDDING_METHOD = "gridding_method";
            public const string INV_DST_POW = "INV_DST_POW";
            public const string MIN_CURV = "MIN_CURV";
            public const string KRIGING = "KRIGING";
            public const string PASS_THROUGH = "PASS_THROUGH";
            public const string FILL_RATIO = "FILL_RATIO";
            public const string SMOOTHING_FACTOR = "smoothing_factor";
            public const string GRID_SIZE = "grid_size";
            public const string ADJUST_GRID = "adjust_grid";
            public const string ADJUST_GRID_NEIGH = "adjust_grid_neigh";
            public const string ADJUST_GRID_SIZE = "adjust_grid_size";
            public const string MAX_GRID_SIZE = "max_grid_size";
            public const string MIN_GRID_SIZE = "min_grid_size";
            public const string RENDER_OUTPUT_GRID = "render_output_grid";
        } // end struct Options

        public IList<string> table_names { get; set; } = new List<string>();
        public string x_column_name { get; set; }
        public string y_column_name { get; set; }
        public string value_column_name { get; set; }
        public double min_x { get; set; }
        public double max_x { get; set; }
        public double min_y { get; set; }
        public double max_y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        /// <summary>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.</summary>
        public string projection { get; set; } = Projection.PLATE_CARREE;

        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.LINE_SIZE">LINE_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLOR">COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        /// </list>
        /// </summary>
        public IDictionary<string, string> style_options { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_LEVEL">MIN_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_LEVEL">MAX_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.NUM_LEVELS">NUM_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_LEVELS">ADJUST_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SEARCH_RADIUS">SEARCH_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_SEARCH_CELLS">MAX_SEARCH_CELLS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRIDDING_METHOD">GRIDDING_METHOD</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_CURV">MIN_CURV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.KRIGING">KRIGING</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.PASS_THROUGH">PASS_THROUGH</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.FILL_RATIO">FILL_RATIO</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SMOOTHING_FACTOR">SMOOTHING_FACTOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRID_SIZE">GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID">ADJUST_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_NEIGH">ADJUST_GRID_NEIGH</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_SIZE">ADJUST_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_GRID_SIZE">MAX_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_GRID_SIZE">MIN_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.RENDER_OUTPUT_GRID">RENDER_OUTPUT_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>Constructs a VisualizeImageContourRequest object with
        /// default parameters.</summary>
        public VisualizeImageContourRequest() { }

        /// <summary>Constructs a VisualizeImageContourRequest object with the
        /// specified parameters.</summary>
        /// 
        /// <param name="table_names"></param>
        /// <param name="x_column_name"></param>
        /// <param name="y_column_name"></param>
        /// <param name="value_column_name"></param>
        /// <param name="min_x"></param>
        /// <param name="max_x"></param>
        /// <param name="min_y"></param>
        /// <param name="max_y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="projection">
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.</param>
        /// <param name="style_options">
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.LINE_SIZE">LINE_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLOR">COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        /// </list>
        /// </param>
        /// <param name="options">
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_LEVEL">MIN_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_LEVEL">MAX_LEVEL</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.NUM_LEVELS">NUM_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_LEVELS">ADJUST_LEVELS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SEARCH_RADIUS">SEARCH_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_SEARCH_CELLS">MAX_SEARCH_CELLS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRIDDING_METHOD">GRIDDING_METHOD</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_CURV">MIN_CURV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.KRIGING">KRIGING</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.PASS_THROUGH">PASS_THROUGH</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.FILL_RATIO">FILL_RATIO</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageContourRequest.Options.INV_DST_POW">INV_DST_POW</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.SMOOTHING_FACTOR">SMOOTHING_FACTOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.GRID_SIZE">GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID">ADJUST_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_NEIGH">ADJUST_GRID_NEIGH</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.ADJUST_GRID_SIZE">ADJUST_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MAX_GRID_SIZE">MAX_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.MIN_GRID_SIZE">MIN_GRID_SIZE</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageContourRequest.Options.RENDER_OUTPUT_GRID">RENDER_OUTPUT_GRID</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// </param>
        /// 
        public VisualizeImageContourRequest( IList<string> table_names,
                                             string x_column_name,
                                             string y_column_name,
                                             string value_column_name,
                                             double min_x,
                                             double max_x,
                                             double min_y,
                                             double max_y,
                                             int width,
                                             int height,
                                             string projection,
                                             IDictionary<string, string> style_options,
                                             IDictionary<string, string> options = null)
        {
            this.table_names = table_names ?? new List<string>();
            this.x_column_name = x_column_name ?? "";
            this.y_column_name = y_column_name ?? "";
            this.value_column_name = value_column_name ?? "";
            this.min_x = min_x;
            this.max_x = max_x;
            this.min_y = min_y;
            this.max_y = max_y;
            this.width = width;
            this.height = height;
            this.projection = projection ?? Projection.PLATE_CARREE;
            this.style_options = style_options ?? new Dictionary<string, string>();
            this.options = options ?? new Dictionary<string, string>();
        } // end constructor

    } // end class VisualizeImageContourRequest
    /// @endcond



    /// @cond NO_DOCS
    /// <summary>A set of results returned by <see
    /// cref="Kinetica.visualizeImageContour(IList{string},string,string,string,double,double,double,double,int,int,string,IDictionary{string, string},IDictionary{string, string})"
    /// />.</summary>
    public class VisualizeImageContourResponse : KineticaData
    {
        public int width { get; set; }
        public int height { get; set; }
        public long bg_color { get; set; }
        public byte[] image_data { get; set; }
        public byte[] grid_data { get; set; }
        public double fill_n0 { get; set; }
        public double fill_nn { get; set; }
        public double min_level { get; set; }
        public double max_level { get; set; }
        public long samples_used { get; set; }

    } // end class VisualizeImageContourResponse
    /// @endcond





}  // end namespace kinetica
