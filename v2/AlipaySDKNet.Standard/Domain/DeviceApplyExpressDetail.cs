using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceApplyExpressDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyExpressDetail : AopObject
    {
        /// <summary>
        /// 物流节点发生的时间
        /// </summary>
        [XmlElement("express_time")]
        public string ExpressTime { get; set; }

        /// <summary>
        /// 快递编号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }

        /// <summary>
        /// 物流节点信息
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 物流节点状态
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
