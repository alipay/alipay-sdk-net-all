using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantLifeMiniprogramQueryResponse.
    /// </summary>
    public class AlipayMerchantLifeMiniprogramQueryResponse : AopResponse
    {
        /// <summary>
        /// 生活号和业务关联的扩展信息
        /// </summary>
        [XmlElement("extra")]
        public MiniprogramExtra Extra { get; set; }

        /// <summary>
        /// 操作员类型
        /// </summary>
        [XmlElement("ops_type")]
        public string OpsType { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
