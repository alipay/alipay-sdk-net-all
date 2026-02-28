using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboDiscountInfo : AopObject
    {
        /// <summary>
        /// 金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("extend_info")]
        [XmlArrayItem("robo_extend_info")]
        public List<RoboExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 费用类型 101:起步费  102:里程费  103:时长费  105:远途费 114:渠道优惠 115:一口价
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
