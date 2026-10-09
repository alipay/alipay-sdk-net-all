using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelIntlAreaSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelIntlAreaSyncModel : AopObject
    {
        /// <summary>
        /// 区域类型
        /// </summary>
        [XmlElement("area_info")]
        public AreaDTO AreaInfo { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
