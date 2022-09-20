using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockMsgSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenbizmockMsgSyncModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_openid")]
        public string AOpenid { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("b_openid")]
        public string BOpenid { get; set; }
    }
}
