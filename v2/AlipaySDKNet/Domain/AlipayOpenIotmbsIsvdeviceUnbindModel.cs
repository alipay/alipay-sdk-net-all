using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvdeviceUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvdeviceUnbindModel : AopObject
    {
        /// <summary>
        /// project_id+酒店项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// sn+需要解除绑定设备的sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
