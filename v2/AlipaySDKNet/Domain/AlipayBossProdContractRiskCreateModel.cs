using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractRiskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractRiskCreateModel : AopObject
    {
        /// <summary>
        /// 待扫描的附件【前置已经写入法务oss】
        /// </summary>
        [XmlElement("attach")]
        public Attach Attach { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line")]
        public string BusinessLine { get; set; }

        /// <summary>
        /// 文件下载地址 http
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 开票类型
        /// </summary>
        [XmlArray("invoice_type_list")]
        [XmlArrayItem("string")]
        public List<string> InvoiceTypeList { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [XmlElement("operator")]
        public People Operator { get; set; }

        /// <summary>
        /// 付款账户
        /// </summary>
        [XmlArray("payment_account_list")]
        [XmlArrayItem("string")]
        public List<string> PaymentAccountList { get; set; }

        /// <summary>
        /// 我方公司信息
        /// </summary>
        [XmlArray("risk_partner_a_list")]
        [XmlArrayItem("risk_partner_d_t_o")]
        public List<RiskPartnerDTO> RiskPartnerAList { get; set; }

        /// <summary>
        /// 相对方公司
        /// </summary>
        [XmlArray("risk_partner_b_list")]
        [XmlArrayItem("risk_partner_d_t_o")]
        public List<RiskPartnerDTO> RiskPartnerBList { get; set; }

        /// <summary>
        /// 需要扫描的风险类型列表
        /// </summary>
        [XmlArray("risk_types")]
        [XmlArrayItem("string")]
        public List<string> RiskTypes { get; set; }

        /// <summary>
        /// 当前系统的名称
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
