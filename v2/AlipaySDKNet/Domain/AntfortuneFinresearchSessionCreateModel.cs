using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionCreateModel : AopObject
    {
        /// <summary>
        /// 合作方内部的用户体系用户信息
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
