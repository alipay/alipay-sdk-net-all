using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUservidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUservidQueryModel : AopObject
    {
        /// <summary>
        /// isv商户的pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 机构编码，一般为税号
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 支付宝账号唯一id
        /// </summary>
        [XmlArray("uid_list")]
        [XmlArrayItem("string")]
        public List<string> UidList { get; set; }
    }
}
