using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExchangeRedirectVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExchangeRedirectVerifyModel : AopObject
    {
        /// <summary>
        /// 会员卡权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 用于同一请求的幂等校验
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// true 是续费 false是非续费
        /// </summary>
        [XmlElement("renew")]
        public bool Renew { get; set; }
    }
}
