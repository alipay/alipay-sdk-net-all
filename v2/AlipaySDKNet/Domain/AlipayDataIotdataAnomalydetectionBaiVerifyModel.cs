using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataIotdataAnomalydetectionBaiVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataAnomalydetectionBaiVerifyModel : AopObject
    {
        /// <summary>
        /// base64编码的视频帧数据，表示当前帧
        /// </summary>
        [XmlElement("current_frame")]
        public string CurrentFrame { get; set; }

        /// <summary>
        /// Unix时间戳，单位秒，current_frame的产生时间
        /// </summary>
        [XmlElement("current_time")]
        public long CurrentTime { get; set; }

        /// <summary>
        /// base64编码视频帧数据
        /// </summary>
        [XmlElement("previous_frame")]
        public string PreviousFrame { get; set; }

        /// <summary>
        /// Unix时间戳，单位秒，previous_frame的产生时间
        /// </summary>
        [XmlElement("previous_time")]
        public long PreviousTime { get; set; }

        /// <summary>
        /// 调用方保证唯一，表示监测异常事件的id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
