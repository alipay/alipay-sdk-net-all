using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftsettlecardDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftsettlecardDetectModel : AopObject
    {
        /// <summary>
        /// 卡户名
        /// </summary>
        [XmlElement("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 进件生成的卡编号
        /// </summary>
        [XmlElement("card_alias_no")]
        public string CardAliasNo { get; set; }

        /// <summary>
        /// 二级商户支付宝商户号，进件成功后由支付宝返回。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
