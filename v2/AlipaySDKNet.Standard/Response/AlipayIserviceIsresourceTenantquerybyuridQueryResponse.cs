using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceTenantquerybyuridQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceTenantquerybyuridQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关的租户信息
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_tenant_info")]
        public List<OpenApiTenantInfo> BizData { get; set; }
    }
}
