using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardPurchaseSignResponse.
    /// </summary>
    public class AlipayFundMbpcardPurchaseSignResponse : AopResponse
    {
        /// <summary>
        /// 加密算法名称
        /// </summary>
        [XmlElement("encrypt_algorithm_name")]
        public string EncryptAlgorithmName { get; set; }

        /// <summary>
        /// 购卡人专属打款账号名称，非线上购卡场景使用
        /// </summary>
        [XmlElement("fund_account_name")]
        public string FundAccountName { get; set; }

        /// <summary>
        /// 购卡人专属打款账号，非线上购卡场景使用
        /// </summary>
        [XmlElement("fund_account_no")]
        public string FundAccountNo { get; set; }

        /// <summary>
        /// 预付卡购卡人编号
        /// </summary>
        [XmlElement("purchase_id")]
        public string PurchaseId { get; set; }

        /// <summary>
        /// 公钥别名
        /// </summary>
        [XmlElement("rsa_public_key_alias")]
        public string RsaPublicKeyAlias { get; set; }
    }
}
