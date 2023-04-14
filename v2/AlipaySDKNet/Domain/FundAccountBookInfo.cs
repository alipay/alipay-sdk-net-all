using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundAccountBookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FundAccountBookInfo : AopObject
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

        /// <summary>
        /// 记账本类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
