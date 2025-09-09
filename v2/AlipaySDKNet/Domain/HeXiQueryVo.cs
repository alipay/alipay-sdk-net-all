using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HeXiQueryVo Data Structure.
    /// </summary>
    [Serializable]
    public class HeXiQueryVo : AopObject
    {
        /// <summary>
        /// db模式
        /// </summary>
        [XmlElement("db_mode")]
        public string DbMode { get; set; }
    }
}
