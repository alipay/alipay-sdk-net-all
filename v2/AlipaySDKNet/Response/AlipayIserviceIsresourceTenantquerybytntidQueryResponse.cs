using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceTenantquerybytntidQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceTenantquerybytntidQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的租户信息
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiTenantInfo BizData { get; set; }
    }
}
