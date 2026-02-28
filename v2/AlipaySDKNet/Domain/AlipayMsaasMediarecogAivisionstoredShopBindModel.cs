using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredShopBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionstoredShopBindModel : AopObject
    {
        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// isv提供的指定id
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// isv的门店pid
        /// </summary>
        [XmlElement("shop_pid")]
        public string ShopPid { get; set; }
    }
}
