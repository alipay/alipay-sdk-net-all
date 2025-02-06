using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingEntityQualificationVerifyResponse.
    /// </summary>
    public class AlipayMarketingEntityQualificationVerifyResponse : AopResponse
    {
        /// <summary>
        /// 本次操作的流水id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 返回第三方错误信息
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
