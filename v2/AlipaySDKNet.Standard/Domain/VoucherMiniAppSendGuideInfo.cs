using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherMiniAppSendGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherMiniAppSendGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序发券链接
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
