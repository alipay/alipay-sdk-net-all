using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicGroupModifyModel : AopObject
    {
        /// <summary>
        /// 分组ID，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 标签规则，满足该规则的粉丝将被圈定，标签id不能重复
        /// </summary>
        [XmlArray("label_rule")]
        [XmlArrayItem("complex_label_rule")]
        public List<ComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 分组名称，仅支持中文、字母、数字、下划线的组合。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
