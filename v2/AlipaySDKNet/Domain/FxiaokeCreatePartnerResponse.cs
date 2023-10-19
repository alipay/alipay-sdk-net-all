using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreatePartnerResponse Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreatePartnerResponse : AopObject
    {
        /// <summary>
        /// bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 蚂蚁关联方代码
        /// </summary>
        [XmlElement("intertrade_ou_code")]
        public string IntertradeOuCode { get; set; }

        /// <summary>
        /// 关联交易类型
        /// </summary>
        [XmlElement("intertrade_type")]
        public string IntertradeType { get; set; }
    }
}
