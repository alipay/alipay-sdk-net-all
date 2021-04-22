using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoRebateBalanceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRebateBalanceSendModel : AopObject
    {
        /// <summary>
        /// 用户订单明细
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("rebate_good")]
        public List<RebateGood> Items { get; set; }

        /// <summary>
        /// 商户侧的用户订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户支付宝唯一标识，2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
