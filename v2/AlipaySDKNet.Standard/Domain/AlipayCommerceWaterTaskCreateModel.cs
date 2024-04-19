using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterTaskCreateModel : AopObject
    {
        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [XmlElement("creator_open_id")]
        public string CreatorOpenId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlElement("prize_content")]
        public PrizeContent PrizeContent { get; set; }

        /// <summary>
        /// 二级商户appid
        /// </summary>
        [XmlElement("second_merchant_appid")]
        public string SecondMerchantAppid { get; set; }

        /// <summary>
        /// smid，二级商户进件id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 这里的任务条件是一个map，本期仅支持月的维护
        /// </summary>
        [XmlElement("task_condition")]
        public string TaskCondition { get; set; }

        /// <summary>
        /// 任务合约周期单位是月、多少个月就传对应的个数
        /// </summary>
        [XmlElement("task_contract_period")]
        public string TaskContractPeriod { get; set; }

        /// <summary>
        /// 任务有效期-结束
        /// </summary>
        [XmlElement("task_end")]
        public string TaskEnd { get; set; }

        /// <summary>
        /// 任务条件类型
        /// </summary>
        [XmlElement("task_free")]
        public string TaskFree { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务有效期开始
        /// </summary>
        [XmlElement("task_start")]
        public string TaskStart { get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [XmlElement("task_title")]
        public string TaskTitle { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
