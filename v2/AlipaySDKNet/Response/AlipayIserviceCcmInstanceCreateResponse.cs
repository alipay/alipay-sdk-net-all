using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmInstanceCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmInstanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 租户实例（数据权限）ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
