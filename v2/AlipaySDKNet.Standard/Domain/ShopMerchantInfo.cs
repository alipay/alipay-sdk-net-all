using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopMerchantInfo : AopObject
    {
        /// <summary>
        /// isv定义的商家id（isv侧唯一）
        /// </summary>
        [XmlElement("isv_mid")]
        public string IsvMid { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 签约模式(self_help：商户自助开通、isv_help_smid：ISV代smid开通、isv_help_pid：ISV代pid开通)
        /// </summary>
        [XmlElement("sign_mode")]
        public string SignMode { get; set; }

        /// <summary>
        /// 间连商家smid(间连必传)
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
