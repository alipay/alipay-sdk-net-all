using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceFeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceFeeQueryModel : AopObject
    {
        /// <summary>
        /// 请传入certify_id列表。
        /// </summary>
        [XmlArray("certify_id_list")]
        [XmlArrayItem("string")]
        public List<string> CertifyIdList { get; set; }
    }
}
