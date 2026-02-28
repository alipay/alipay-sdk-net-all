using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredShopApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionstoredShopApplyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("camera_infos")]
        [XmlArrayItem("camera_info")]
        public List<CameraInfo> CameraInfos { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 2088开头的
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 门店名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店唯一id
        /// </summary>
        [XmlElement("shop_pid")]
        public string ShopPid { get; set; }
    }
}
