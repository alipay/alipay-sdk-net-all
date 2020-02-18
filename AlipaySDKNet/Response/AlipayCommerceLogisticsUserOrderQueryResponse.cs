using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsUserOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsUserOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 格式 : json , 目前 json 的 key 有 biz_unique_no
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }
    }
}
