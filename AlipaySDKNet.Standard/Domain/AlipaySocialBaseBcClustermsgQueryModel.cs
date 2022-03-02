using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcClustermsgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseBcClustermsgQueryModel : AopObject
    {
        /// <summary>
        /// 操作的商家标识id，可选，默认是应用app下的pid；如果填写第三方商家标识id，需要保证app下的pid是该商家的管理员
        /// </summary>
        [XmlElement("operate_business_id")]
        public string OperateBusinessId { get; set; }

        /// <summary>
        /// 客户群业务租户id，比如生态商家此id为7，b站开通商户为18
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
