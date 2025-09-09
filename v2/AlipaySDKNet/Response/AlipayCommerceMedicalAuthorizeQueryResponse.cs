using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAuthorizeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支持：true,不支持：false
        /// </summary>
        [XmlElement("institution_ecode_status")]
        public bool InstitutionEcodeStatus { get; set; }

        /// <summary>
        /// 结果页地址
        /// </summary>
        [XmlElement("page_result_url")]
        public string PageResultUrl { get; set; }

        /// <summary>
        /// ecode_open:开通一码付
        /// </summary>
        [XmlElement("page_suggestion")]
        public string PageSuggestion { get; set; }

        /// <summary>
        /// 跳转引导页的地址
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 一码付签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
