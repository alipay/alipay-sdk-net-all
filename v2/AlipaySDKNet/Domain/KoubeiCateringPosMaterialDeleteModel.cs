using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialDeleteModel : AopObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
