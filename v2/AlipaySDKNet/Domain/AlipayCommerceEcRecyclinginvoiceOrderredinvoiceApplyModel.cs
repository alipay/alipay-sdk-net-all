using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceOrderredinvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceOrderredinvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 订单号，调用反向订单创建接口时返回，也可以通过反向订单查询接口通过外部订单号查询
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 发票产品ID，传值为当前订单对应的发票产品编号，必须为已开通产品，可调用反向企业（商户）信息查询接口查询
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
