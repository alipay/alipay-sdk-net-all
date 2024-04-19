using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundAccountApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundAccountApiDTO : AopObject
    {
        /// <summary>
        /// 资金专户ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 资金专户可用余额，最多两位小数（元）
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 资金专户应用场景是否开启
        /// </summary>
        [XmlElement("enable_status")]
        public string EnableStatus { get; set; }

        /// <summary>
        /// 资金专户应用场景码
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
