using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspGroupidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspGroupidQueryModel : AopObject
    {
        /// <summary>
        /// ISV的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }
    }
}
