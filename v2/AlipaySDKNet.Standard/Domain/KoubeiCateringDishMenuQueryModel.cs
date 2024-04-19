using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishMenuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMenuQueryModel : AopObject
    {
        /// <summary>
        /// 菜谱名称
        /// </summary>
        [XmlElement("cook_name")]
        public string CookName { get; set; }
    }
}
