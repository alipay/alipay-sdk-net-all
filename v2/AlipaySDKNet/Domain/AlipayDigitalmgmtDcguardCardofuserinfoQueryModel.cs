using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtDcguardCardofuserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtDcguardCardofuserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 主卡号
        /// </summary>
        [XmlElement("main_no")]
        public string MainNo { get; set; }

        /// <summary>
        /// 物理卡号
        /// </summary>
        [XmlElement("physical_no")]
        public string PhysicalNo { get; set; }

        /// <summary>
        /// 扇区号
        /// </summary>
        [XmlElement("section_no")]
        public string SectionNo { get; set; }
    }
}
