using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionQueryModel : AopObject
    {
        /// <summary>
        /// 农户身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }

        /// <summary>
        /// 产粮记录ID
        /// </summary>
        [XmlElement("farmer_item_id")]
        public string FarmerItemId { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 有效期止（查询范围截止）
        /// </summary>
        [XmlElement("sale_end_date")]
        public string SaleEndDate { get; set; }

        /// <summary>
        /// 有效期起（查询范围起始）
        /// </summary>
        [XmlElement("sale_start_date")]
        public string SaleStartDate { get; set; }

        /// <summary>
        /// 产品税收编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
