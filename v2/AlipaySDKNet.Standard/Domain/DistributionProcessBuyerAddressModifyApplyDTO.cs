using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionProcessBuyerAddressModifyApplyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionProcessBuyerAddressModifyApplyDTO : AopObject
    {
        /// <summary>
        /// 是否同意；true：表示同意，false：表示不同意
        /// </summary>
        [XmlElement("agree")]
        public bool Agree { get; set; }
    }
}
