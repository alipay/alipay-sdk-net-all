using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyproductModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyproductModifyModel : AopObject
    {
        /// <summary>
        /// 企业（商户）产品配置
        /// </summary>
        [XmlElement("product_config")]
        public CompanyProductConfig ProductConfig { get; set; }

        /// <summary>
        /// 发票产品编号，必须为已开通产品，可调用反向企业信息查询接口查询
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
