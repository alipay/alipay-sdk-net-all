using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceEnterpriseuserAuthResponse.
    /// </summary>
    public class AlipayIserviceIsresourceEnterpriseuserAuthResponse : AopResponse
    {
        /// <summary>
        /// 返回的信登token，用于跳转并写登录态
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiEnterpriseUserAuthInfo BizData { get; set; }
    }
}
