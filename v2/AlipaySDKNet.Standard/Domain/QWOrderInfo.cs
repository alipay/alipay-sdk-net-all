using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QWOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QWOrderInfo : AopObject
    {
        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 千问资产类型
        /// </summary>
        [XmlElement("qianwen_mutex_asset_type")]
        public string QianwenMutexAssetType { get; set; }

        /// <summary>
        /// 千问订单目录
        /// </summary>
        [XmlElement("qianwen_order_category")]
        public string QianwenOrderCategory { get; set; }

        /// <summary>
        /// 千问订单金额
        /// </summary>
        [XmlElement("qianwen_order_pay_amount")]
        public string QianwenOrderPayAmount { get; set; }

        /// <summary>
        /// 千问订单类型
        /// </summary>
        [XmlElement("qianwen_order_type")]
        public string QianwenOrderType { get; set; }
    }
}
