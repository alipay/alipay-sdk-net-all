using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvRsTiffQueryResponse.
    /// </summary>
    public class AnttechAiCvRsTiffQueryResponse : AopResponse
    {
        /// <summary>
        /// tiff瓦片图像的base64结果
        /// </summary>
        [XmlElement("tile_result")]
        public string TileResult { get; set; }
    }
}
