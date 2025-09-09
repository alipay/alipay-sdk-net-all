using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAddressCreateResponse.
    /// </summary>
    public class AntMerchantExpandAddressCreateResponse : AopResponse
    {
        /// <summary>
        /// 代表本次操作的工单号，用于后续监听消息时匹配单号使用
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
