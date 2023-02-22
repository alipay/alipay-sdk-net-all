using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockQuitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockQuitModel : AopObject
    {
        /// <summary>
        /// userid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// userid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xixihha")]
        public string Xixihha { get; set; }
    }
}
