using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrePayApplyCancelOrder Data Structure.
    /// </summary>
    [Serializable]
    public class PrePayApplyCancelOrder : AopObject
    {
        /// <summary>
        /// 预付取消金额 cent为分 1元=100分
        /// </summary>
        [XmlElement("cancel_amount")]
        public MultiCurrencyMoneyOpenApi CancelAmount { get; set; }

        /// <summary>
        /// 调用方保证唯一的幂等id
        /// </summary>
        [XmlElement("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 上游下发结算参与者信息
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

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
        /// 预付申请对应外部单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
