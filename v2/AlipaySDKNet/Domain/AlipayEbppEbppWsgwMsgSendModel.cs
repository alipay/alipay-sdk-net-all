using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppWsgwMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppWsgwMsgSendModel : AopObject
    {
        /// <summary>
        /// 省码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 加密后的二 进制做 base64 编 码
        /// </summary>
        [XmlElement("secret_content")]
        public string SecretContent { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type_code")]
        public string TypeCode { get; set; }
    }
}
