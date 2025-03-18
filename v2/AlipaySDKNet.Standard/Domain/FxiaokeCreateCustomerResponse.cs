using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateCustomerResponse Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateCustomerResponse : AopObject
    {
        /// <summary>
        /// 客户bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 蚂蚁关联方代码文本值
        /// </summary>
        [XmlElement("intertrade_ou_code")]
        public string IntertradeOuCode { get; set; }

        /// <summary>
        /// 关联交易类型文本值
        /// </summary>
        [XmlElement("intertrade_type")]
        public string IntertradeType { get; set; }
    }
}
