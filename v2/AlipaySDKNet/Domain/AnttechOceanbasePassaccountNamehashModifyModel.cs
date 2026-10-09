using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountNamehashModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountNamehashModifyModel : AopObject
    {
        /// <summary>
        /// 账号id数组
        /// </summary>
        [XmlArray("pass_account_id_list")]
        [XmlArrayItem("string")]
        public List<string> PassAccountIdList { get; set; }

        /// <summary>
        /// 预校验
        /// </summary>
        [XmlElement("precheck")]
        public bool Precheck { get; set; }

        /// <summary>
        /// hash值
        /// </summary>
        [XmlElement("snapshot_token")]
        public string SnapshotToken { get; set; }
    }
}
