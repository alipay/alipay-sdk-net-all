using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandQualityAssetproduceDetectResponse.
    /// </summary>
    public class AntMerchantExpandQualityAssetproduceDetectResponse : AopResponse
    {
        /// <summary>
        /// 品检错误码信息
        /// </summary>
        [XmlElement("detect_error_code")]
        public string DetectErrorCode { get; set; }

        /// <summary>
        /// 品检错误描述
        /// </summary>
        [XmlElement("detect_error_desc")]
        public string DetectErrorDesc { get; set; }

        /// <summary>
        /// 品检错误详情，里边有具体的每一行错误信息，包括错误字段，错误值
        /// </summary>
        [XmlElement("detect_error_info")]
        public ContentErrorInfo DetectErrorInfo { get; set; }

        /// <summary>
        /// 品检成功标识
        /// </summary>
        [XmlElement("detect_success")]
        public bool DetectSuccess { get; set; }
    }
}
