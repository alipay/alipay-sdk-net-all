using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployByappversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 发布信息
        /// </summary>
        [XmlArray("deploys")]
        [XmlArrayItem("mini_app_deploy_response")]
        public List<MiniAppDeployResponse> Deploys { get; set; }
    }
}
