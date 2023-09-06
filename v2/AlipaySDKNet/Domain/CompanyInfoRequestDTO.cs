using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyInfoRequestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyInfoRequestDTO : AopObject
    {
        /// <summary>
        /// 公司代码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// erp套件
        /// </summary>
        [XmlElement("erp_instance")]
        public string ErpInstance { get; set; }

        /// <summary>
        /// OU
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
