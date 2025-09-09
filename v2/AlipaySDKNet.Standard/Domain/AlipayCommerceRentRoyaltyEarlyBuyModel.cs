using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRoyaltyEarlyBuyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRoyaltyEarlyBuyModel : AopObject
    {
        /// <summary>
        /// 表示本次操作的类型
        /// </summary>
        [XmlElement("execute_scene")]
        public string ExecuteScene { get; set; }

        /// <summary>
        /// 资方pid
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 交易组件订单id列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("string")]
        public List<string> OrderList { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
