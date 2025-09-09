using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtWelfareSupplierauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtWelfareSupplierauthQueryModel : AopObject
    {
        /// <summary>
        /// 该参数用来标识供应商请求的服务内容，是由蚂蚁提供给供应商，蚂蚁侧会根据此参数识别供应商
        /// </summary>
        [XmlElement("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// 该参数用来标识进入供应商系统的用户标志，是登录供应商应用后解析来的，蚂蚁EAP会将此参数作为用户标志之一
        /// </summary>
        [XmlElement("emp_sid")]
        public string EmpSid { get; set; }

        /// <summary>
        /// 该参数用来标识存场景扩展信息，是供应商不同的场景传入对应的信息，蚂蚁侧会进行留存
        /// </summary>
        [XmlElement("ext_info")]
        public WelfareAuthExtReq ExtInfo { get; set; }

        /// <summary>
        /// 该参数用来标识不同渠道的登录标识，是根据用户登录供应商系统后，由供应商传入
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 该参数用来标识用户访问场景，是供应商不同的场景传入对应的来源，蚂蚁侧会根据此来判断员工是否在权益范围内
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
