using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobPayslipQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobPayslipQueryModel : AopObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
