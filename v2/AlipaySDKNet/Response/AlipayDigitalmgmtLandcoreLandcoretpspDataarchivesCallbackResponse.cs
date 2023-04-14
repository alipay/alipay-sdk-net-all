using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtLandcoreLandcoretpspDataarchivesCallbackResponse.
    /// </summary>
    public class AlipayDigitalmgmtLandcoreLandcoretpspDataarchivesCallbackResponse : AopResponse
    {
        /// <summary>
        /// 数据包唯一ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 检测结果描述
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
