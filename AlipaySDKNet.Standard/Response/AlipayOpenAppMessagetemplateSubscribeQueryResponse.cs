using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppMessagetemplateSubscribeQueryResponse.
    /// </summary>
    public class AlipayOpenAppMessagetemplateSubscribeQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否显示订阅组件。枚举值： true：显示订阅组件。 false：不显示订阅组件
        /// </summary>
        [XmlElement("show_component")]
        public bool ShowComponent { get; set; }

        /// <summary>
        /// 用户对消息模板的订阅关系列表，为入参中的用户id对消息模板id的订阅关系。 限制：用户未订阅消息，该参数不返回。
        /// </summary>
        [XmlArray("subscribe_relations")]
        [XmlArrayItem("subscribe_relation")]
        public List<SubscribeRelation> SubscribeRelations { get; set; }
    }
}
