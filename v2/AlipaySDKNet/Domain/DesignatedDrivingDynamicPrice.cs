using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DesignatedDrivingDynamicPrice Data Structure.
    /// </summary>
    [Serializable]
    public class DesignatedDrivingDynamicPrice : AopObject
    {
        /// <summary>
        /// 调价金额
        /// </summary>
        [XmlElement("dynamic_fee")]
        public string DynamicFee { get; set; }

        /// <summary>
        /// 动态条件倍数
        /// </summary>
        [XmlElement("dynamic_rate")]
        public string DynamicRate { get; set; }

        /// <summary>
        /// 调价原因
        /// </summary>
        [XmlElement("dynamic_reason")]
        public string DynamicReason { get; set; }

        /// <summary>
        /// 调价显示标题，可为空，由支付宝自定义
        /// </summary>
        [XmlElement("dynamic_title")]
        public string DynamicTitle { get; set; }

        /// <summary>
        /// 加价的最大值，部分isv给的数据是加价最大值，部分isv给的是加价后的总金额
        /// </summary>
        [XmlElement("fee_max")]
        public string FeeMax { get; set; }

        /// <summary>
        /// 调价方式，1：金额   2：倍数
        /// </summary>
        [XmlElement("fee_type")]
        public long FeeType { get; set; }
    }
}
