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
        /// isvCode
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 服务商内部系统订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// platformCode
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
