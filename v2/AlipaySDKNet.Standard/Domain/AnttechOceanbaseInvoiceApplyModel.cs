using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseInvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseInvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 业务唯一键，可做幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型，需要向OB申请业务接入分配业务类型，动态增加，不使用枚举
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 发票抬头信息，购买方信息
        /// </summary>
        [XmlElement("buyer")]
        public ObcInvoiceIssuerRequest Buyer { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 币种code，例如CNY
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 财务备注信息，当经过了财务审批时，财务会填写备注信息
        /// </summary>
        [XmlElement("finance_remarks")]
        public string FinanceRemarks { get; set; }

        /// <summary>
        /// 开票金额,CNY币种下单位为元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 该备注会直接在发票中备注一栏展示，一般由购方填写或销方取得购方许可后填写购方要求的内容
        /// </summary>
        [XmlElement("invoice_remarks")]
        public string InvoiceRemarks { get; set; }

        /// <summary>
        /// 发票明细行信息，可开多行发票，但原则上不超过20行
        /// </summary>
        [XmlArray("objects")]
        [XmlArrayItem("obc_invoice_apply_line_request")]
        public List<ObcInvoiceApplyLineRequest> Objects { get; set; }

        /// <summary>
        /// 发票申请单的备注，可选，不会展示到发票中。仅做申请时的描述和说明
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 销方主体OU，默认ZN7
        /// </summary>
        [XmlElement("seller_inst_id")]
        public string SellerInstId { get; set; }
    }
}
