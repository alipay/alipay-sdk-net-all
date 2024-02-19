using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpNrlxTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpNrlxTypeList : AopObject
    {
        /// <summary>
        /// 前置审批项类型说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 前置审批项中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 前置审批项类型编码
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
