using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUserDeleteModel : AopObject
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
        /// 用户ID列表，单次操作最多100个
        /// </summary>
        [XmlArray("vid_list")]
        [XmlArrayItem("string")]
        public List<string> VidList { get; set; }
    }
}
