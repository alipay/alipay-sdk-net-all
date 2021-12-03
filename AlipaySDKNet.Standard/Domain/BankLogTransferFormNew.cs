using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankLogTransferFormNew Data Structure.
    /// </summary>
    [Serializable]
    public class BankLogTransferFormNew : AopObject
    {
        /// <summary>
        /// 充值金额
        /// </summary>
        [XmlElement("charge_amount")]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// 充值币种
        /// </summary>
        [XmlElement("chargeccy")]
        public string Chargeccy { get; set; }

        /// <summary>
        /// 跨币种标示 ture，flase
        /// </summary>
        [XmlElement("crossccy_flag")]
        public string CrossccyFlag { get; set; }

        /// <summary>
        /// 请求参数：可空，跨币种预收充值：充值汇率
        /// </summary>
        [XmlElement("exchange")]
        public string Exchange { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// Z79
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 转入预收户客户的ipRoleId(target为预收户的时候必填,其他情况选填)
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 是否是收款单充值
        /// </summary>
        [XmlElement("is_recharge_receipt")]
        public string IsRechargeReceipt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 转入目标     TO_CHECK("01", "待查资金户"),      PRE_CHARGE("02", "预收户"),      TITLE("03", "其他科目"),      REFUND("04", "退回"),      COMM_VCHR("05", "通用登账"),      COLLECT_RECEIPT("06", "收款单"),
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }
    }
}
