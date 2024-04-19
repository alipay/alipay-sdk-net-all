using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybyuseridQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUserquerybyuseridQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关用户信息
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiUserInfo BizData { get; set; }
    }
}
