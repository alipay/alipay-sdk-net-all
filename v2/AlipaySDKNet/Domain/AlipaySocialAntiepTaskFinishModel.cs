using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepTaskFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepTaskFinishModel : AopObject
    {
        /// <summary>
        /// 发放可变奖励的条件
        /// </summary>
        [XmlElement("condition_for_variable_award")]
        public long ConditionForVariableAward { get; set; }

        /// <summary>
        /// 完成时的业务定制信息
        /// </summary>
        [XmlElement("finish_business_info")]
        public string FinishBusinessInfo { get; set; }

        /// <summary>
        /// 外部请求方式
        /// </summary>
        [XmlElement("request_mode")]
        public string RequestMode { get; set; }

        /// <summary>
        /// 外部请求类型
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 任务token
        /// </summary>
        [XmlElement("task_token")]
        public string TaskToken { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [XmlElement("zone_id")]
        public string ZoneId { get; set; }
    }
}
