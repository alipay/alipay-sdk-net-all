using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TreeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TreeInfo : AopObject
    {
        /// <summary>
        /// 类目树ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        [XmlElement("instance_code")]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
