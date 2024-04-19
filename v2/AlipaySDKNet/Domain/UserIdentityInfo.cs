using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserIdentityInfo : AopObject
    {
        /// <summary>
        /// 校园码身份信息
        /// </summary>
        [XmlElement("h_school_info")]
        public HSchoolInfo HSchoolInfo { get; set; }
    }
}
