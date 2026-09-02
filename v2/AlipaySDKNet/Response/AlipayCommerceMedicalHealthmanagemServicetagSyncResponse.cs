using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthmanagemServicetagSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthmanagemServicetagSyncResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("service_tag_sync_fail_info_d_t_o")]
        public List<ServiceTagSyncFailInfoDTO> FailList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("string")]
        public List<string> SuccList { get; set; }
    }
}
