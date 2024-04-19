using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessItemTicketSyncResponse.
    /// </summary>
    public class AlipayBusinessItemTicketSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝门票商品id
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 支付宝门票商品状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
