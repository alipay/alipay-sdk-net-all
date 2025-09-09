using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolActivityAppitemvoucherQueryModel : AopObject
    {
        /// <summary>
        /// 活动id 来源：来自创建接口返回的activity_id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
