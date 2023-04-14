using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigConsultResponse.
    /// </summary>
    public class AntMerchantExpandMembercardConfigConsultResponse : AopResponse
    {
        /// <summary>
        /// 商户不存在; 商户配置过储值产品; 商户已开通其他会员产品; 当面付未开通;
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// true: 可以开通 false: 不能开通
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
