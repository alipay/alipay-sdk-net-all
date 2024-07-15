using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenVoucherBizDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenVoucherBizDataDTO : AopObject
    {
        /// <summary>
        /// 加密后的手机号
        /// </summary>
        [XmlElement("encrypt_phone")]
        public string EncryptPhone { get; set; }
    }
}
