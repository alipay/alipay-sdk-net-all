using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsmemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadsmemberModifyModel : AopObject
    {
        /// <summary>
        /// 提供给纷享销客的更新商机成员的接口的参数
        /// </summary>
        [XmlElement("fxiaoke_update_leads_member_request")]
        public FxiaokeOperateLeadsMemberParams FxiaokeUpdateLeadsMemberRequest { get; set; }
    }
}
