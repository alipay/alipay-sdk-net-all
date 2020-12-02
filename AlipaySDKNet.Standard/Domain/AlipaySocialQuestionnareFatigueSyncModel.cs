using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareFatigueSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialQuestionnareFatigueSyncModel : AopObject
    {
        /// <summary>
        /// 异步问卷投递时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 问券Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// 1 表示是离线投放后同步 2 表示用户答完问卷同步
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID,已异步投递问卷的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
