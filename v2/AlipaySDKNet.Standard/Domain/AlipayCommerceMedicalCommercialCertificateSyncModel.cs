using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialCertificateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialCertificateSyncModel : AopObject
    {
        /// <summary>
        /// 用户兑换凭证的实际业务时间，默认为系统当前时间
        /// </summary>
        [XmlElement("business_date")]
        public string BusinessDate { get; set; }

        /// <summary>
        /// 用户openid，唯一映射用户userid，用于唯一标识用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户兑换开通凭证的唯一业务流水号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 凭证兑换目标，如用户所兑换会员卡商品的sku_id
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户兑换凭证时登陆或指定的手机号码，仅支持中国大陆11位手机号
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
