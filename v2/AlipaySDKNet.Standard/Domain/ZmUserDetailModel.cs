using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmUserDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZmUserDetailModel : AopObject
    {
        /// <summary>
        /// hash值
        /// </summary>
        [XmlElement("original_hash")]
        public string OriginalHash { get; set; }

        /// <summary>
        /// 初始向量值
        /// </summary>
        [XmlElement("original_vector")]
        public string OriginalVector { get; set; }

        /// <summary>
        /// 加密后的数据值
        /// </summary>
        [XmlElement("secrect_value")]
        public string SecrectValue { get; set; }

        /// <summary>
        /// 加密后的动态秘钥
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }
    }
}
