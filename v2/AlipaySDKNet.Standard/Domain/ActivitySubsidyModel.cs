using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivitySubsidyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ActivitySubsidyModel : AopObject
    {
        /// <summary>
        /// 大运河活动码
        /// </summary>
        [XmlElement("dec_activity_code")]
        public string DecActivityCode { get; set; }

        /// <summary>
        /// 分期费率版本
        /// </summary>
        [XmlElement("dec_fee_fq_rate_version")]
        public string DecFeeFqRateVersion { get; set; }

        /// <summary>
        /// 淘内使用费率档位
        /// </summary>
        [XmlElement("dec_fee_grade")]
        public string DecFeeGrade { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("install_num")]
        public string InstallNum { get; set; }

        /// <summary>
        /// 商家贴息比例 0用户付息，100为商家贴息
        /// </summary>
        [XmlElement("user_fq_seller_percent")]
        public string UserFqSellerPercent { get; set; }
    }
}
