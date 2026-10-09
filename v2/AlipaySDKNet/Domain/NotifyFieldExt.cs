using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyFieldExt Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyFieldExt : AopObject
    {
        /// <summary>
        /// 是否可接受
        /// </summary>
        [XmlElement("accessable")]
        public bool Accessable { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 字段
        /// </summary>
        [XmlElement("field")]
        public string Field { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
