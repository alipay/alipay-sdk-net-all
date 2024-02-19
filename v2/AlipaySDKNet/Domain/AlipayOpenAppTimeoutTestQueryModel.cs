using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTimeoutTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTimeoutTestQueryModel : AopObject
    {
        /// <summary>
        /// 秒
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
