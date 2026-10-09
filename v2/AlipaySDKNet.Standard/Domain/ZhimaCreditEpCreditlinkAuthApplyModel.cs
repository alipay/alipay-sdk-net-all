using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkAuthApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkAuthApplyModel : AopObject
    {
        /// <summary>
        /// 授权回跳页面地址
        /// </summary>
        [XmlElement("auth_callback_path")]
        public string AuthCallbackPath { get; set; }

        /// <summary>
        /// 被授权商户，如果为空，被授权方即为信用链接创建方
        /// </summary>
        [XmlElement("auth_merchant_id")]
        public string AuthMerchantId { get; set; }

        /// <summary>
        /// 授权通知地址
        /// </summary>
        [XmlElement("auth_notify_path")]
        public string AuthNotifyPath { get; set; }

        /// <summary>
        /// 认证类型，请联系服务提供方获取
        /// </summary>
        [XmlElement("certification_type")]
        public string CertificationType { get; set; }

        /// <summary>
        /// 已认证法人身份证号
        /// </summary>
        [XmlElement("cognizant_cert_no")]
        public string CognizantCertNo { get; set; }

        /// <summary>
        /// 已认证的法人姓名
        /// </summary>
        [XmlElement("cognizant_name")]
        public string CognizantName { get; set; }

        /// <summary>
        /// 信用链接数据类型，请联系服务提供方获取
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 信用链接类型，请联系服务提供方确认对应类型
        /// </summary>
        [XmlElement("link_type")]
        public string LinkType { get; set; }

        /// <summary>
        /// 商户需要在授权回跳时需要带回的透传字段（ 回跳auth_callback_path时）
        /// </summary>
        [XmlElement("merchant_context")]
        public string MerchantContext { get; set; }

        /// <summary>
        /// 商户信用链接ID（需要商户保证唯一性）
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 税票信息模型(在data_type为TAXRECEIPT时，该字段为必填)
        /// </summary>
        [XmlElement("tax_receipt_once_info")]
        public TaxReceiptOnceInfo TaxReceiptOnceInfo { get; set; }
    }
}
