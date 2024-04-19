using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayCodecHschoolDecodeUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecHschoolDecodeUseModel : AopObject
    {
        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("code_value")]
        public string CodeValue { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        [XmlElement("institution_code")]
        public string InstitutionCode { get; set; }
    }
}
