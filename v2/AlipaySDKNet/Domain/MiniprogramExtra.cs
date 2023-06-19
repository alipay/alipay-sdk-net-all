using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniprogramExtra Data Structure.
    /// </summary>
    [Serializable]
    public class MiniprogramExtra : AopObject
    {
        /// <summary>
        /// 生活号佣金类型
        /// </summary>
        [XmlElement("commission_type")]
        public string CommissionType { get; set; }
    }
}
