using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSdarttoolMessageQueryModel : AopObject
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("message_no")]
        public string MessageNo { get; set; }
    }
}
