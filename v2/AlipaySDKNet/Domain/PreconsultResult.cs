using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreconsultResult Data Structure.
    /// </summary>
    [Serializable]
    public class PreconsultResult : AopObject
    {
        /// <summary>
        /// 渠道列表
        /// </summary>
        [XmlElement("channel_list")]
        public ConsultChannelResponse ChannelList { get; set; }

        /// <summary>
        /// 机构PID
        /// </summary>
        [XmlElement("inst_pid")]
        public string InstPid { get; set; }

        /// <summary>
        /// 是否预鉴权通过
        /// </summary>
        [XmlElement("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// 拒绝列表
        /// </summary>
        [XmlElement("refuse_list")]
        public ConsultRefuseResponse RefuseList { get; set; }
    }
}
