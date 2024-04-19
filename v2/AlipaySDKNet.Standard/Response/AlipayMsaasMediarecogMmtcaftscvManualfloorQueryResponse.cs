using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvManualfloorQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvManualfloorQueryResponse : AopResponse
    {
        /// <summary>
        /// 人工层视频信息
        /// </summary>
        [XmlArray("floor_videos")]
        [XmlArrayItem("floor_video")]
        public List<FloorVideo> FloorVideos { get; set; }

        /// <summary>
        /// 视频状态 0:正常视频  -1:异常视频
        /// </summary>
        [XmlElement("video_code")]
        public string VideoCode { get; set; }
    }
}
