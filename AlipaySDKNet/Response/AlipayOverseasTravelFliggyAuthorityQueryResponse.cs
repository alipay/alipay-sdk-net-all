using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyAuthorityQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyAuthorityQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否有权限，true有权限，false无权限
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
