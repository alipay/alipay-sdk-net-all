using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscribeInitiateApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeInitiateApiResponse : AopObject
    {
        /// <summary>
        /// 订阅付费凭证
        /// </summary>
        [XmlElement("subscribe_token")]
        public string SubscribeToken { get; set; }

        /// <summary>
        /// 订阅付费地址
        /// </summary>
        [XmlElement("subscribe_url")]
        public string SubscribeUrl { get; set; }

        /// <summary>
        /// 订阅套餐明细
        /// </summary>
        [XmlElement("subscription_packages")]
        public SubscriptionPackageDetailDTO SubscriptionPackages { get; set; }
    }
}
