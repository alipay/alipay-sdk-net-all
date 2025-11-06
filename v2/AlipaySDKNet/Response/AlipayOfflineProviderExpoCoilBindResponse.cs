using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderExpoCoilBindResponse.
    /// </summary>
    public class AlipayOfflineProviderExpoCoilBindResponse : AopResponse
    {
        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
