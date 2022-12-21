using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCertificationRiskIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCertificationRiskIdentifyModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取。risk_identify_type=BIZNO 必填
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号risk_identify_type=ENTERPRISE 必填
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称,当risk_identify_type=ENTERPRISE 必填
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 风险识别类别，可传入ENTERPRISE或者PERSON或者BIZNO，用于认证场景，通过传入不同的类别返回不同的风险结果
        /// </summary>
        [XmlElement("risk_identify_type")]
        public string RiskIdentifyType { get; set; }

        /// <summary>
        /// 证件号码，仅支持身份证号,risk_identify_type=PERSON 必填
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 个人用户姓名,risk_identify_type=PERSON 必填
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
