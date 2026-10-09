using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceRcptamountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoiceRcptamountQueryModel : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// OU机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票开始月份 格式yyyyMM
        /// </summary>
        [XmlElement("invoice_date_begin")]
        public string InvoiceDateBegin { get; set; }

        /// <summary>
        /// 发票结束月份 格式yyyyMM
        /// </summary>
        [XmlElement("invoice_date_end")]
        public string InvoiceDateEnd { get; set; }

        /// <summary>
        /// 商户MID
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// Y：需开票  N：无需开票  空串：不按此条件过滤
        /// </summary>
        [XmlElement("need_invoice")]
        public string NeedInvoice { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 01 主站,02 芝麻,03 金融云,04 微贷,05 金融云_主站,06 统一结算,07 统一结算2.0
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
