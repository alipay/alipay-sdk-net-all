using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderAftersaleCreateResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderAftersaleCreateResponse : AopResponse
    {
        /// <summary>
        /// 售后单号
        /// </summary>
        [XmlElement("after_sale_id")]
        public string AfterSaleId { get; set; }

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
        /// 子单售后信息列表
        /// </summary>
        [XmlArray("sub_order_after_sale_info_list")]
        [XmlArrayItem("recycle_sub_order_after_sale_info_v_o")]
        public List<RecycleSubOrderAfterSaleInfoVO> SubOrderAfterSaleInfoList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
