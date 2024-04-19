using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalPartnerModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalPartnerModifyModel : AopObject
    {
        /// <summary>
        /// 修改合作伙伴请求
        /// </summary>
        [XmlElement("update_partner_request")]
        public UpdatePartnerRequest UpdatePartnerRequest { get; set; }
    }
}
