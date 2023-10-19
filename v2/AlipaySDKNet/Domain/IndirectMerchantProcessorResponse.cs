using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectMerchantProcessorResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectMerchantProcessorResponse : AopObject
    {
        /// <summary>
        /// 商家审核状态
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 商家经营状态
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 行业模版code
        /// </summary>
        [XmlElement("industry_template_code")]
        public string IndustryTemplateCode { get; set; }

        /// <summary>
        /// 行业模版name
        /// </summary>
        [XmlElement("industry_template_name")]
        public string IndustryTemplateName { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 商家logo图片地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商家appid
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户Pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 分账关系信息
        /// </summary>
        [XmlArray("merchant_settle_relation_list")]
        [XmlArrayItem("merchant_settle_relation_processor_response")]
        public List<MerchantSettleRelationProcessorResponse> MerchantSettleRelationList { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 商家联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 芝麻信用id
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
