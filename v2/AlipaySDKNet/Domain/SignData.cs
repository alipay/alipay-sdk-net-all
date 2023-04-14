using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignData Data Structure.
    /// </summary>
    [Serializable]
    public class SignData : AopObject
    {
        /// <summary>
        /// 签名商户开放平台应用APPID
        /// </summary>
        [XmlElement("ori_app_id")]
        public string OriAppId { get; set; }

        /// <summary>
        /// 编码类型（大小写敏感）
        /// </summary>
        [XmlElement("ori_char_set")]
        public string OriCharSet { get; set; }

        /// <summary>
        /// ori_out_biz_no_001
        /// </summary>
        [XmlElement("ori_out_biz_no")]
        public string OriOutBizNo { get; set; }

        /// <summary>
        /// 签名密文
        /// </summary>
        [XmlElement("ori_sign")]
        public string OriSign { get; set; }

        /// <summary>
        /// 签名算法（大小写敏感）
        /// </summary>
        [XmlElement("ori_sign_type")]
        public string OriSignType { get; set; }

        /// <summary>
        /// 2088041181118800
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
