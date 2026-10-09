using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeCreateResponse : AopResponse
    {
        /// <summary>
        /// 创意ID：广告创意ID，投放广告唯一标识，可使用该ID进行广告详情查询
        /// </summary>
        [XmlElement("ad_id")]
        public long AdId { get; set; }
    }
}
