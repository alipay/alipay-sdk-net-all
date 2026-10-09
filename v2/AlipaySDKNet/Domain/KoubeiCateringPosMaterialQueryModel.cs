using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialQueryModel : AopObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
