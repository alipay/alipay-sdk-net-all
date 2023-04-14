using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalOnlinePayAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalOnlinePayAuthInfo : AopObject
    {
        /// <summary>
        /// 授权码值
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 用户授权状态
        /// </summary>
        [XmlElement("auth_stas")]
        public string AuthStas { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 跳转支付宝授权页面地址
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }

        /// <summary>
        /// 渠道信息签名串
        /// </summary>
        [XmlElement("chnl_sign_data")]
        public string ChnlSignData { get; set; }

        /// <summary>
        /// 业务核验令牌
        /// </summary>
        [XmlElement("oc_token")]
        public string OcToken { get; set; }

        /// <summary>
        /// 机构信息签名串
        /// </summary>
        [XmlElement("org_sign_data")]
        public string OrgSignData { get; set; }

        /// <summary>
        /// ISV请求业务唯一流水号
        /// </summary>
        [XmlElement("req_biz_no")]
        public string ReqBizNo { get; set; }
    }
}
