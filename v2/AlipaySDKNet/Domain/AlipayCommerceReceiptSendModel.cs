using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceReceiptSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceReceiptSendModel : AopObject
    {
        /// <summary>
        /// 订单信息,最大限制10条
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("receipt_order_d_t_o")]
        public List<ReceiptOrderDTO> OrderList { get; set; }

        /// <summary>
        /// 请求id，基于该字段做幂等校验，冲突返回错误ORDER_DUPLICATE
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
