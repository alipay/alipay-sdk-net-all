using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendBankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendBankInfo : AopObject
    {
        /// <summary>
        /// 银行跳转的安卓的包名
        /// </summary>
        [XmlElement("android_package_name")]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// 银行跳转的安卓schema
        /// </summary>
        [XmlElement("android_schema")]
        public string AndroidSchema { get; set; }

        /// <summary>
        /// 银行编号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行渠道图标地址
        /// </summary>
        [XmlElement("bank_icon_url")]
        public string BankIconUrl { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行渠道是否可用
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 银行跳转的iosschema
        /// </summary>
        [XmlElement("ios_schema")]
        public string IosSchema { get; set; }

        /// <summary>
        /// 银行渠道备注说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
