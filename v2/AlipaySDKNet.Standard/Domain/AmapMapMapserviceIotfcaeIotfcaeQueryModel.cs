using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmapMapMapserviceIotfcaeIotfcaeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AmapMapMapserviceIotfcaeIotfcaeQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// V型的级别是都是废话是的发布v
        /// </summary>
        [XmlElement("client_version")]
        public string ClientVersion { get; set; }

        /// <summary>
        /// dsgsdgfs
        /// </summary>
        [XmlArray("skin_id_list")]
        [XmlArrayItem("string")]
        public List<string> SkinIdList { get; set; }

        /// <summary>
        /// 是看见的深V恐惧时代华府是东方红是u
        /// </summary>
        [XmlArray("tips_collect_rate")]
        [XmlArrayItem("string")]
        public List<string> TipsCollectRate { get; set; }

        /// <summary>
        /// 打算过和女的方式给对方
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
