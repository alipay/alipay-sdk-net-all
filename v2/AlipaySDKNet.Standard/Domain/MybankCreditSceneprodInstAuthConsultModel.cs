using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSceneprodInstAuthConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodInstAuthConsultModel : AopObject
    {
        /// <summary>
        /// 需要咨询的内容信息，不填默认是机构是否准入咨询
        /// </summary>
        [XmlElement("consult_content")]
        public string ConsultContent { get; set; }

        /// <summary>
        /// 机构码，机构入驻时网商分配
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 网商分配的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
