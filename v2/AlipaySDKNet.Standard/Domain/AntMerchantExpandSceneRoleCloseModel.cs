using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandSceneRoleCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandSceneRoleCloseModel : AopObject
    {
        /// <summary>
        /// 外部商户号，和商家 id 二选一必填
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户id，和外部商户号二选一必填
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
