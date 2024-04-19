using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPartnerSaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPartnerSaDTO : AopObject
    {
        /// <summary>
        /// 公司主体号
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 签约主体名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }
    }
}
