using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryInvoiceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInvoiceDetail : AopObject
    {
        /// <summary>
        /// 账单金额，单位：元
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [XmlElement("biz_env_name")]
        public string BizEnvName { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        [XmlElement("biz_mth")]
        public string BizMth { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 折扣金额，单位：元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 计费码
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [XmlElement("fee_item_name")]
        public string FeeItemName { get; set; }

        /// <summary>
        /// 未付金额，单位：元
        /// </summary>
        [XmlElement("nonpayment_amount")]
        public string NonpaymentAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 原始账单金额，单位：元
        /// </summary>
        [XmlElement("origin_bill_amount")]
        public string OriginBillAmount { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 实付金额，单位：元
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [XmlElement("spec_instance_id")]
        public string SpecInstanceId { get; set; }

        /// <summary>
        /// 钱包来源id
        /// </summary>
        [XmlElement("walle_source_id")]
        public string WalleSourceId { get; set; }

        /// <summary>
        /// 钱包来源
        /// </summary>
        [XmlElement("wallet_source")]
        public string WalletSource { get; set; }
    }
}
