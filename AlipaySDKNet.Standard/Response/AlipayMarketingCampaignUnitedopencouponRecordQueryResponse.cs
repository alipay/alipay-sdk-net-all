using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnitedopencouponRecordQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnitedopencouponRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户已领取到的券（奖品）列表信息
        /// </summary>
        [XmlArray("voucher_details")]
        [XmlArrayItem("united_voucher_detail")]
        public List<UnitedVoucherDetail> VoucherDetails { get; set; }
    }
}
