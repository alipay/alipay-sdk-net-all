using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCertifyMerchantConfigs Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCertifyMerchantConfigs : AopObject
    {
        /// <summary>
        /// 不传默认为reserve
        /// </summary>
        [XmlElement("face_reserve_strategy")]
        public string FaceReserveStrategy { get; set; }

        /// <summary>
        /// 认证成功后需要跳转的地址，一般为商户业务页面；若无跳转地址可填空字符""。
        /// </summary>
        [XmlElement("return_url")]
        public string ReturnUrl { get; set; }
    }
}
