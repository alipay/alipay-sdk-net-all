using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizTagExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class BizTagExtParams : AopObject
    {
        /// <summary>
        /// 商户的动态跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
