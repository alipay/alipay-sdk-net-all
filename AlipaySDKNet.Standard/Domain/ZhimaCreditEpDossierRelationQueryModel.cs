using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierRelationQueryModel : AopObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业关联关系子产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 关联关系类型列表
        /// </summary>
        [XmlArray("relation_code_list")]
        [XmlArrayItem("string")]
        public List<string> RelationCodeList { get; set; }
    }
}
