/*
 *  This file was autogenerated by the Kinetica schema processor.
 *
 *  DO NOT EDIT DIRECTLY.
 */

using System.Collections.Generic;



namespace kinetica
{

    /// <summary>@private
    /// A set of parameters for <see
    /// cref="Kinetica.visualizeImageHeatmap(IList{string},string,string,string,double,double,double,double,int,int,string,IDictionary{string, string},IDictionary{string, string})"
    /// />.
    /// <br />
    /// </summary>
    public class VisualizeImageHeatmapRequest : KineticaData
    {

        /// <summary>@private
        /// <br />
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.
        /// A set of string constants for the parameter <see cref="projection"
        /// />.</summary>
        public struct Projection
        {

            /// <summary>@private
            /// </summary>
            public const string EPSG_4326 = "EPSG:4326";

            /// <summary>@private
            /// </summary>
            public const string PLATE_CARREE = "PLATE_CARREE";

            /// <summary>@private
            /// </summary>
            public const string _900913 = "900913";

            /// <summary>@private
            /// </summary>
            public const string EPSG_900913 = "EPSG:900913";

            /// <summary>@private
            /// </summary>
            public const string _102100 = "102100";

            /// <summary>@private
            /// </summary>
            public const string EPSG_102100 = "EPSG:102100";

            /// <summary>@private
            /// </summary>
            public const string _3857 = "3857";

            /// <summary>@private
            /// </summary>
            public const string EPSG_3857 = "EPSG:3857";

            /// <summary>@private
            /// </summary>
            public const string WEB_MERCATOR = "WEB_MERCATOR";

    /// <summary>@private
    /// </summary>
        } // end struct Projection


        /// <summary>@private
        /// <br />
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUR_RADIUS">BLUR_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_START_COLOR">GRADIENT_START_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_END_COLOR">GRADIENT_END_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// <br />
        /// A set of string constants for the parameter <see
        /// cref="style_options" />.</summary>
        public struct StyleOptions
        {

            /// <summary>@private
            /// <br />
            /// Supported values:
            /// <list type="bullet">
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.HOT">HOT</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.HSV">HSV</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRAY">GRAY</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUES">BLUES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREENS">GREENS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREYS">GREYS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.ORANGES">ORANGES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.PURPLES">PURPLES</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.REDS">REDS</see></term>
            ///     </item>
            ///     <item>
            ///         <term><see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
            ///     </item>
            /// </list>
            /// The default value is <see
            /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see>.</summary>
            public const string COLORMAP = "colormap";

            /// <summary>@private
            /// </summary>
            public const string JET = "jet";

            /// <summary>@private
            /// </summary>
            public const string HOT = "hot";

            /// <summary>@private
            /// </summary>
            public const string HSV = "hsv";

            /// <summary>@private
            /// </summary>
            public const string GRAY = "gray";

            /// <summary>@private
            /// </summary>
            public const string BLUES = "blues";

            /// <summary>@private
            /// </summary>
            public const string GREENS = "greens";

            /// <summary>@private
            /// </summary>
            public const string GREYS = "greys";

            /// <summary>@private
            /// </summary>
            public const string ORANGES = "oranges";

            /// <summary>@private
            /// </summary>
            public const string PURPLES = "purples";

            /// <summary>@private
            /// </summary>
            public const string REDS = "reds";

            /// <summary>@private
            /// </summary>
            public const string VIRIDIS = "viridis";

            /// <summary>@private
            /// </summary>
            public const string BLUR_RADIUS = "blur_radius";

            /// <summary>@private
            /// </summary>
            public const string BG_COLOR = "bg_color";

            /// <summary>@private
            /// </summary>
            public const string GRADIENT_START_COLOR = "gradient_start_color";

            /// <summary>@private
            /// </summary>
            public const string GRADIENT_END_COLOR = "gradient_end_color";

    /// <summary>@private
    /// </summary>
        } // end struct StyleOptions


        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public IList<string> table_names { get; set; } = new List<string>();

        /// <summary>@private
        /// </summary>
        public string x_column_name { get; set; }

        /// <summary>@private
        /// </summary>
        public string y_column_name { get; set; }

        /// <summary>@private
        /// </summary>
        public string value_column_name { get; set; }

        /// <summary>@private
        /// </summary>
        public double min_x { get; set; }

        /// <summary>@private
        /// </summary>
        public double max_x { get; set; }

        /// <summary>@private
        /// </summary>
        public double min_y { get; set; }

        /// <summary>@private
        /// </summary>
        public double max_y { get; set; }

        /// <summary>@private
        /// </summary>
        public int width { get; set; }

        /// <summary>@private
        /// </summary>
        public int height { get; set; }

        /// <summary>@private
        /// <br />
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.</summary>
        public string projection { get; set; } = Projection.PLATE_CARREE;

        /// <summary>@private
        /// <br />
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUR_RADIUS">BLUR_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_START_COLOR">GRADIENT_START_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_END_COLOR">GRADIENT_END_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// </summary>
        public IDictionary<string, string> style_options { get; set; } = new Dictionary<string, string>();

        /// <summary>@private
        /// </summary>
        public IDictionary<string, string> options { get; set; } = new Dictionary<string, string>();


        /// <summary>@private
        /// Constructs a VisualizeImageHeatmapRequest object with default
        /// parameters.</summary>
        public VisualizeImageHeatmapRequest() { }

        /// <summary>@private
        /// Constructs a VisualizeImageHeatmapRequest object with the specified
        /// parameters.</summary>
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
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_4326">EPSG_4326</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._900913">_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_900913">EPSG_900913</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._102100">_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_102100">EPSG_102100</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection._3857">_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.EPSG_3857">EPSG_3857</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.Projection.WEB_MERCATOR">WEB_MERCATOR</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.Projection.PLATE_CARREE">PLATE_CARREE</see>.</param>
        /// <param name="style_options">
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.COLORMAP">COLORMAP</see>:</term>
        ///         <description>
        /// Supported values:
        /// <list type="bullet">
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HOT">HOT</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.HSV">HSV</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRAY">GRAY</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUES">BLUES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREENS">GREENS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GREYS">GREYS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.ORANGES">ORANGES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.PURPLES">PURPLES</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.REDS">REDS</see></term>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.VIRIDIS">VIRIDIS</see></term>
        ///     </item>
        /// </list>
        /// The default value is <see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.JET">JET</see>.</description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BLUR_RADIUS">BLUR_RADIUS</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.BG_COLOR">BG_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_START_COLOR">GRADIENT_START_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term><see
        /// cref="VisualizeImageHeatmapRequest.StyleOptions.GRADIENT_END_COLOR">GRADIENT_END_COLOR</see>:</term>
        ///         <description></description>
        ///     </item>
        /// </list>
        /// </param>
        /// <param name="options"></param>
        /// 
        public VisualizeImageHeatmapRequest( IList<string> table_names,
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


    /// <summary>@private
    /// </summary>
    } // end class VisualizeImageHeatmapRequest



    /// <summary>@private
    /// A set of results returned by <see
    /// cref="Kinetica.visualizeImageHeatmap(IList{string},string,string,string,double,double,double,double,int,int,string,IDictionary{string, string},IDictionary{string, string})"
    /// />.</summary>
    public class VisualizeImageHeatmapResponse : KineticaData
    {

        /// <summary>@private
        /// </summary>

        /// <summary>@private
        /// </summary>
        public int width { get; set; }

        /// <summary>@private
        /// </summary>
        public int height { get; set; }

        /// <summary>@private
        /// </summary>
        public long bg_color { get; set; }

        /// <summary>@private
        /// </summary>
        public byte[] image_data { get; set; }


    /// <summary>@private
    /// </summary>
    } // end class VisualizeImageHeatmapResponse




}  // end namespace kinetica
