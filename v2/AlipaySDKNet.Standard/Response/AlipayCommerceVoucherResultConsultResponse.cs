using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceVoucherResultConsultResponse.
    /// </summary>
    public class AlipayCommerceVoucherResultConsultResponse : AopResponse
    {
        /// <summary>
        /// 最优券叠加总优惠金额，单位为元
        /// </summary>
        [XmlElement("optimal_total_promo_amount")]
        public string OptimalTotalPromoAmount { get; set; }

        /// <summary>
        /// 优惠券咨询结果列表
        /// </summary>
        [XmlArray("voucher_consult_list")]
        [XmlArrayItem("voucher_consult_info")]
        public List<VoucherConsultInfo> VoucherConsultList { get; set; }
    }
}
