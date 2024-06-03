using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZXZMessageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZXZMessageDetail : AopObject
    {
        /// <summary>
        /// 支小助回答记录卡片信息
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("z_x_z_message_card")]
        public List<ZXZMessageCard> Records { get; set; }

        /// <summary>
        /// 执行状态 pending 等待中 running 执行中 success 执行成功 fail 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
