using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstanceVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceVO : AopObject
    {
        /// <summary>
        /// 实例创建时间，时间戳
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
