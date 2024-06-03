using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageRenewCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageRenewCreateandpayModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 优惠券code列表
        /// </summary>
        [XmlArray("coupon_codes")]
        [XmlArrayItem("string")]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// 续费周期数(月)
        /// </summary>
        [XmlElement("renew_month")]
        public long RenewMonth { get; set; }
    }
}
