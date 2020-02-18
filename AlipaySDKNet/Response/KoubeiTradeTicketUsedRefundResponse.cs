using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiTradeTicketUsedRefundResponse.
    /// </summary>
    public class KoubeiTradeTicketUsedRefundResponse : AopResponse
    {
        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
