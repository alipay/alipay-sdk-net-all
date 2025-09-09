using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanAccountQueryDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LoanAccountQueryDetailDTO : AopObject
    {
        /// <summary>
        /// 本次操作金额,单位:元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 入金时间
        /// </summary>
        [XmlElement("inst_in_time")]
        public string InstInTime { get; set; }

        /// <summary>
        /// 流水单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 归属人主体ID
        /// </summary>
        [XmlElement("principal_user_id")]
        public string PrincipalUserId { get; set; }

        /// <summary>
        /// 剩余可操作金额;单位:元
        /// </summary>
        [XmlElement("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
