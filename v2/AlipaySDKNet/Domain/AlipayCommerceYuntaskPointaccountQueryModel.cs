using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskPointaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskPointaccountQueryModel : AopObject
    {
        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
