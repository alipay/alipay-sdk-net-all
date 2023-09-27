using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliyunBSN Data Structure.
    /// </summary>
    [Serializable]
    public class AliyunBSN : AopObject
    {
        /// <summary>
        /// 备案服务码分配时间
        /// </summary>
        [XmlElement("assign_ts")]
        public string AssignTs { get; set; }

        /// <summary>
        /// 备案号
        /// </summary>
        [XmlElement("beian_num")]
        public string BeianNum { get; set; }

        /// <summary>
        /// 备案服务码
        /// </summary>
        [XmlElement("bsn")]
        public string Bsn { get; set; }

        /// <summary>
        /// 备案服务码状态， INIT-未分配，BOUND-已分配，RECORDED-已备案，EXPIRED-已失效，RECORDING-备案中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
