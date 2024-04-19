using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotReceiptDetailQueryModel : AopObject
    {
        /// <summary>
        /// 调用发送电子小票接口时返回的电子小票id
        /// </summary>
        [XmlElement("receipt_id")]
        public string ReceiptId { get; set; }
    }
}
