using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInviteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeInviteQueryModel : AopObject
    {
        /// <summary>
        /// 是否生成签约吱口令，不传默认为N
        /// </summary>
        [XmlElement("create_share_code")]
        public string CreateShareCode { get; set; }

        /// <summary>
        /// 企业码员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 页面内容code
        /// </summary>
        [XmlElement("page_content_code")]
        public string PageContentCode { get; set; }

        /// <summary>
        /// 代扣签约串
        /// </summary>
        [XmlElement("withholding_sign_str")]
        public string WithholdingSignStr { get; set; }
    }
}
