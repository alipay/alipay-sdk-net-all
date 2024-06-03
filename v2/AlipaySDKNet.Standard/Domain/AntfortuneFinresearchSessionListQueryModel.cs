using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionListQueryModel : AopObject
    {
        /// <summary>
        /// 合作方用户标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 小助分配给用户的租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
