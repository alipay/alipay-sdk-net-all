using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasMerchantorderModifyModel : AopObject
    {
        /// <summary>
        /// 设备订单状态列表
        /// </summary>
        [XmlArray("device_order_status_list")]
        [XmlArrayItem("device_order_status")]
        public List<DeviceOrderStatus> DeviceOrderStatusList { get; set; }
    }
}
