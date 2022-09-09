using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseUnsignModel : AopObject
    {
        /// <summary>
        /// 共同账户id和企业id二选一必填
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 签约协议号，account_id不为空则该字段必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
