using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 端bundleId
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 端的名称
        /// </summary>
        [XmlElement("bundle_name")]
        public string BundleName { get; set; }

        /// <summary>
        /// 端ID
        /// </summary>
        [XmlElement("client_id")]
        public long ClientId { get; set; }
    }
}
