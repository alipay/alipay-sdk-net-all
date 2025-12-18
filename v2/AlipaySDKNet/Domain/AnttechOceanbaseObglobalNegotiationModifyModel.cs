using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalNegotiationModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalNegotiationModifyModel : AopObject
    {
        /// <summary>
        /// 入参
        /// </summary>
        [XmlElement("fxiaoke_update_contract_request")]
        public FxiaokeUpdateContractRequest FxiaokeUpdateContractRequest { get; set; }
    }
}
