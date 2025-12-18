using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinFundingInst Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinFundingInst : AopObject
    {
        /// <summary>
        /// 出资机构名称
        /// </summary>
        [XmlElement("funding_inst_name")]
        public string FundingInstName { get; set; }

        /// <summary>
        /// 出资机构简称
        /// </summary>
        [XmlElement("funding_inst_short_name")]
        public string FundingInstShortName { get; set; }

        /// <summary>
        /// 出资机构统一社会信用代码
        /// </summary>
        [XmlElement("funding_inst_uscc")]
        public string FundingInstUscc { get; set; }
    }
}
