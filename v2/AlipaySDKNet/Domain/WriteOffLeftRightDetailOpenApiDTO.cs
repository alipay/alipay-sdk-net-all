using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WriteOffLeftRightDetailOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WriteOffLeftRightDetailOpenApiDTO : AopObject
    {
        /// <summary>
        /// 机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 申请核销方PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 左手方核销金额
        /// </summary>
        [XmlElement("left_apply_write_off_amt")]
        public MultiCurrencyMoneyOpenApi LeftApplyWriteOffAmt { get; set; }

        /// <summary>
        /// 左手方传入单据号
        /// </summary>
        [XmlElement("left_bill_no")]
        public string LeftBillNo { get; set; }

        /// <summary>
        /// 左手方单据类型 ["DELAYED_SETTLE_ORDER","REAL_SETTLE_ORDER","ADVANCE_SETTLE_ORDER"]
        /// </summary>
        [XmlElement("left_write_off_bill_type")]
        public string LeftWriteOffBillType { get; set; }

        /// <summary>
        /// 右手方申请核销金额
        /// </summary>
        [XmlElement("right_apply_write_off_amt")]
        public MultiCurrencyMoneyOpenApi RightApplyWriteOffAmt { get; set; }

        /// <summary>
        /// 右手方单据号
        /// </summary>
        [XmlElement("right_bill_no")]
        public string RightBillNo { get; set; }

        /// <summary>
        /// 右手方单据类型 COLLECT_RECEIPT
        /// </summary>
        [XmlElement("right_write_off_bill_type")]
        public string RightWriteOffBillType { get; set; }
    }
}
