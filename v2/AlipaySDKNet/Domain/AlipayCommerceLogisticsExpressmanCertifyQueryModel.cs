using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsExpressmanCertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsExpressmanCertifyQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("expressman_open_id")]
        public string ExpressmanOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("expressman_user_id")]
        public string ExpressmanUserId { get; set; }

        /// <summary>
        /// 1、startApp（商户是支付宝内小程序，打开小程序） 2、backApp（商户是支付宝内小程序，返回小程序） 3、startThirdApp（商户是其他应用，返回其他应用）
        /// </summary>
        [XmlElement("jump_type")]
        public string JumpType { get; set; }

        /// <summary>
        /// 由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 商户回跳地址
        /// </summary>
        [XmlElement("merchant_jump_address")]
        public string MerchantJumpAddress { get; set; }
    }
}
