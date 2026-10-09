using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotServicemodelServicelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotServicemodelServicelistQueryModel : AopObject
    {
        /// <summary>
        /// 服务的类型，如播报服务（service_voice），打印服务（service_print）
        /// </summary>
        [XmlElement("service_key")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
