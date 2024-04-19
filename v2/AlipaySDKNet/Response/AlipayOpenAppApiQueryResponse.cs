using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppApiQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiQueryResponse : AopResponse
    {
        /// <summary>
        /// 应用可申请的接口出参敏感字段列表
        /// </summary>
        [XmlArray("apis")]
        [XmlArrayItem("auth_api_d_t_o")]
        public List<AuthApiDTO> Apis { get; set; }
    }
}
