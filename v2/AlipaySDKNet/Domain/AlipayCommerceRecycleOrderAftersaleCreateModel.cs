using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderAftersaleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderAftersaleCreateModel : AopObject
    {
        /// <summary>
        /// 发起售后原因
        /// </summary>
        [XmlElement("after_sale_reason")]
        public string AfterSaleReason { get; set; }

        /// <summary>
        /// 售后类型
        /// </summary>
        [XmlElement("after_sale_type")]
        public string AfterSaleType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 回收订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 发起售后的子单列表
        /// </summary>
        [XmlArray("sub_order_after_sale_create_list")]
        [XmlArrayItem("recycle_sub_order_after_sale_create_v_o")]
        public List<RecycleSubOrderAfterSaleCreateVO> SubOrderAfterSaleCreateList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
