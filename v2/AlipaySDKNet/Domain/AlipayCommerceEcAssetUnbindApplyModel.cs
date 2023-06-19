using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAssetUnbindApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAssetUnbindApplyModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务号，与授信申请时的设置的外部业务号保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
