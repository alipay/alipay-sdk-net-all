using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedicineShopModifyResponse : AopResponse
    {
        /// <summary>
        /// 门店修改申请Id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 外部门店Id
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// 支付宝门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
