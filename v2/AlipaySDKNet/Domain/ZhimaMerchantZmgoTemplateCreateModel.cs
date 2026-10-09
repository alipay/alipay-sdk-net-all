using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantZmgoTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantZmgoTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 芝麻GO模板的基本信息1配置
        /// </summary>
        [XmlElement("basic_config")]
        public ZMGOBasicConfig BasicConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板拓展配置
        /// </summary>
        [XmlElement("ext_config")]
        public ZMGOExtConfig ExtConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板义务配置，若为承诺模式，必传
        /// </summary>
        [XmlElement("obligation_config")]
        public ZMGOObligationConfig ObligationConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板的开通信息配置
        /// </summary>
        [XmlElement("open_config")]
        public ZMGOOpenConfig OpenConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板的退出信息配置
        /// </summary>
        [XmlElement("quit_config")]
        public ZMGOQuitConfig QuitConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板的权利信息配置
        /// </summary>
        [XmlElement("right_config")]
        public ZMGORightConfig RightConfig { get; set; }

        /// <summary>
        /// 芝麻GO模板的结算信息配置
        /// </summary>
        [XmlElement("settlement_config")]
        public ZMGOSettlementConfig SettlementConfig { get; set; }
    }
}
