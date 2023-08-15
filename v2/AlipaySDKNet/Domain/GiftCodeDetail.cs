using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftCodeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GiftCodeDetail : AopObject
    {
        /// <summary>
        /// 二维码所属码组的ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 喜气红包二维码唯一标识，一个二维码有唯一一个ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 二维码对应的短链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
