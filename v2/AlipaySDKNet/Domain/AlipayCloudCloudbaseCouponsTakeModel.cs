using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsTakeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseCouponsTakeModel : AopObject
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
