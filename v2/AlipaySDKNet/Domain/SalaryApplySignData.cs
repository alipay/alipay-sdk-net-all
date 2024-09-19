using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalaryApplySignData Data Structure.
    /// </summary>
    [Serializable]
    public class SalaryApplySignData : AopObject
    {
        /// <summary>
        /// 授权平台的appId
        /// </summary>
        [XmlElement("ori_app_id")]
        public string OriAppId { get; set; }

        /// <summary>
        /// 签名编码，大小写敏感
        /// </summary>
        [XmlElement("ori_char_set")]
        public string OriCharSet { get; set; }

        /// <summary>
        /// 转账申请的外部单号
        /// </summary>
        [XmlElement("ori_out_biz_no")]
        public string OriOutBizNo { get; set; }

        /// <summary>
        /// 转账申请的签名
        /// </summary>
        [XmlElement("ori_sign")]
        public string OriSign { get; set; }

        /// <summary>
        /// 商户签名算法，注意次字段大小写敏感。
        /// </summary>
        [XmlElement("ori_sign_type")]
        public string OriSignType { get; set; }

        /// <summary>
        /// 授权平台的账号ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
