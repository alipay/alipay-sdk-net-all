using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBpaasServiceQueryResponse.
    /// </summary>
    public class AlipayOpenBpaasServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务列表
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("b_paa_s_service_info")]
        public List<BPaaSServiceInfo> ServiceList { get; set; }
    }
}
