using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItemModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedicineItemModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
