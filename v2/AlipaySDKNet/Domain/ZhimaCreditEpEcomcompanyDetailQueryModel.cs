using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEcomcompanyDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEcomcompanyDetailQueryModel : AopObject
    {
        /// <summary>
        /// 企业查询key：社会统一信用代码、注册号、企业名入参，建议优先使用统代
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
