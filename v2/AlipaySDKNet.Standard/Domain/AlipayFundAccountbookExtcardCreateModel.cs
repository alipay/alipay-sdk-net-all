using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookExtcardCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookExtcardCreateModel : AopObject
    {
        /// <summary>
        /// 记账账簿id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 支付宝协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外标卡类型
        /// </summary>
        [XmlElement("out_card_type")]
        public string OutCardType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
