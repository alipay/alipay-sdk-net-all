using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceMerchantproductApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceMerchantproductApplyModel : AopObject
    {
        /// <summary>
        /// 由外部系统（如合作伙伴平台或第三方服务）生成的唯一业务标识，用于关联外部系统的申请请求。
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 发票产品编号，传值为当前订单对应的发票产品编号，必须为已开通产品，可调用反向企业信息查询接口查询
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
