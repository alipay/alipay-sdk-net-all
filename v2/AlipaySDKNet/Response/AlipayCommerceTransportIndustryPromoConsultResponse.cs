using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryPromoConsultResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryPromoConsultResponse : AopResponse
    {
        /// <summary>
        /// 收银台订单信息文案
        /// </summary>
        [XmlElement("cashier_order_info_text")]
        public string CashierOrderInfoText { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_consult_list")]
        [XmlArrayItem("biz_voucher_consult_info")]
        public List<BizVoucherConsultInfo> VoucherConsultList { get; set; }
    }
}
