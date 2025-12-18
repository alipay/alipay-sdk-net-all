using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayQueryUserSignInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayQueryUserSignInfoResponse : AopObject
    {
        /// <summary>
        /// 申请人id
        /// </summary>
        [XmlElement("applicant_id")]
        public string ApplicantId { get; set; }

        /// <summary>
        /// 完成
        /// </summary>
        [XmlElement("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 剩余提取额度，单位：元
        /// </summary>
        [XmlElement("balance_amount")]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户提取金额，单位：元
        /// </summary>
        [XmlElement("draw_amount")]
        public string DrawAmount { get; set; }

        /// <summary>
        /// 提取利息，单位：元
        /// </summary>
        [XmlElement("draw_interest")]
        public string DrawInterest { get; set; }

        /// <summary>
        /// 默认响应zf
        /// </summary>
        [XmlElement("draw_item")]
        public string DrawItem { get; set; }

        /// <summary>
        /// 提取事项明细id
        /// </summary>
        [XmlElement("draw_item_detail_id")]
        public string DrawItemDetailId { get; set; }

        /// <summary>
        /// 10-是
        /// </summary>
        [XmlElement("is_coextract")]
        public string IsCoextract { get; set; }

        /// <summary>
        /// 事项创建时间，格式yyyyMMddHHmmss
        /// </summary>
        [XmlElement("item_creation_time")]
        public string ItemCreationTime { get; set; }

        /// <summary>
        /// 事项id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        [XmlElement("item_state")]
        public string ItemState { get; set; }

        /// <summary>
        /// 操作平台
        /// </summary>
        [XmlElement("operating_deck")]
        public string OperatingDeck { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operating_time")]
        public string OperatingTime { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 发票租房，保租房，公租房，多子女租房提，默认是空，不为空时代表本月租金剩余额度，单位：元
        /// </summary>
        [XmlElement("rent_monthly_balance")]
        public string RentMonthlyBalance { get; set; }

        /// <summary>
        /// 30-租住商品住房；
        /// </summary>
        [XmlElement("rental_type")]
        public string RentalType { get; set; }

        /// <summary>
        /// 是-10
        /// </summary>
        [XmlElement("trans_provincial_label")]
        public string TransProvincialLabel { get; set; }

        /// <summary>
        /// 签约用户在公积金侧的备案编号
        /// </summary>
        [XmlElement("user_record_no")]
        public string UserRecordNo { get; set; }
    }
}
