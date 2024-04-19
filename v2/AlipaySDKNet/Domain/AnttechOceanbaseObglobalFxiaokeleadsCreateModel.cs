using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalFxiaokeleadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalFxiaokeleadsCreateModel : AopObject
    {
        /// <summary>
        /// 提供给纷享销客创建商机接口的入参
        /// </summary>
        [XmlElement("fxiaoke_create_leads_request")]
        public FxiaokeCreateLeadsParams FxiaokeCreateLeadsRequest { get; set; }
    }
}
