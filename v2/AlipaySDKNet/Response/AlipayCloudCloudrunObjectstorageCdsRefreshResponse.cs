using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageCdsRefreshResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageCdsRefreshResponse : AopResponse
    {
        /// <summary>
        /// 请求 ID
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }
    }
}
