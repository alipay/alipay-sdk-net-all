using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandBusinessAppidpidBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBusinessAppidpidBindModel : AopObject
    {
        /// <summary>
        /// 小程序id，用于绑定的收单账号的小程序id
        /// </summary>
        [XmlElement("app_id_bind")]
        public string AppIdBind { get; set; }

        /// <summary>
        /// 被绑定的收单账号pid
        /// </summary>
        [XmlElement("pid_bind")]
        public string PidBind { get; set; }
    }
}
