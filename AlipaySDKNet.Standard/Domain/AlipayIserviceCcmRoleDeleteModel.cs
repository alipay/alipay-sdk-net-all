using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRoleDeleteModel : AopObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID），如果不传入，使用租户id
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
