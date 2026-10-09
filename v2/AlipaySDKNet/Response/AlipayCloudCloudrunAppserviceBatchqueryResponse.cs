using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunAppserviceBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunAppserviceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务实例列表
        /// </summary>
        [XmlArray("server_list")]
        [XmlArrayItem("openapi_server_d_t_o")]
        public List<OpenapiServerDTO> ServerList { get; set; }
    }
}
