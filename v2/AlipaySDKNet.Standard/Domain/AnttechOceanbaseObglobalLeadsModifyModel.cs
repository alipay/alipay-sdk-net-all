using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalLeadsModifyModel : AopObject
    {
        /// <summary>
        /// 纷享销客更新leads
        /// </summary>
        [XmlElement("fxiaoke_update_leads_request")]
        public FxiaokeUpdateLeadsRequest FxiaokeUpdateLeadsRequest { get; set; }
    }
}
