using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchFileListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchFileListQueryModel : AopObject
    {
        /// <summary>
        /// 合作方用户标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// tenant_id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
