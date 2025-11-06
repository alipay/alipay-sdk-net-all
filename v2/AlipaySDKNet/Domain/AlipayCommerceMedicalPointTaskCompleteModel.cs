using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPointTaskCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPointTaskCompleteModel : AopObject
    {
        /// <summary>
        /// 业务时间，后续各种校验都会以业务时间为准(String类型, 格式为yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 渠道信息chInfo
        /// </summary>
        [XmlElement("kz_info")]
        public string KzInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务号，作幂等字段使用，需使用唯一业务号进行填充
        /// </summary>
        [XmlElement("out_idem_id")]
        public string OutIdemId { get; set; }

        /// <summary>
        /// 来源，TIANMAOXIAOYUAN（天猫校园）
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 任务完成时的任务ID，用于后续跟事件消息事件码做映射匹配，保证全局唯一。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
