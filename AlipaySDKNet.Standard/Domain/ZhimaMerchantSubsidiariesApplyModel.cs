using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantSubsidiariesApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantSubsidiariesApplyModel : AopObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 信用服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 二级商户进件id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 子商户联系电话
        /// </summary>
        [XmlElement("sub_merchant_contact_number")]
        public string SubMerchantContactNumber { get; set; }

        /// <summary>
        /// 子商户跳转链接
        /// </summary>
        [XmlElement("sub_merchant_jump_link")]
        public string SubMerchantJumpLink { get; set; }

        /// <summary>
        /// 子商户logo地址
        /// </summary>
        [XmlElement("sub_merchant_logo_url")]
        public string SubMerchantLogoUrl { get; set; }

        /// <summary>
        /// 子商户名
        /// </summary>
        [XmlElement("sub_merchant_name")]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 子商户id
        /// </summary>
        [XmlElement("sub_pid")]
        public string SubPid { get; set; }
    }
}
