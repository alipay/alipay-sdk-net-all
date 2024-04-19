using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybyclvuidsQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUserquerybyclvuidsQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关用户信息
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_user_info")]
        public List<OpenApiUserInfo> BizData { get; set; }
    }
}
