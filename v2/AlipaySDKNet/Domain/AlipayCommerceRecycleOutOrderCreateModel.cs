using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOutOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOutOrderCreateModel : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address_info")]
        public RecycleAddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 回收评估信息
        /// </summary>
        [XmlElement("assess_info")]
        public RecycleOutAssessInfo AssessInfo { get; set; }

        /// <summary>
        /// 流量来源
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记订单的来源方
        /// </summary>
        [XmlElement("from_source")]
        public string FromSource { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单渠道，不填写默认ONLINE 线上渠道
        /// </summary>
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
