using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDeloauthDetailQueryResponse.
    /// </summary>
    public class AlipayUserDeloauthDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 解除授权明细列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("del_oauth_detail")]
        public List<DelOauthDetail> Details { get; set; }

        /// <summary>
        /// 解除授权记录列表
        /// </summary>
        [XmlElement("response")]
        public DelOauthDetailResult Response { get; set; }
    }
}
