using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketQRCode Data Structure.
    /// </summary>
    [Serializable]
    public class TicketQRCode : AopObject
    {
        /// <summary>
        /// 票 、码的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 当前二维码的过期时间，可选传递,不传的话为长期有效
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前二维码包含的门票的数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 二维码检票的code值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// qrcode的图片URL，可选传递
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// 当前二维码的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二维码有效时长,单位为秒,不传的话为长期有效
        /// </summary>
        [XmlElement("valid_time")]
        public long ValidTime { get; set; }
    }
}
