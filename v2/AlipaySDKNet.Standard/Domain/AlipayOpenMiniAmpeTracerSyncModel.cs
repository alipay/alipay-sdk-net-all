using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeTracerSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeTracerSyncModel : AopObject
    {
        /// <summary>
        /// 智能设备在AMPE平台注册的设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 智能设备在AMPE平台注册的产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 支付宝业务A点位
        /// </summary>
        [XmlElement("spm_a")]
        public string SpmA { get; set; }

        /// <summary>
        /// 支付宝业务B点位
        /// </summary>
        [XmlElement("spm_b")]
        public string SpmB { get; set; }

        /// <summary>
        /// 支付宝业务C点位
        /// </summary>
        [XmlElement("spm_c")]
        public string SpmC { get; set; }

        /// <summary>
        /// 支付宝业务d点位
        /// </summary>
        [XmlElement("spm_d")]
        public string SpmD { get; set; }
    }
}
