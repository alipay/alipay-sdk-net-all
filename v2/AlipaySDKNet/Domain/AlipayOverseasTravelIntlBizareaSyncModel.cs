using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelIntlBizareaSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelIntlBizareaSyncModel : AopObject
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlElement("biz_area_info")]
        public BizAreaDTO BizAreaInfo { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
