using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaasBusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class SaasBusinessParams : AopObject
    {
        /// <summary>
        /// 校园卡编号
        /// </summary>
        [XmlElement("campus_card")]
        public string CampusCard { get; set; }
    }
}
