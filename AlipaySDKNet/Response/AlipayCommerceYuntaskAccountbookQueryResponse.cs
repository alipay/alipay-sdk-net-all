using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskAccountbookQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskAccountbookQueryResponse : AopResponse
    {
        /// <summary>
        /// 记账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 记账本的外卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }
    }
}
