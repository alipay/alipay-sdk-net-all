using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightdiverGoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightdiverGoodsSyncModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        [XmlElement("order_name")]
        public string OrderName { get; set; }

        /// <summary>
        /// 订单号(唯一键)
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单时间，标准格式为:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 合作方小程序链接
        /// </summary>
        [XmlElement("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 支付宝用户的司机userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
