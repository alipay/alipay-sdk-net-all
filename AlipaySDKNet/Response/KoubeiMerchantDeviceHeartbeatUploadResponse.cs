using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDeviceHeartbeatUploadResponse.
    /// </summary>
    public class KoubeiMerchantDeviceHeartbeatUploadResponse : AopResponse
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
        /// 接口调用是否重试的标识
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 接口调用是否成功的标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
