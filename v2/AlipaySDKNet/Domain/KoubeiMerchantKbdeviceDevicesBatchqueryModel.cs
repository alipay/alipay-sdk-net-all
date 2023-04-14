using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbdeviceDevicesBatchqueryModel : AopObject
    {
        /// <summary>
        /// 需要筛选的设备类型。目前仅支持 FOOD_DISPENSER （取餐柜）类型的设备查询，必须填写FOOD_DISPENSER。
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
