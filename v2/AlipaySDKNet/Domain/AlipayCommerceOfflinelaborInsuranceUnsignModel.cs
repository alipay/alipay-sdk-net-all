using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOfflinelaborInsuranceUnsignModel : AopObject
    {
        /// <summary>
        /// 保险模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退保保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
