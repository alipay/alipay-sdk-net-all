using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayAuthInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayAuthInfoDTO : AopObject
    {
        /// <summary>
        /// 员工授权的收单商户 PID
        /// </summary>
        [XmlElement("auth_pid")]
        public string AuthPid { get; set; }

        /// <summary>
        /// 员工对该收单商户 PID 的因公付代扣授权状态。
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }
    }
}
