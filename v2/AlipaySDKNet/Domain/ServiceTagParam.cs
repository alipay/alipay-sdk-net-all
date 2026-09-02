using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTagParam Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTagParam : AopObject
    {
        /// <summary>
        /// 服务标签编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签元数据说明信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 服务标签的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务标签的子类
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }
    }
}
