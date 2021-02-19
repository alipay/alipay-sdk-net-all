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
        /// true:显示订阅组件，false:不显示订阅组件
        /// </summary>
        [XmlElement("show_component")]
        public bool ShowComponent { get; set; }

        /// <summary>
        /// 用户对消息模板的订阅关系列表，为入参中的用户id对消息模板id的订阅关系
        /// </summary>
        [XmlArray("subscribe_relations")]
        [XmlArrayItem("subscribe_relation")]
        public List<SubscribeRelation> SubscribeRelations { get; set; }
    }
}
