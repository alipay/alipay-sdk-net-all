using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedicineShopCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店创建申请Id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 触发幂等时返回已存在的门店shopId
        /// </summary>
        [XmlElement("exist_shop_id")]
        public string ExistShopId { get; set; }
    }
}
