using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRoleGetModel : AopObject
    {
        /// <summary>
        /// 部门id，不传默认用租户ID
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
