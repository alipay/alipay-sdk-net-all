using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUserstateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUserstateQueryModel : AopObject
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

        /// <summary>
        /// 用户唯一编号
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
