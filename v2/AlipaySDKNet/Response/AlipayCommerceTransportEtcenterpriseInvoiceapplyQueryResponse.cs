using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoiceapplyQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseInvoiceapplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 虚拟运单编码
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 换票申请id,已被换票才有
        /// </summary>
        [XmlElement("change_apply_id")]
        public string ChangeApplyId { get; set; }

        /// <summary>
        /// 发票金额,单位:分
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 发票申请列表
        /// </summary>
        [XmlElement("invoice_list")]
        public EtcCorpInvoiceList InvoiceList { get; set; }

        /// <summary>
        /// 发票张数
        /// </summary>
        [XmlElement("invoice_num")]
        public string InvoiceNum { get; set; }

        /// <summary>
        /// 运单发票整体状态
        /// </summary>
        [XmlElement("waybill_invoice_status")]
        public string WaybillInvoiceStatus { get; set; }

        /// <summary>
        /// 外部企业运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// 打包下载地址,运单完全开完才有
        /// </summary>
        [XmlElement("waybill_oss_url")]
        public string WaybillOssUrl { get; set; }
    }
}
