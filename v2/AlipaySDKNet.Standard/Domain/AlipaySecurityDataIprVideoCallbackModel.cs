using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataIprVideoCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataIprVideoCallbackModel : AopObject
    {
        /// <summary>
        /// 标识外部数据来源渠道，不同渠道对接前请先与接口人确认，每个渠道唯一。错误使用会导致数据保存失败，对接前请务必确认。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 任务ID，调用阜博系统创建任务返回的task_id数据，缺少此数据参数校验会不通过。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 需要同步的剧集列表信息
        /// </summary>
        [XmlArray("video_list")]
        [XmlArrayItem("video_data")]
        public List<VideoData> VideoList { get; set; }

        /// <summary>
        /// 作品连载状态包含：processing(更新中)/completed(已完结)
        /// </summary>
        [XmlElement("video_status")]
        public string VideoStatus { get; set; }
    }
}
