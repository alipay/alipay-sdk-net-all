using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFundBindCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundBindCreateModel : AopObject
    {
        /// <summary>
        /// 绑卡用户的证件号，需要和cert_type联合使用
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 待绑卡用户的证件类型：0（身份证） 。目前只支持身份证。
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 绑卡过期时间，过期后用户无法进行绑卡，该字段选填，为空情况下默认长期有效（1年）
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 绑卡流水号，用来标识一次绑卡行为，商户维度下需确保唯一
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }

        /// <summary>
        /// 绑卡用户的真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户绑卡成功后，需要回调的页面地址。
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
