using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandSceneRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandSceneRoleQueryModel : AopObject
    {
        /// <summary>
        /// 商户编号，由调用方定义，需要保证在调用方下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户 id
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
