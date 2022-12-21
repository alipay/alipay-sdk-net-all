using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnitedopencouponReceiveTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnitedopencouponReceiveTriggerResponse : AopResponse
    {
        /// <summary>
        /// 用户支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户本次领取到的券列表信息
        /// </summary>
        [XmlArray("voucher_details")]
        [XmlArrayItem("united_voucher_detail")]
        public List<UnitedVoucherDetail> VoucherDetails { get; set; }
    }
}
