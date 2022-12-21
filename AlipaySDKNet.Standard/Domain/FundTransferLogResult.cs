using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundTransferLogResult Data Structure.
    /// </summary>
    [Serializable]
    public class FundTransferLogResult : AopObject
    {
        /// <summary>
        /// 转账金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 资金操作备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 源账户
        /// </summary>
        [XmlElement("source_account")]
        public string SourceAccount { get; set; }

        /// <summary>
        /// 转账日志记录状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 目标账户
        /// </summary>
        [XmlElement("target_account")]
        public string TargetAccount { get; set; }

        /// <summary>
        /// 单据创建时间
        /// </summary>
        [XmlElement("trans_create_time")]
        public string TransCreateTime { get; set; }

        /// <summary>
        /// 转账日期
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }

        /// <summary>
        /// 操作类型 TRANSFER：转账 WITHDRAW：提现
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
