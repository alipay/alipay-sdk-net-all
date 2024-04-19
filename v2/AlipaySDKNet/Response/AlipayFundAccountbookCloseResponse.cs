using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookCloseResponse.
    /// </summary>
    public class AlipayFundAccountbookCloseResponse : AopResponse
    {
        /// <summary>
        /// 注销的资金记账本id，注销成功时返回
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }
    }
}
