using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtLandcoreLandcoretpspDataarchivesCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtLandcoreLandcoretpspDataarchivesCallbackModel : AopObject
    {
        /// <summary>
        /// 用于标识业务系统中归档数据唯一ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 状态对应的说明
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 用于标识反馈结果状态，状态码信息描述见接口说明
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
