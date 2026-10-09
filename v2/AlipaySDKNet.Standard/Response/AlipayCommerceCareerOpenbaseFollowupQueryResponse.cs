using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseFollowupQueryResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseFollowupQueryResponse : AopResponse
    {
        /// <summary>
        /// 终态分类：status=ENDED 时必填(恒有值,回告仅随终态推送)。取值 ENDED=自然完成 / TIMEOUT=超时 / CANCELLED=客户取消(预留,当前抑制不推送) / REJECTED=执行域拒收。与   status/executionNo 正交。
        /// </summary>
        [XmlElement("ended_type")]
        public string EndedType { get; set; }

        /// <summary>
        /// 平台任务号（18 位纯数字，按字符串处理，勿解析内部结构）；用于回告与计费对账。查询、取消以 outBizNo 定位。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 原样回传客户业务单号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务实际关联的跟进方案标识。
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 跟进任务的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
