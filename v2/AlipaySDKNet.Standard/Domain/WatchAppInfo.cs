using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WatchAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WatchAppInfo : AopObject
    {
        /// <summary>
        /// pocketMoney：手表零花钱
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 0:不显示，1:待关联，10:未开通，20:待激活，30:余额不足，40:去管理
        /// </summary>
        [XmlElement("app_status_code")]
        public string AppStatusCode { get; set; }

        /// <summary>
        /// 0:不显示，1:待关联，10:未开通，20:待激活，30:余额不足，40:去管理
        /// </summary>
        [XmlElement("app_status_desc")]
        public string AppStatusDesc { get; set; }
    }
}
