using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTerminalPowerbankorderInitializeResponse.
    /// </summary>
    public class AlipayCommerceOperationTerminalPowerbankorderInitializeResponse : AopResponse
    {
        /// <summary>
        /// 同步订单记录初始化后返回的唯一Id。
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
