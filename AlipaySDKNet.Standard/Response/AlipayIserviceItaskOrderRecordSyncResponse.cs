using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskOrderRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskOrderRecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("home_api_response")]
        public HomeApiResponse HomeApiResponse { get; set; }
    }
}
