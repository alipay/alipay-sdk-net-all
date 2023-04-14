using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceAvailableQueryResponse.
    /// </summary>
    public class AlipayCommerceEcServiceAvailableQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用的服务列表
        /// </summary>
        [XmlArray("service_base_info_list")]
        [XmlArrayItem("service_base_info")]
        public List<ServiceBaseInfo> ServiceBaseInfoList { get; set; }
    }
}
