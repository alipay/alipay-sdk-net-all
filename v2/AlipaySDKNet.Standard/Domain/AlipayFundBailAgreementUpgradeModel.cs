using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundBailAgreementUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBailAgreementUpgradeModel : AopObject
    {
        /// <summary>
        /// 待升级保证金协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 托管模式
        /// </summary>
        [XmlElement("trusteeship_mode")]
        public string TrusteeshipMode { get; set; }
    }
}
