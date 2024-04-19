using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcBindModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcBindModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否更新成功；true成功/false失败
        /// </summary>
        [XmlElement("update_result")]
        public bool UpdateResult { get; set; }
    }
}
