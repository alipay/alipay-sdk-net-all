using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarUnionmemberTaskCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarUnionmemberTaskCallbackModel : AopObject
    {
        /// <summary>
        /// 操作类型Code，支持的操作类型咨询支持接入的BD/解决方案
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 车生活定义的车企ID，车企接入时咨询对应BD
        /// </summary>
        [XmlElement("manufacturer_id")]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// 业务发生时间（如：实际任务完成时间）
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 任务类型Code，支持的任务类型咨询支持接入的BD/解决方案
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
