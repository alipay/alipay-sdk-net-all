using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityIsvpayrecordModifyResponse.
    /// </summary>
    public class AlipayEbppCommunityIsvpayrecordModifyResponse : AopResponse
    {
        /// <summary>
        /// 是 核心定位键：创单时平台生成并传给服务商的统一单号，回写定位、校验、更新均以其为准
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 回写后记录当前状态（含终态幂等后返回的当前终态） 枚举 {SUCCESS, CLOSED}
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
