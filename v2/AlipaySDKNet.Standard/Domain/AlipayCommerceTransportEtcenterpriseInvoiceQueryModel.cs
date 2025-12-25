using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseInvoiceQueryModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 查询月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 不传入时默认 =1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据条数,默认10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 外部企业运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// 查询年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
