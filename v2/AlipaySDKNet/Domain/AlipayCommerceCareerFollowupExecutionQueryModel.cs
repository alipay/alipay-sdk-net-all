using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerFollowupExecutionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerFollowupExecutionQueryModel : AopObject
    {
        /// <summary>
        /// 实际外呼明细 ID。传入时仅查询该任务下的这一条通话明细；不传时返回该任务的全部已结束明细。
        /// </summary>
        [XmlElement("execution_no")]
        public string ExecutionNo { get; set; }

        /// <summary>
        /// 客户业务单号，任务定位键。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
