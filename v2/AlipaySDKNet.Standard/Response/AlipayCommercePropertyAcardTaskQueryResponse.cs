using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyAcardTaskQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyAcardTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 制卡任务详情
        /// </summary>
        [XmlElement("card_apply_task_detail")]
        public CardApplyTaskInfo CardApplyTaskDetail { get; set; }

        /// <summary>
        /// 外部唯一业务编号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 制卡任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 制卡任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
