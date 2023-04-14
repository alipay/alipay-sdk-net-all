using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailInstanceTransferResponse.
    /// </summary>
    public class KoubeiRetailInstanceTransferResponse : AopResponse
    {
        /// <summary>
        /// 请求的id信息
        /// </summary>
        [XmlArray("instance_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstanceIdList { get; set; }
    }
}
