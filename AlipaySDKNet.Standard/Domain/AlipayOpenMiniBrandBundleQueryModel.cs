using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBrandBundleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBrandBundleQueryModel : AopObject
    {
        /// <summary>
        /// 所需查询的小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
