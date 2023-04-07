using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenCloudAppPermissionSyncResponse.
    /// </summary>
    public class AlipayOpenCloudAppPermissionSyncResponse : AopResponse
    {
        /// <summary>
        /// 接口权限列表
        /// </summary>
        [XmlArray("permission_api_list")]
        [XmlArrayItem("string")]
        public List<string> PermissionApiList { get; set; }
    }
}
