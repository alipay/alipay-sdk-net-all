using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FsAuthorizationInfoForm Data Structure.
    /// </summary>
    [Serializable]
    public class FsAuthorizationInfoForm : AopObject
    {
        /// <summary>
        /// 授权业务域：券
        /// </summary>
        [XmlArray("authorized_domains")]
        [XmlArrayItem("string")]
        public List<string> AuthorizedDomains { get; set; }

        /// <summary>
        /// 授权用户集合
        /// </summary>
        [XmlArray("authorized_users")]
        [XmlArrayItem("string")]
        public List<string> AuthorizedUsers { get; set; }
    }
}
