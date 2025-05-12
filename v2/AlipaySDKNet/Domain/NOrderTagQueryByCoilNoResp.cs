using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagQueryByCoilNoResp Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagQueryByCoilNoResp : AopObject
    {
        /// <summary>
        /// 线圈绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 碰一下跳转的页面链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
