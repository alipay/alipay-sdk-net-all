using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单链接
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 订单物流数量
        /// </summary>
        [XmlElement("logistic_count")]
        public long LogisticCount { get; set; }

        /// <summary>
        /// 物流信息列表
        /// </summary>
        [XmlArray("logistics")]
        [XmlArrayItem("logistic_info")]
        public List<LogisticInfo> Logistics { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 普通订单：NORMAL 预售订单：PRE_SALE
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单商品种类
        /// </summary>
        [XmlElement("spu_count")]
        public long SpuCount { get; set; }

        /// <summary>
        /// 订单商品信息
        /// </summary>
        [XmlArray("spus")]
        [XmlArrayItem("spu_info")]
        public List<SpuInfo> Spus { get; set; }

        /// <summary>
        /// 订单状态，目前支持以下几种状态 下单未支付 WAIT_PAY 支付未发货 PAIED 已发货 IN_DELIVERY 售后中 IN_AFTER_SALE 订单完成 FINISHED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单子状态
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 下单用户id(外部系统ID)
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
