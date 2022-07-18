using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignTaskSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignTaskSendModel : AopObject
    {
        /// <summary>
        /// 参数名：外部业务单号 应用场景：与支付宝的一个业务单号进行绑定，后续可以通过该业务单号进行查询 如何获取：接口使用方自行生成，为了数据查询的准确性，应该确保该单号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务中心id
        /// </summary>
        [XmlElement("task_cen_id")]
        public string TaskCenId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
