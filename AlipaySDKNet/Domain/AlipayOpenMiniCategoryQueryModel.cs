using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 是否需要过滤不可用类目
        /// </summary>
        [XmlElement("is_filter")]
        public bool IsFilter { get; set; }
    }
}
