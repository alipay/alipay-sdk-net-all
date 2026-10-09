using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileSdkUsedDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileSdkUsedDTO : AopObject
    {
        /// <summary>
        /// 权限id
        /// </summary>
        [XmlElement("permission_id")]
        public string PermissionId { get; set; }

        /// <summary>
        /// 权限中文名
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }

        /// <summary>
        /// SDK调用次数
        /// </summary>
        [XmlElement("sdk_used_num")]
        public long SdkUsedNum { get; set; }
    }
}
