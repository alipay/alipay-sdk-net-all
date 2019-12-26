using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncResponse.
    /// </summary>
    public class AlipayCommerceIotApplyorderStatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 该订单下关联的设备数量
        /// </summary>
        [XmlElement("device_amount")]
        public long DeviceAmount { get; set; }
    }
}
