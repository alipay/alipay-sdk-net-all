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
        /// 企业关联关系子产品码。目前支持3类查询： UBO关系查询：uboQuery； 股权关系查询：stockQuery； 工商关系查询：gsQuery
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 关联关系类型列表  「关联关系类型」需与「产品码」搭配使用，详细参数见下：1）product_code = uboQuery 时，ubo ：最终受益人；2）product_code = stockQuery 时，root：实际控制方；mom：母公司；parent：母公司的其他控股股东；child：子公司；sibling：兄弟公司(受同一控制方控制的其他企业)；uncle：重大影响/共同控制投资方；joint：联营/合营公司；3）product_code = gsQuery 时，head：总公司；branch：子公司；
        /// </summary>
        [XmlArray("relation_code_list")]
        [XmlArrayItem("string")]
        public List<string> RelationCodeList { get; set; }
    }
}
