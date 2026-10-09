using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybybusvcdomainQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUrquerybybusvcdomainQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关用户资源信息
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiUserResourceInfo BizData { get; set; }
    }
}
