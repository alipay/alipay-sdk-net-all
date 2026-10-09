using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSceneRoleFailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSceneRoleFailInfo : AopObject
    {
        /// <summary>
        /// 失败原因码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
