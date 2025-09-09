using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSmartcampusGeopointsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSmartcampusGeopointsQueryResponse : AopResponse
    {
        /// <summary>
        /// 运动轨迹压缩信息
        /// </summary>
        [XmlElement("geo_points")]
        public string GeoPoints { get; set; }
    }
}
