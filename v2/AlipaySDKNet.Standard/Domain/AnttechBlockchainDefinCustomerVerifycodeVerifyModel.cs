using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerVerifycodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinCustomerVerifycodeVerifyModel : AopObject
    {
        /// <summary>
        /// 自定义的action，比如：LOGIN，REGISTER，MODIFY_PASSWORD等
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// DCHAIN("DCHAIN","供应链信用流转平台"),     ABS("ABS","ABS资产流转平台"),     BAMBOO("BAMBOO","BAMBOO项目"),     LOGISTICS_FIN("LOGISTICS_FIN", "物流金融"),     TRUSPLE("TRUSPLE", "跨境贸易金融平台");
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 接受验证码的目标地址，可以是手机号或者邮箱号 133333333 test@example.com
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 待校验的验证码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
