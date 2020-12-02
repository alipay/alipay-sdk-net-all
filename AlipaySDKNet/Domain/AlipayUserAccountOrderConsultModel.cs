using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountOrderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountOrderConsultModel : AopObject
    {
        /// <summary>
        /// 集团havana ID
        /// </summary>
        [XmlElement("hid")]
        public string Hid { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
