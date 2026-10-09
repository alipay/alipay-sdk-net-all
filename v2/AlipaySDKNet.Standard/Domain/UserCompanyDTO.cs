using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserCompanyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserCompanyDTO : AopObject
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 工单权限
        /// </summary>
        [XmlElement("work_order_permission")]
        public bool WorkOrderPermission { get; set; }
    }
}
