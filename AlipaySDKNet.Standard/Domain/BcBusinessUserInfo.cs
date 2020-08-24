using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BcBusinessUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BcBusinessUserInfo : AopObject
    {
        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的头像地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的用户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// BC互动，B端实体对应的实际B端操作人员的用户帐号id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
