using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Pariticipant Data Structure.
    /// </summary>
    [Serializable]
    public class Pariticipant : AopObject
    {
        /// <summary>
        /// 风控主体标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 风控主体标识类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 风控主体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 入驻平台的时间点，格式是yyyy-MM-dd HH:mm，biz_scene是CONSULT_BY_RISK_SCENE时必填
        /// </summary>
        [XmlElement("settle_in_time")]
        public string SettleInTime { get; set; }
    }
}
