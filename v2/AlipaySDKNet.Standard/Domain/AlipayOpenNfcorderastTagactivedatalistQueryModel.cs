using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenNfcorderastTagactivedatalistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenNfcorderastTagactivedatalistQueryModel : AopObject
    {
        /// <summary>
        /// 查询此日期的数据，格式为：yyyyMMdd
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 不传默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 不传默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
