using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderPointQueryModel : AopObject
    {
        /// <summary>
        /// 用户(user中的identity)在应用(appid)下的唯一标识，当issuer为ALIPAY且type为USER_ID时使用 openid改造，新增open_id字段和相关错误码
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 需要查询的积分类型，如家庭积分、会员积分、返佣积分等等
        /// </summary>
        [XmlElement("point_type")]
        public string PointType { get; set; }

        /// <summary>
        /// 用户身份
        /// </summary>
        [XmlElement("user")]
        public UserIdentity User { get; set; }
    }
}
