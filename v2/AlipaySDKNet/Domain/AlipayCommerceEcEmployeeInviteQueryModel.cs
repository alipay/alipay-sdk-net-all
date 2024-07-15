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
        /// 企业码员工ID，签约适用对象为指定员工时填写
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 用于展示不同的页面文案，使用标准页面文案是无需传值
        /// </summary>
        [XmlElement("page_content_code")]
        public string PageContentCode { get; set; }

        /// <summary>
        /// 代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。
        /// </summary>
        [XmlElement("withholding_sign_str")]
        public string WithholdingSignStr { get; set; }
    }
}
