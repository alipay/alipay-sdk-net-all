using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskOrderRecordSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskOrderRecordSyncModel : AopObject
    {
        /// <summary>
        /// 首页助理openapi请求入参
        /// </summary>
        [XmlElement("home_api_request")]
        public HomeApiRequest HomeApiRequest { get; set; }
    }
}
