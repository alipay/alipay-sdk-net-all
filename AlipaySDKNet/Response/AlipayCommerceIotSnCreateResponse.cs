using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSnCreateResponse.
    /// </summary>
    public class AlipayCommerceIotSnCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单id，用于后续追踪或查询该批次的设备sn
        /// </summary>
        [XmlElement("apply_id")]
        public long ApplyId { get; set; }

        /// <summary>
        /// 生成的sn列表
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }
    }
}
