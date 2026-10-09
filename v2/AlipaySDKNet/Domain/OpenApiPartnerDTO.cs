using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPartnerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPartnerDTO : AopObject
    {
        /// <summary>
        /// 公司OU编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }
    }
}
