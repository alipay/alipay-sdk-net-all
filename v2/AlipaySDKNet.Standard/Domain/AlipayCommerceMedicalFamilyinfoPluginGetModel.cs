using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFamilyinfoPluginGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFamilyinfoPluginGetModel : AopObject
    {
        /// <summary>
        /// 用户在支付宝插件中操作完成后的回跳地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }
    }
}
