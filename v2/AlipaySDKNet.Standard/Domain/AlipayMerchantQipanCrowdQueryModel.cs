using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝人群code 注意：external_crowd_code 和 crowd_code不能同时为空
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 商户外部用户人群code 用于标识商家人群，需保证同一商户下crowd_code唯一 注意：external_crowd_code 和 crowd_code不能同时为空
        /// </summary>
        [XmlElement("external_crowd_code")]
        public string ExternalCrowdCode { get; set; }
    }
}
