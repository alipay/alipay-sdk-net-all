using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRebusinessentityPersonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRebusinessentityPersonQueryModel : AopObject
    {
        /// <summary>
        /// 法人证件号
        /// </summary>
        [XmlElement("person_cert_no")]
        public string PersonCertNo { get; set; }

        /// <summary>
        /// 法人证件号md5值
        /// </summary>
        [XmlElement("person_cert_no_md_5")]
        public string PersonCertNoMd5 { get; set; }

        /// <summary>
        /// 法人证件号（身份证号含护照等其他证件）SHA256加密的密文
        /// </summary>
        [XmlElement("person_cert_no_sha_256")]
        public string PersonCertNoSha256 { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }

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

        /// <summary>
        /// 企业18位统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
