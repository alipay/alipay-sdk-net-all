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
        /// 机构内人员所属的场所，部门场景为必传，比如酒店门禁，需传房间
        /// </summary>
        [XmlArray("place_name_list")]
        [XmlArrayItem("string")]
        public List<string> PlaceNameList { get; set; }

        /// <summary>
        /// 用户VID列表，目前仅支持一次出库一人
        /// </summary>
        [XmlArray("vid_list")]
        [XmlArrayItem("string")]
        public List<string> VidList { get; set; }
    }
}
