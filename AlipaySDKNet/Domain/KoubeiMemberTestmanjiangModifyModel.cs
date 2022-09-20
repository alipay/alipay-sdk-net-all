using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberTestmanjiangModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberTestmanjiangModifyModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("json_test")]
        public string JsonTest { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss_uid")]
        public string SssUid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss_uid_openid")]
        public string SssUidOpenid { get; set; }
    }
}
