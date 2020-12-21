using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderBrandDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderBrandDetail : AopObject
    {
        /// <summary>
        /// 工单详情数据信息
        /// </summary>
        [XmlElement("brand_detail")]
        public BrandDetail BrandDetail { get; set; }

        /// <summary>
        /// 工单详情key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
