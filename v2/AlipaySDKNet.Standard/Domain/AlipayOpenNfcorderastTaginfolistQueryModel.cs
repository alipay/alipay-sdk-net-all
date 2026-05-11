using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenNfcorderastTaginfolistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenNfcorderastTaginfolistQueryModel : AopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 不传则默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 不传默认为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
