using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniprogramExtra Data Structure.
    /// </summary>
    [Serializable]
    public class MiniprogramExtra : AopObject
    {
        /// <summary>
        /// 生活号佣金类型
        /// </summary>
        [XmlElement("commission_type")]
        public string CommissionType { get; set; }

        /// <summary>
        /// 小程序绑定的账号的管理员ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
