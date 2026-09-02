using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceApplyExpressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyExpressInfo : AopObject
    {
        /// <summary>
        /// 物流详细信息，包含物流的节点信息
        /// </summary>
        [XmlArray("express_detail_list")]
        [XmlArrayItem("device_apply_express_detail")]
        public List<DeviceApplyExpressDetail> ExpressDetailList { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }
    }
}
