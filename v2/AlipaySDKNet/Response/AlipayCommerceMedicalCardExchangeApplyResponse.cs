using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeApplyResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardExchangeApplyResponse : AopResponse
    {
        /// <summary>
        /// 兑换券码信息
        /// </summary>
        [XmlArray("coupon_code_list")]
        [XmlArrayItem("member_coupon_code_d_t_o")]
        public List<MemberCouponCodeDTO> CouponCodeList { get; set; }
    }
}
