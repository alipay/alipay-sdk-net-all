using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusInstitutionsAddResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusInstitutionsAddResponse : AopResponse
    {
        /// <summary>
        /// 学校内标。如果入驻成功，返回学校内标；入驻失败则不返回学校内标。
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 学校外标。如果入驻成功，返回学校外标；入驻失败则不返回学校外标。
        /// </summary>
        [XmlElement("inst_std_code")]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 入驻失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
