using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRebusinessentityCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRebusinessentityCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 企业查询key：企业社会统一信用代码，企业注册号，企业名称可任选一个入参
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 店铺平台列表（该字段不传，默认所有店铺平台）
        /// </summary>
        [XmlArray("platform_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformIdList { get; set; }

        /// <summary>
        /// 店铺平台类型列表（该字段不传，默认所有店铺平台类型）
        /// </summary>
        [XmlArray("platform_type_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformTypeList { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 关系类型列表
        /// </summary>
        [XmlArray("rel_type_code_list")]
        [XmlArrayItem("string")]
        public List<string> RelTypeCodeList { get; set; }
    }
}
