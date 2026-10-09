using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoiceBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务身份id
        /// </summary>
        [XmlArray("business_identify_ids")]
        [XmlArrayItem("string")]
        public List<string> BusinessIdentifyIds { get; set; }

        /// <summary>
        /// OU
        /// </summary>
        [XmlArray("buyer_inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> BuyerInstIdList { get; set; }

        /// <summary>
        /// 发票认证开始日期
        /// </summary>
        [XmlElement("invoice_auth_date_begin")]
        public string InvoiceAuthDateBegin { get; set; }

        /// <summary>
        /// 发票认证结束日期
        /// </summary>
        [XmlElement("invoice_auth_date_end")]
        public string InvoiceAuthDateEnd { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票开始日期 格式yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date_begin")]
        public string InvoiceDateBegin { get; set; }

        /// <summary>
        /// 发票结束日期 格式yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date_end")]
        public string InvoiceDateEnd { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlArray("invoice_id_list")]
        [XmlArrayItem("string")]
        public List<string> InvoiceIdList { get; set; }

        /// <summary>
        /// 发票录入开始日期
        /// </summary>
        [XmlElement("invoice_input_date_begin")]
        public string InvoiceInputDateBegin { get; set; }

        /// <summary>
        /// 发票录入结束日期
        /// </summary>
        [XmlElement("invoice_input_date_end")]
        public string InvoiceInputDateEnd { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 收票开始日期
        /// </summary>
        [XmlElement("invoice_receive_date_begin")]
        public string InvoiceReceiveDateBegin { get; set; }

        /// <summary>
        /// 收票结束日期
        /// </summary>
        [XmlElement("invoice_receive_date_end")]
        public string InvoiceReceiveDateEnd { get; set; }

        /// <summary>
        /// 收票状态,01 发票已提交;02 审核中(已收票);      * 03 已审核;04 已驳回;05 已认证;06 已撤回      * 发票类型为 02销项票时 发票状态 01待开票 02开票中 03已开票      * 04作废中 05已作废 06红冲中 07已红冲 08部分红冲 09无效
        /// </summary>
        [XmlElement("invoice_status_list")]
        public string InvoiceStatusList { get; set; }

        /// <summary>
        /// 发票种类 01专票 02普票 03国际形式发票
        /// </summary>
        [XmlElement("invoice_type_list")]
        public string InvoiceTypeList { get; set; }

        /// <summary>
        /// 开票号
        /// </summary>
        [XmlElement("kp_no")]
        public string KpNo { get; set; }

        /// <summary>
        /// 起始页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// seller_ip_role_id批量查询
        /// </summary>
        [XmlArray("seller_ip_role_ids")]
        [XmlArrayItem("string")]
        public List<string> SellerIpRoleIds { get; set; }
    }
}
