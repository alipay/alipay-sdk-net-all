using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeUnsignResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingEmployeehomeUnsignResponse : AopResponse
    {
        /// <summary>
        /// 解除的服务id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 解除服务后的状态： INVALID  失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
