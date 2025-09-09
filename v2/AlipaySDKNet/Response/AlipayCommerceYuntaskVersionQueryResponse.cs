using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskVersionQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskVersionQueryResponse : AopResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_code")]
        public string VersionCode { get; set; }
    }
}
