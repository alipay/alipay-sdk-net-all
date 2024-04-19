using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineItemCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedicineItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
