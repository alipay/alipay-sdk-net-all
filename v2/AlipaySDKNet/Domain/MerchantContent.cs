using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantContent Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantContent : AopObject
    {
        /// <summary>
        /// 链接类型
        /// </summary>
        [XmlElement("link_type")]
        public string LinkType { get; set; }
    }
}
