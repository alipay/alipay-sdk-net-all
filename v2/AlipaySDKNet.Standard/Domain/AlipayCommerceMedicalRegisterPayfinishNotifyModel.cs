using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterPayfinishNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterPayfinishNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝 id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝平台给服务商分配的编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务商内部系统订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝给服务商分配的平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
