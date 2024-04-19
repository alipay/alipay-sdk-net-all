using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsmemberCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadsmemberCreateModel : AopObject
    {
        /// <summary>
        /// 提供给纷享销客的创建商机成员的接口的请求参数
        /// </summary>
        [XmlElement("fxiaoke_create_leads_member_request")]
        public FxiaokeOperateLeadsMemberParams FxiaokeCreateLeadsMemberRequest { get; set; }
    }
}
