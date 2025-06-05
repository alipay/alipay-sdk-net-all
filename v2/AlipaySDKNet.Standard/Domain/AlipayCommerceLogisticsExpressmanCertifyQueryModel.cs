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
        /// 由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }
    }
}
