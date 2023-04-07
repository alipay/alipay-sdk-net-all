using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenCloudAppPermissionQueryResponse.
    /// </summary>
    public class AlipayOpenCloudAppPermissionQueryResponse : AopResponse
    {
        /// <summary>
        /// 拥有权限的接口列表
        /// </summary>
        [XmlArray("permission_api_list")]
        [XmlArrayItem("string")]
        public List<string> PermissionApiList { get; set; }
    }
}
