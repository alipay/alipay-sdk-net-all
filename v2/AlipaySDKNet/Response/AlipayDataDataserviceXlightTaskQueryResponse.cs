using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceXlightTaskQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceXlightTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 任务完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 任务完成状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 单位为人民币分，task_reward_amount=2代表2分钱。这个字段与广告检索接口返回的taskRewardAmount字段值一致
        /// </summary>
        [XmlElement("task_reward_amount")]
        public string TaskRewardAmount { get; set; }
    }
}
