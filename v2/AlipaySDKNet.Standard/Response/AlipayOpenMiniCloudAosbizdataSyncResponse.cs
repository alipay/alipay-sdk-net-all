using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAosbizdataSyncResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAosbizdataSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步是否成功
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
