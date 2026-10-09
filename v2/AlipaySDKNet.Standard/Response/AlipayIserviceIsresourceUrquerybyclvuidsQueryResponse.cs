using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybyclvuidsQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUrquerybyclvuidsQueryResponse : AopResponse
    {
        /// <summary>
        /// 小二资源
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_user_resource_info")]
        public List<OpenApiUserResourceInfo> BizData { get; set; }
    }
}
