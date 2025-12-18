using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizUnitInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class BizUnitInfoVO : AopObject
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("biz_unit_id")]
        public string BizUnitId { get; set; }
    }
}
