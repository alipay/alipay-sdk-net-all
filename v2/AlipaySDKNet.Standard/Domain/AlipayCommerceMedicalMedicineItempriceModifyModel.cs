using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItempriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineItempriceModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 原价，单位分，例如传入101代表1.01元
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 外部唯一标识商品的id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 特价后的价格，单位分，例如传入100代表1元
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
