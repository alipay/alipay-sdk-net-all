using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyRelationValidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyRelationValidQueryModel : AopObject
    {
        /// <summary>
        /// 是否需要强一致查询，无特殊要求传false即可。
        /// </summary>
        [XmlElement("strict")]
        public bool Strict { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
