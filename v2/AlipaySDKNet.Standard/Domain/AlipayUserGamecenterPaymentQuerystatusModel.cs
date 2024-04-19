using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterPaymentQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterPaymentQuerystatusModel : AopObject
    {
        /// <summary>
        /// 开发者自定义订单号，在下单的时候传入的customId
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
