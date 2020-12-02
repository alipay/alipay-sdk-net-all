using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerLoginConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinCustomerLoginConfirmModel : AopObject
    {
        /// <summary>
        /// 验证码场景
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// DCHAIN("DCHAIN","供应链信用流转平台"),     ABS("ABS","ABS资产流转平台"),     BAMBOO("BAMBOO","BAMBOO项目"),     LOGISTICS_FIN("LOGISTICS_FIN", "物流金融"),     TRUSPLE("TRUSPLE", "跨境贸易金融平台");
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// "0": 密码登录 "1"：验证码登录
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 密码，一般需要对明文密码做哈希
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
