using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybyuidQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUrquerybyuidQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务响应
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiUserResourceInfo BizData { get; set; }
    }
}
