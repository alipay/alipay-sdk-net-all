using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineDetail : AopObject
    {
        /// <summary>
        /// 药品说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 价格25.99元
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// xx药品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 药品图片url
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 价格25.99元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }
    }
}
