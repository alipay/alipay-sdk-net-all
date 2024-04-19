using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationShopMemberDigest Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationShopMemberDigest : AopObject
    {
        /// <summary>
        /// 资产收录时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商业关系物理门店资产成员编号
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }
    }
}
