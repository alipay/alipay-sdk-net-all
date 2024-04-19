using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceFeeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceFeeInfo : AopObject
    {
        /// <summary>
        /// 服务费金额 单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 服务费单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 服务费单据类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 收费时间
        /// </summary>
        [XmlElement("execute_dt")]
        public string ExecuteDt { get; set; }

        /// <summary>
        /// 服务费扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public ServiceFeeExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 当bill_type=PAYMENT时，返回支付宝交易号；  当bill_type=REFUND时，返回支付宝退款流水号；
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 关联服务费支付单据号
        /// </summary>
        [XmlElement("related_bill_no")]
        public string RelatedBillNo { get; set; }

        /// <summary>
        /// 收款方OpenId
        /// </summary>
        [XmlElement("trans_in_open_id")]
        public string TransInOpenId { get; set; }

        /// <summary>
        /// 收款方支付宝UID
        /// </summary>
        [XmlElement("trans_in_user_id")]
        public string TransInUserId { get; set; }

        /// <summary>
        /// 收款方支付宝名称
        /// </summary>
        [XmlElement("trans_in_user_name")]
        public string TransInUserName { get; set; }

        /// <summary>
        /// 付款方OpenId
        /// </summary>
        [XmlElement("trans_out_open_id")]
        public string TransOutOpenId { get; set; }

        /// <summary>
        /// 付款方支付宝UID
        /// </summary>
        [XmlElement("trans_out_user_id")]
        public string TransOutUserId { get; set; }

        /// <summary>
        /// 付款方支付宝名称
        /// </summary>
        [XmlElement("trans_out_user_name")]
        public string TransOutUserName { get; set; }
    }
}
