using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVPaymentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVPaymentInfoDTO : AopObject
    {
        /// <summary>
        /// 缴费金额,对应币种的最小单位
        /// </summary>
        [XmlElement("amount")]
        public IndrMoneyDTO Amount { get; set; }

        /// <summary>
        /// 账户id，长度不超过10
        /// </summary>
        [XmlElement("beneficiary_account_id")]
        public string BeneficiaryAccountId { get; set; }

        /// <summary>
        /// 收款人id，长度不超过10
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 证明材料列表
        /// </summary>
        [XmlElement("certificate_list")]
        public IndrISVImageDTO CertificateList { get; set; }

        /// <summary>
        /// 附言，不能包含特殊字符
        /// </summary>
        [XmlElement("post_script")]
        public string PostScript { get; set; }
    }
}
