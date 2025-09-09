using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchFileDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchFileDetailQueryModel : AopObject
    {
        /// <summary>
        /// 合作方的用户唯一标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 文件唯一标识
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 从小助获取的租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
