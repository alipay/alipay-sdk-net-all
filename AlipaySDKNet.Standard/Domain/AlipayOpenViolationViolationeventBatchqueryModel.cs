using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenViolationViolationeventBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenViolationViolationeventBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询开始时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间30天前。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 违规工单状态枚举： PUNISH_DONE：处罚生效中 PUNISH_APPEAL_REVOKED：处罚已撤销 PUNISH_INVALID_REVOKED：处罚已到期 WAITING_RECTIFY：待整改  RECTIFY_AUDITOR_PROCESSING：整改审核中 RECTIFY_REJECTED：整改不通过 RECTIFY_PASSED：整改通过 RECTIFY_TIMEOUT ：整改已超时
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
