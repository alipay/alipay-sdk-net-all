using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTaxbillSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTaxbillSignQueryModel : AopObject
    {
        /// <summary>
        /// 场景码，固定值：SIGN
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 税筹服务商在平台的唯一性身份标识，入驻平台成功后由平台方提供
        /// </summary>
        [XmlElement("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 用工企业在平台的唯一性身份标识，入驻平台成功后由平台方提供
        /// </summary>
        [XmlElement("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识，用工企业自定义参数，用于用工企业识别雇员身份
        /// </summary>
        [XmlElement("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 产品码，固定值：TAX_BILL_PLATFORM
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 方案模板编码，企业邀请C端用户和多家税筹服务商同时签约（1对N）后，批量查询签约结果时需要提供该参数
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
