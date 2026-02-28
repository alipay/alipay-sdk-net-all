using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredShopUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionstoredShopUnbindModel : AopObject
    {
        /// <summary>
        /// 门店设备的sn
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// isv pid值
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 解绑原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 门店的id
        /// </summary>
        [XmlElement("shop_pid")]
        public string ShopPid { get; set; }
    }
}
