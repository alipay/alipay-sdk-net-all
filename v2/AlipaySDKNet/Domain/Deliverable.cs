using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Deliverable Data Structure.
    /// </summary>
    [Serializable]
    public class Deliverable : AopObject
    {
        /// <summary>
        /// 验收人名称
        /// </summary>
        [XmlElement("acceptor")]
        public string Acceptor { get; set; }

        /// <summary>
        /// 交付物
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 交付标准
        /// </summary>
        [XmlElement("standard")]
        public string Standard { get; set; }
    }
}
