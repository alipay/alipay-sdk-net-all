using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNfcorderTagsignCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNfcorderTagsignCheckavailableModel : AopObject
    {
        /// <summary>
        /// 通过小程序api获取到的开放物料id
        /// </summary>
        [XmlElement("open_tag_id")]
        public string OpenTagId { get; set; }

        /// <summary>
        /// 碰一下获取到的签名信息
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
