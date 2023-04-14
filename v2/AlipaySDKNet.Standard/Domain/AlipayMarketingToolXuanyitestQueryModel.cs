using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolXuanyitestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolXuanyitestQueryModel : AopObject
    {
        /// <summary>
        /// 测试测试测试
        /// </summary>
        [XmlElement("ssss")]
        public string Ssss { get; set; }

        /// <summary>
        /// sss
        /// </summary>
        [XmlElement("xxx")]
        public string Xxx { get; set; }
    }
}
