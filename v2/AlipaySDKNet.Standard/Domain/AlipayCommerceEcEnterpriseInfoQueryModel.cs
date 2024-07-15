using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseInfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业id,从企业注册等接口获取，和out_biz_no参数二选一，都传优先取企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 服务商生成的请求唯一流水号/业务幂等号，和enterprise_id参数二选一，都传优先取企业id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
