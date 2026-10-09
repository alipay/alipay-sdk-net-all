using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardBinActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardBinActivityInfo : AopObject
    {
        /// <summary>
        /// 银行标准缩写 eg： 工行ICBC，农行ABC
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 规则的卡bin
        /// </summary>
        [XmlElement("card_bin")]
        public string CardBin { get; set; }

        /// <summary>
        /// 卡bin规则对应的外部code
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 规则对应的商家pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
