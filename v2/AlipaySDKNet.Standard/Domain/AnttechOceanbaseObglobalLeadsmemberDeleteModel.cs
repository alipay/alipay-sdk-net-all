using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsmemberDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadsmemberDeleteModel : AopObject
    {
        /// <summary>
        /// 提供给分享逍客的删除商机成员的接口的参数
        /// </summary>
        [XmlElement("fxiaoke_delete_leads_member_request")]
        public FxiaokeOperateLeadsMemberParams FxiaokeDeleteLeadsMemberRequest { get; set; }
    }
}
