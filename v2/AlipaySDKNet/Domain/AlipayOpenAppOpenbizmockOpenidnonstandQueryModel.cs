using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockOpenidnonstandQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenbizmockOpenidnonstandQueryModel : AopObject
    {
        /// <summary>
        /// 请求
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
