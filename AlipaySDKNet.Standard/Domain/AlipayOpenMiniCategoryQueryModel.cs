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
        /// 是否过滤小程序不可用类目。枚举值如下： * true：表示过滤不可用类目。 * false：表示不过滤不可用类目。
        /// </summary>
        [XmlElement("is_filter")]
        public bool IsFilter { get; set; }
    }
}
