using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentApplyQueryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentApplyQueryOrder : AopObject
    {
        /// <summary>
        /// 发票受理单的外部单号out_bill_no
        /// </summary>
        [XmlArray("apply_relative_id_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyRelativeIdList { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 汇总单号billNo|预付单号（outBizNo）
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 查询可票的账单 ,为空时sql查询不关注可票金额条件
        /// </summary>
        [XmlElement("inv_accept_status")]
        public string InvAcceptStatus { get; set; }

        /// <summary>
        /// 发票
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 商户名称pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [XmlArray("settle_status_list")]
        [XmlArrayItem("string")]
        public List<string> SettleStatusList { get; set; }

        /// <summary>
        /// 结算单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
