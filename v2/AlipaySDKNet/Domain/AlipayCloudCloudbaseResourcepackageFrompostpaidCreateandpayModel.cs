using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageFrompostpaidCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageFrompostpaidCreateandpayModel : AopObject
    {
        /// <summary>
        /// 套餐包是否自动续费
        /// </summary>
        [XmlElement("auto_renew")]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// 小程序云应用APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云应用ENVID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 优惠券code列表，目前只使用第一张
        /// </summary>
        [XmlArray("coupon_codes")]
        [XmlArrayItem("string")]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// 购买时长(月)
        /// </summary>
        [XmlElement("purchase_month")]
        public string PurchaseMonth { get; set; }

        /// <summary>
        /// 资源包规格编码  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
