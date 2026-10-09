using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceIndustryEnergySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceIndustryEnergySendModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public EnergyExtRequest ExtInfo { get; set; }

        /// <summary>
        /// 外部业务号，用作幂等。 自定义传入，同一场景下，一条外部业务号只可消费一次。
        /// </summary>
        [XmlElement("outer_no")]
        public string OuterNo { get; set; }

        /// <summary>
        /// 行业场景，如社保行业，公积金等，具体场景详情请联系owner
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
