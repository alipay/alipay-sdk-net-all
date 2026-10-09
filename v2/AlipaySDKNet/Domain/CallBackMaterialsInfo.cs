using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CallBackMaterialsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CallBackMaterialsInfo : AopObject
    {
        /// <summary>
        /// 门店桌号
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 点餐二维码链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
