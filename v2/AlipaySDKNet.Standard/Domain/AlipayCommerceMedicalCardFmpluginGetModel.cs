using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardFmpluginGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardFmpluginGetModel : AopObject
    {
        /// <summary>
        /// 用户在插件中操作完成后回跳地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }
    }
}
