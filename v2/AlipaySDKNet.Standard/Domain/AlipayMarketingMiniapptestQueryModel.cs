using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingMiniapptestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingMiniapptestQueryModel : AopObject
    {
        /// <summary>
        /// 通用tab描述
        /// </summary>
        [XmlElement("xxxx")]
        public string Xxxx { get; set; }
    }
}
