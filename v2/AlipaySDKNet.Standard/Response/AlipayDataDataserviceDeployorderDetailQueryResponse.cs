using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderDetailQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 部署单列表
        /// </summary>
        [XmlArray("deploy_order_list")]
        [XmlArrayItem("dx_deploy_order_info")]
        public List<DxDeployOrderInfo> DeployOrderList { get; set; }
    }
}
