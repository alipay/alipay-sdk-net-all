using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceStopResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferenceStopResponse : AopResponse
    {
        /// <summary>
        /// 视频时长（单位秒）
        /// </summary>
        [XmlElement("video_consult_time")]
        public long VideoConsultTime { get; set; }
    }
}
