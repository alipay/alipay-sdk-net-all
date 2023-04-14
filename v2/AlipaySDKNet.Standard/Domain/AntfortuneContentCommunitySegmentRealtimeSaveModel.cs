using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneContentCommunitySegmentRealtimeSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunitySegmentRealtimeSaveModel : AopObject
    {
        /// <summary>
        /// 直播id
        /// </summary>
        [XmlElement("live_id")]
        public string LiveId { get; set; }

        /// <summary>
        /// 请求的时间戳
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 分段内容 {     "liveId":"",     "segments":[         {             "id":"1",             "title":"看点标题",             "content":"看点内容xxx",             "effectScore":0.9,             "startTime":"123",             "endTime":"345",             "startTimestamp":"1648721395052",             "endTimestamp":"1648721495052"         }     ] }
        /// </summary>
        [XmlElement("segment_info")]
        public string SegmentInfo { get; set; }
    }
}
