using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsSubOrderEmploymentDigest Data Structure.
    /// </summary>
    [Serializable]
    public class InsSubOrderEmploymentDigest : AopObject
    {
        /// <summary>
        /// 子订单关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 外部员工编号
        /// </summary>
        [XmlElement("out_employee_id")]
        public string OutEmployeeId { get; set; }

        /// <summary>
        /// 蚂蚁保保单凭证号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保费 ;单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 蚂蚁保子单单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }

        /// <summary>
        /// 子订单状态 初始态 INIT 正常处理终态 ISSUED/SURRENDERRED 失败处理终态 CLOSE 中间态  CREATED/TO_BE_PAID/PAID
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 保额 ;单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
