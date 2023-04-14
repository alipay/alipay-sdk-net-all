using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopMemberInfo : AopObject
    {
        /// <summary>
        /// 商业关系中的门店收单
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 商业关系中的门店收单类型,如：PID/SMID
        /// </summary>
        [XmlElement("member_type")]
        public string MemberType { get; set; }
    }
}
