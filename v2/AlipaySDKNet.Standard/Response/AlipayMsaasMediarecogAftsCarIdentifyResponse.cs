using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCarIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftsCarIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 浮点数； 欺诈概率，取值范围0-1，0表示非欺诈，1表示欺诈
        /// </summary>
        [XmlElement("cheat_probability")]
        public long CheatProbability { get; set; }

        /// <summary>
        /// 欺诈类型
        /// </summary>
        [XmlElement("cheat_type")]
        public string CheatType { get; set; }

        /// <summary>
        /// 识别出的里程数
        /// </summary>
        [XmlElement("ocr_kilometres")]
        public long OcrKilometres { get; set; }

        /// <summary>
        /// 浮点数;ocr识别出的里程数和用户输入的相似度，取值范围0-1，1表示一致，0表示完全不一样。
        /// </summary>
        [XmlElement("ocr_probability")]
        public long OcrProbability { get; set; }
    }
}
