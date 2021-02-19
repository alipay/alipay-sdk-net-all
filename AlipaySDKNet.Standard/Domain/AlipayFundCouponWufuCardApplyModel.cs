using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardApplyModel : AopObject
    {
        /// <summary>
        /// 唯一请求码
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("sence_code")]
        public string SenceCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
