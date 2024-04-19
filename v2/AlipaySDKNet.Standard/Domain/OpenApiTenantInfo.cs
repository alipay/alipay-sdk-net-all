using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiTenantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiTenantInfo : AopObject
    {
        /// <summary>
        /// 租户状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("tenant_desc")]
        public string TenantDesc { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [XmlElement("tenant_name")]
        public string TenantName { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
