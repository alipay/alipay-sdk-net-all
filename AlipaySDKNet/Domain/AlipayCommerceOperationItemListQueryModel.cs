using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationItemListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationItemListQueryModel : AopObject
    {
        /// <summary>
        /// 需要绑定的门店对映的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 店员id，点击提交的收银员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
