using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseCouponsQueryModel : AopObject
    {
        /// <summary>
        /// 小程序云的appID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
