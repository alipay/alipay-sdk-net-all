using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupmsgQueryModel : AopObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }
    }
}
