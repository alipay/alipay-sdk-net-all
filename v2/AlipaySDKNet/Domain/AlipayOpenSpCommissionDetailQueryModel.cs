using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpCommissionDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpCommissionDetailQueryModel : AopObject
    {
        /// <summary>
        /// 抽佣场景
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 商家 id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户登录号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }
    }
}
