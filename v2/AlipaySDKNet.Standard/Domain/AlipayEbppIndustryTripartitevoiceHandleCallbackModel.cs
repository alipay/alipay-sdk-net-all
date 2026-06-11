using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryTripartitevoiceHandleCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryTripartitevoiceHandleCallbackModel : AopObject
    {
        /// <summary>
        /// 机构处理完成时间，yyyy-MM-dd HH:mm:ss；不能早于该客诉的gmtCreate
        /// </summary>
        [XmlElement("handle_time")]
        public string HandleTime { get; set; }

        /// <summary>
        /// 处理说明；当 status=OTHER 时必填；其他情况可选；最大 500 字符
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 处理结论
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 客诉记录 ID（来自接口 A 返回）
        /// </summary>
        [XmlElement("voice_id")]
        public string VoiceId { get; set; }
    }
}
