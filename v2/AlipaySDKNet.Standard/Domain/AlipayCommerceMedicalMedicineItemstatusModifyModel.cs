using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItemstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineItemstatusModifyModel : AopObject
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
        /// 商品上下架状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }
    }
}
