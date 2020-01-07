using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceKidsAccountConsultResponse.
    /// </summary>
    public class AlipayCommerceKidsAccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否满足开户条件
        /// </summary>
        [XmlElement("can_open")]
        public bool CanOpen { get; set; }

        /// <summary>
        /// 小宝账户信息模型，包含儿童业务id等字段
        /// </summary>
        [XmlElement("child_info")]
        public ChildCertInfo ChildInfo { get; set; }

        /// <summary>
        /// 下一步跳转url
        /// </summary>
        [XmlElement("next_url")]
        public NextUrl NextUrl { get; set; }

        /// <summary>
        /// 关系数量上限
        /// </summary>
        [XmlElement("relation_limit")]
        public long RelationLimit { get; set; }

        /// <summary>
        /// 亲子关系列表，获取家长关联的所有孩子的列表
        /// </summary>
        [XmlArray("relation_list")]
        [XmlArrayItem("relation_v_o")]
        public List<RelationVO> RelationList { get; set; }
    }
}
