using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DamagesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DamagesInfo : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 违约金的金额，单位：分
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }

        /// <summary>
        /// 违约金发起方式
        /// </summary>
        [XmlElement("damages_issue_type")]
        public string DamagesIssueType { get; set; }

        /// <summary>
        /// 违约金比例，单位：%，例如返回值是30，代表30%
        /// </summary>
        [XmlElement("damages_rate")]
        public string DamagesRate { get; set; }

        /// <summary>
        /// 违约金的状态
        /// </summary>
        [XmlElement("damages_status")]
        public string DamagesStatus { get; set; }

        /// <summary>
        /// 违约金的类型
        /// </summary>
        [XmlElement("damages_type")]
        public string DamagesType { get; set; }

        /// <summary>
        /// 违约金订单id，damages_status=init时没有值，需要用户确认
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }
    }
}
