using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyStoreModifyResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyStoreModifyResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回调处理是否成功，true标示处理成功，false标示处理失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
