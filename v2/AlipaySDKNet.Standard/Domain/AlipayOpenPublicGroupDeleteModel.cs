using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicGroupDeleteModel : AopObject
    {
        /// <summary>
        /// 分组ID，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
