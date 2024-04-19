using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierAuthQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户名下企业授权信息列表
        /// </summary>
        [XmlArray("ep_auth_content")]
        [XmlArrayItem("ep_auth_content")]
        public List<EpAuthContent> EpAuthContent { get; set; }
    }
}
