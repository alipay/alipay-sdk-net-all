using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignDataprepareCreateResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignDataprepareCreateResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 跳转类型
        /// </summary>
        [XmlElement("jump_type")]
        public string JumpType { get; set; }

        /// <summary>
        /// 跳转至小程序的URL
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
