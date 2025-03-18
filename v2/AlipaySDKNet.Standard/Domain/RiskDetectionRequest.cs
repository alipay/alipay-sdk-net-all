using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionRequest : AopObject
    {
        /// <summary>
        /// 检测金额
        /// </summary>
        [XmlElement("detection_amount")]
        public MultiCurrencyMoneyOpenApi DetectionAmount { get; set; }

        /// <summary>
        /// VPC智付使用时可填写vpcSmartPay
        /// </summary>
        [XmlElement("detection_source")]
        public string DetectionSource { get; set; }

        /// <summary>
        /// 填写参与风险检测的业务单据号
        /// </summary>
        [XmlElement("document_no")]
        public string DocumentNo { get; set; }

        /// <summary>
        /// 本次参与检测的单据类型
        /// </summary>
        [XmlElement("document_type")]
        public string DocumentType { get; set; }

        /// <summary>
        /// 扩展业务要素【是指单据本身的业务属性，用于匹配风险检测规则，区别于riskDetectionParameters】
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("risk_detection_map")]
        public List<RiskDetectionMap> ExtInfo { get; set; }

        /// <summary>
        /// VPC智付使用时填写bizid
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 风险检测参数【用于风险咨询的业务要素，比如invoiceNo,invoiceCode】
        /// </summary>
        [XmlArray("risk_detection_parameters")]
        [XmlArrayItem("risk_detection_map")]
        public List<RiskDetectionMap> RiskDetectionParameters { get; set; }

        /// <summary>
        /// 二级业务环节枚举 BILL_INVOICE_CORRELATION-VPC老账票关联 PAYMENT_RECEIPT_CREATE-VPC老付款单创建 INVOICE_RELATE-VPC新账票关联 PAYMENT_APPLY-VPC新付款单创建
        /// </summary>
        [XmlElement("second_level_business_link")]
        public string SecondLevelBusinessLink { get; set; }

        /// <summary>
        /// VPC智付填写vendorId
        /// </summary>
        [XmlElement("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }
    }
}
