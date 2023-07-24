using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserTaskRightsSimpleDto Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskRightsSimpleDto : AopObject
    {
        /// <summary>
        /// 权益奖励个数
        /// </summary>
        [XmlElement("award_count")]
        public long AwardCount { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户任务权益领取的北京时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_receive")]
        public string GmtReceive { get; set; }

        /// <summary>
        /// 外部用户任务权益业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户任务权益能领取最晚的北京时间，格式：yyyy-MM-dd HH:mm:ss，不存在就没有最晚时间限制
        /// </summary>
        [XmlElement("receive_deadline")]
        public string ReceiveDeadline { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        [XmlElement("rights_id")]
        public string RightsId { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("rights_name")]
        public string RightsName { get; set; }

        /// <summary>
        /// NONE-无实际权益，ISV-服务商权益， WUFU_TASK-五福卡权益
        /// </summary>
        [XmlElement("rights_type")]
        public string RightsType { get; set; }

        /// <summary>
        /// 用户任务权益状态，UNRECEIVED-未领取，RECEIVED-已领取
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户任务权益ID
        /// </summary>
        [XmlElement("user_task_rights_id")]
        public string UserTaskRightsId { get; set; }
    }
}
