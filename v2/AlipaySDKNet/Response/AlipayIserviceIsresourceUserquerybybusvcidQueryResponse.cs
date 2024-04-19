using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybybusvcidQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceUserquerybybusvcidQueryResponse : AopResponse
    {
        /// <summary>
        /// 相关的用户信息
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiUserInfo BizData { get; set; }
    }
}
