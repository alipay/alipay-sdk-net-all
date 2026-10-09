using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookNotifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookNotifyQueryModel : AopObject
    {
        /// <summary>
        /// 记账本ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传；
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码。固定为DEFAULT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码。固定为SATF_FUND_BOOK
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
