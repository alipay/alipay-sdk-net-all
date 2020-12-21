using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmInstanceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmInstanceCreateModel : AopObject
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 租户实例（数据权限）描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 租户实例（数据权限）名称，如果名称已经存在，将创建失败
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
