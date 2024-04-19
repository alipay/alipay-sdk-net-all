using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportsrecordDetailQueryResponse.
    /// </summary>
    public class AlipayUserSportsrecordDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 轨迹点信息（已经压缩编码，使用GooglePolyline工具解码）
        /// </summary>
        [XmlElement("geo_points")]
        public string GeoPoints { get; set; }
    }
}
