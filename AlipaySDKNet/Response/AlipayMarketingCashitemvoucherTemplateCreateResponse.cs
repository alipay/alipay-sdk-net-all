using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCashitemvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashitemvoucherTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板支付确认链接
        /// </summary>
        [XmlElement("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号，模板支付时需要
        /// </summary>
        [XmlElement("fund_order_no")]
        public string FundOrderNo { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 使用一张单品券用户可以获得的最大优惠。计算方式和单张券的最大优惠的上限请参考产品说明文档
        /// </summary>
        [XmlElement("voucher_discount_limit")]
        public string VoucherDiscountLimit { get; set; }
    }
}
