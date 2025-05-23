using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceOrderCreateModel : AopObject
    {
        /// <summary>
        /// 企业（商户）营业员ID，传值为已维护的企业（商户）营业员编号，可调用反向企业营业员查询接口查询
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 企业（商户）供应商ID，传值为已维护的企业（商户）供应商编号，可调用反向企业（商户）供应商查询接口查询
        /// </summary>
        [XmlElement("company_supplier_id")]
        public string CompanySupplierId { get; set; }

        /// <summary>
        /// 订单的备注字段,用于发票的备注显示
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单商品明细
        /// </summary>
        [XmlArray("order_item_list")]
        [XmlArrayItem("recyclinginvoice_order_create_item")]
        public List<RecyclinginvoiceOrderCreateItem> OrderItemList { get; set; }

        /// <summary>
        /// 外部订单号，外部系统订单的唯一值，会依据此值做幂等
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 个人所得税类型
        /// </summary>
        [XmlElement("personal_tax_project")]
        public string PersonalTaxProject { get; set; }

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
