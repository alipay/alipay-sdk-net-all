using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpTrademarkSecondClassCodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpTrademarkSecondClassCodeInfo : AopObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("coding")]
        public string Coding { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("designation")]
        public string Designation { get; set; }
    }
}
