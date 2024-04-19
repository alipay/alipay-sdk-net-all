using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundAccountBookInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundAccountBookInfoDTO : AopObject
    {
        /// <summary>
        /// 账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 账户可用余额，单位元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 外卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 账本类型，主：MAIN，子账本：SUB
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
