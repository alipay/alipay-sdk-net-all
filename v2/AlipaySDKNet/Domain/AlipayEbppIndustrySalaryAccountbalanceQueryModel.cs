using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountbalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryAccountbalanceQueryModel : AopObject
    {
        /// <summary>
        /// 卡号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 对接收付通加签的xml, base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
