using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OnlineGameEventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineGameEventInfo : AopObject
    {
        /// <summary>
        /// 产地描述信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用户参赛的场次组别ID，首次调用接口为空，第二次调用则由接口返回字段填充
        /// </summary>
        [XmlElement("game_event_id")]
        public string GameEventId { get; set; }

        /// <summary>
        /// 三方用户参赛的场次组别ID，由三方提供
        /// </summary>
        [XmlElement("out_game_event_no")]
        public string OutGameEventNo { get; set; }

        /// <summary>
        /// 赛事总进度,线上赛单位为M，步数赛单位为STEP
        /// </summary>
        [XmlElement("progress_unit")]
        public string ProgressUnit { get; set; }

        /// <summary>
        /// 赛事总进度，线上赛为M（米），步数赛为STEP(步数)
        /// </summary>
        [XmlElement("progress_value")]
        public long ProgressValue { get; set; }

        /// <summary>
        /// 场次状态ONLINE （上线） OFFLINE（下线）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 场次名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
