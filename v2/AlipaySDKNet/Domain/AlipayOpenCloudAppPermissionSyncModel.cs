using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudAppPermissionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudAppPermissionSyncModel : AopObject
    {
        /// <summary>
        /// 云id
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 调用应用id
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 接口权限列表
        /// </summary>
        [XmlArray("permission_api_list")]
        [XmlArrayItem("string")]
        public List<string> PermissionApiList { get; set; }
    }
}
