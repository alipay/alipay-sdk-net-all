using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanysupplierCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanysupplierCreateResponse : AopResponse
    {
        /// <summary>
        /// 端内通知打开反向开票供应商关系确认页面的url
        /// </summary>
        [XmlElement("activation_alipay_url")]
        public string ActivationAlipayUrl { get; set; }

        /// <summary>
        /// 短信方式通知打开反向开票供应商关系确认页面的url
        /// </summary>
        [XmlElement("activation_url")]
        public string ActivationUrl { get; set; }

        /// <summary>
        /// 新增成功的供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
