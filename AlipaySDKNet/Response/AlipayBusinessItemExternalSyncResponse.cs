using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessItemExternalSyncResponse.
    /// </summary>
    public class AlipayBusinessItemExternalSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 入参中的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
