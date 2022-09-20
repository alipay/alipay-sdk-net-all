using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectFileUploadResponse.
    /// </summary>
    public class AlipayMerchantIndirectFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 结果值
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 描述性向
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }

        /// <summary>
        /// 状态标识(SU=成功/FA=失败)
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
