using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAlipaypointSendResponse.
    /// </summary>
    public class AlipayUserAlipaypointSendResponse : AopResponse
    {
        /// <summary>
        /// 发放记录号。
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 对账中心关联订单，一般场景无需关注
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
