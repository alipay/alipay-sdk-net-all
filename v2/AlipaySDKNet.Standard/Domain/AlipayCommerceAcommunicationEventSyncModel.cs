using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationEventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationEventSyncModel : AopObject
    {
        /// <summary>
        /// 手机号,卡号,户号等
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 一级业务标识
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 产品类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 渠道标识
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 事件类型， 例如创单 create 办理失败 fail
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 支付宝用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 合作伙伴名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品sku, json格式
        /// </summary>
        [XmlElement("sku_info")]
        public string SkuInfo { get; set; }

        /// <summary>
        /// 二级业务标识
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
