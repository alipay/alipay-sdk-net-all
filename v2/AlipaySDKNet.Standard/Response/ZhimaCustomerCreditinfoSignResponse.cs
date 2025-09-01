using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCreditinfoSignResponse.
    /// </summary>
    public class ZhimaCustomerCreditinfoSignResponse : AopResponse
    {
        /// <summary>
        /// 授权成功：SUCCESS；授权失败：FAIL
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 当auth_result的值为FAIL时，can_auth才会有值，true代表可以授权，false代表不可以授权
        /// </summary>
        [XmlElement("can_auth")]
        public bool CanAuth { get; set; }

        /// <summary>
        /// 用户授权成功后，芝麻侧生成的唯一授权单号
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
