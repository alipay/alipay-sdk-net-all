using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationServiceSyncResponse.
    /// </summary>
    public class AlipayMarketingQualificationServiceSyncResponse : AopResponse
    {
        /// <summary>
        /// 本次操作的流水id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 返回服务调用数据
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
