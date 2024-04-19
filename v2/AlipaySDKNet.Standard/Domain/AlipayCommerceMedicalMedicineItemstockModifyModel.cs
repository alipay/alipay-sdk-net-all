using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItemstockModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineItemstockModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部唯一标识商品的id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
