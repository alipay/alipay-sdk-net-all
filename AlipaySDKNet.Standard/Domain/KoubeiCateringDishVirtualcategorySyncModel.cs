using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishVirtualcategorySyncModel : AopObject
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlElement("catetory_info")]
        public KbdishVirtualCatetorySimplifyInfo CatetoryInfo { get; set; }
    }
}
