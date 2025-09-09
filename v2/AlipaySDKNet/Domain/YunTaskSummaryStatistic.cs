using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YunTaskSummaryStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class YunTaskSummaryStatistic : AopObject
    {
        /// <summary>
        /// 激活门店总量
        /// </summary>
        [XmlElement("active_shop_cnt")]
        public long ActiveShopCnt { get; set; }

        /// <summary>
        /// 店员绑定总量
        /// </summary>
        [XmlElement("bind_hunter_cnt")]
        public long BindHunterCnt { get; set; }

        /// <summary>
        /// 任务激励总积分
        /// </summary>
        [XmlElement("task_incentive_amount")]
        public long TaskIncentiveAmount { get; set; }

        /// <summary>
        /// 任务激励总量
        /// </summary>
        [XmlElement("task_incentive_cnt")]
        public long TaskIncentiveCnt { get; set; }

        /// <summary>
        /// 任务领取总量
        /// </summary>
        [XmlElement("task_receive_cnt")]
        public long TaskReceiveCnt { get; set; }

        /// <summary>
        /// 任务发布总量
        /// </summary>
        [XmlElement("task_total_cnt")]
        public long TaskTotalCnt { get; set; }
    }
}
