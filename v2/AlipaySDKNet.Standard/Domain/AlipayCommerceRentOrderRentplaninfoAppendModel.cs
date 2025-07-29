using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderRentplaninfoAppendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderRentplaninfoAppendModel : AopObject
    {
        /// <summary>
        /// 租金分期计划
        /// </summary>
        [XmlArray("installments")]
        [XmlArrayItem("rent_installment_info")]
        public List<RentInstallmentInfo> Installments { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 租期结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
