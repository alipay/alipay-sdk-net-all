using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProfileSnDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ProfileSnDetail : AopObject
    {
        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// sn状态 -1无效，1未使用 。2已使用
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
