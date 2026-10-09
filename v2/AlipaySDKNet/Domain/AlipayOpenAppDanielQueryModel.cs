using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDanielQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDanielQueryModel : AopObject
    {
        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("daniel_path")]
        public long DanielPath { get; set; }

        /// <summary>
        /// fds
        /// </summary>
        [XmlElement("daniel_query")]
        public string DanielQuery { get; set; }
    }
}
