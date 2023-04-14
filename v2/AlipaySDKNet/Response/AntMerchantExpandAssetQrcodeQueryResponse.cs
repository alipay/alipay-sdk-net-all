using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetQrcodeQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 码业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 码图url
        /// </summary>
        [XmlElement("dynamic_img_url")]
        public string DynamicImgUrl { get; set; }

        /// <summary>
        /// 二维码唯一标识
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }
    }
}
