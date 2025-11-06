using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivePayAndPrepayReverseCancelOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ActivePayAndPrepayReverseCancelOpenApiOrder : AopObject
    {
        /// <summary>
        /// 撤销金额 一元=100分
        /// </summary>
        [XmlElement("cancel_amount")]
        public MultiCurrencyMoneyOpenApi CancelAmount { get; set; }

        /// <summary>
        /// 调用系统幂等键
        /// </summary>
        [XmlElement("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 付款结算单角色来源
        /// </summary>
        [XmlElement("ip_role_source")]
        public string IpRoleSource { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 对应结算待撤销的应付结算单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 上游下发结算参与者信息
        /// </summary>
        [XmlElement("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }

        /// <summary>
        /// 调用系统来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
