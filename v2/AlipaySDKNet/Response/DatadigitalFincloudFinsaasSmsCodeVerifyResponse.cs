using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasSmsCodeVerifyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasSmsCodeVerifyResponse : AopResponse
    {
        /// <summary>
        /// 发送结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
