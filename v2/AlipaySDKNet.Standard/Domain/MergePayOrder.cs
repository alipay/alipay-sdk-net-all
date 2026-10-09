using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MergePayOrder Data Structure.
    /// </summary>
    [Serializable]
    public class MergePayOrder : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 资金单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_display_account")]
        public string PayeeDisplayAccount { get; set; }

        /// <summary>
        /// 收款方姓名
        /// </summary>
        [XmlElement("payee_display_name")]
        public string PayeeDisplayName { get; set; }

        /// <summary>
        /// 收款方机构号
        /// </summary>
        [XmlElement("payee_inst_id")]
        public string PayeeInstId { get; set; }

        /// <summary>
        /// 收款方机构名
        /// </summary>
        [XmlElement("payee_inst_name")]
        public string PayeeInstName { get; set; }

        /// <summary>
        /// 收款方头像
        /// </summary>
        [XmlElement("payee_portrait_id")]
        public string PayeePortraitId { get; set; }

        /// <summary>
        /// 收款方类型
        /// </summary>
        [XmlElement("payee_type")]
        public string PayeeType { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 资金单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 到账时间
        /// </summary>
        [XmlElement("withdraw_delay")]
        public string WithdrawDelay { get; set; }
    }
}
