using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityRelationshipExtendField Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityRelationshipExtendField : AopObject
    {
        /// <summary>
        /// 是否需要跳转外部链接查询户号，1-是，0-否。默认为否
        /// </summary>
        [XmlElement("external_billkey_query_flag")]
        public string ExternalBillkeyQueryFlag { get; set; }
    }
}
