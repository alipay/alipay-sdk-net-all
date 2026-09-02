using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceNxactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceNxactivityQueryModel : AopObject
    {
        /// <summary>
        /// 碰出惊喜活动ID，可从碰出惊喜活动创建或活动查询结果中获取。
        /// </summary>
        [XmlElement("act_scheme_id")]
        public string ActSchemeId { get; set; }

        /// <summary>
        /// 支付宝用户标识，平台转换为内部用户ID后用于查询用户的活动详情。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
