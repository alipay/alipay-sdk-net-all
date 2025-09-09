using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobResumeauthlogininfoGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobResumeauthlogininfoGetModel : AopObject
    {
        /// <summary>
        /// 业务token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }
    }
}
