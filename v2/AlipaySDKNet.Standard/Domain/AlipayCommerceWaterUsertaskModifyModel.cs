using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterUsertaskModifyModel : AopObject
    {
        /// <summary>
        /// 修改状态类型： NORMAL-正常还桶；
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 桶异常必填，描述桶异常的原因
        /// </summary>
        [XmlElement("goods_exception_desc")]
        public string GoodsExceptionDesc { get; set; }

        /// <summary>
        /// 除去正常还桶类型外必填，需要用户支付的金额（单位元），应小于签约芝麻时的最大金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 商家创建活动生成的活动id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户参与任务时，生成的id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }
    }
}
