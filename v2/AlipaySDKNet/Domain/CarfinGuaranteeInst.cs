using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinGuaranteeInst Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinGuaranteeInst : AopObject
    {
        /// <summary>
        /// 担保机构名称
        /// </summary>
        [XmlElement("guarantee_inst_name")]
        public string GuaranteeInstName { get; set; }

        /// <summary>
        /// 担保机构简
        /// </summary>
        [XmlElement("guarantee_inst_short_name")]
        public string GuaranteeInstShortName { get; set; }

        /// <summary>
        /// 担保机构统一社会信用代码
        /// </summary>
        [XmlElement("guarantee_inst_uscc")]
        public string GuaranteeInstUscc { get; set; }
    }
}
