using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalPartnerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalPartnerCreateModel : AopObject
    {
        /// <summary>
        /// 创建合作伙伴请求
        /// </summary>
        [XmlElement("create_partner_request")]
        public CreatePartnerRequest CreatePartnerRequest { get; set; }
    }
}
