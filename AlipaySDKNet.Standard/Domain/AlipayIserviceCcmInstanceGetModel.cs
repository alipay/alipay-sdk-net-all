using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmInstanceGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmInstanceGetModel : AopObject
    {
        /// <summary>
        /// 外部id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
