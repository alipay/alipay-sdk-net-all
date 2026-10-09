using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoTrafficCodeVerifyResponse.
    /// </summary>
    public class AlipayEcoTrafficCodeVerifyResponse : AopResponse
    {
        /// <summary>
        /// 解码是否成功
        /// </summary>
        [XmlElement("decode_success")]
        public string DecodeSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 解析模式：QRCODE/RECORD
        /// </summary>
        [XmlElement("parse_mode")]
        public string ParseMode { get; set; }

        /// <summary>
        /// 描述本次执行结果详情
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 验码是否成功
        /// </summary>
        [XmlElement("verify_success")]
        public string VerifySuccess { get; set; }
    }
}
