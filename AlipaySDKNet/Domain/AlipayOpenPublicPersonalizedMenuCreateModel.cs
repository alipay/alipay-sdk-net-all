using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPersonalizedMenuCreateModel : AopObject
    {
        /// <summary>
        /// 一级菜单列表。如果是文本菜单，最多有3个一级菜单，最多5个二级菜单；如果是 ICON 菜单信息，最多有80个一级菜单，ICON菜单不支持二级菜单
        /// </summary>
        [XmlArray("button")]
        [XmlArrayItem("button_object")]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 人群分组id。人群分组与标签规则不能同时为空
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 标签规则，目前限定只能传入1条，在个性化菜单创建成功后，满足该标签规则的用户进入生活号首页，将看到该套菜单。人群分组ID与标签规则不能同时为空
        /// </summary>
        [XmlArray("label_rule")]
        [XmlArrayItem("label_rule")]
        public List<LabelRule> LabelRule { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,不填为不区分机型
        /// </summary>
        [XmlElement("mobile_client_type")]
        public string MobileClientType { get; set; }

        /// <summary>
        /// 菜单类型，支持值为icon：icon型菜单，text：文本型菜单，不传时默认为"text"，当传值为"icon"时，菜单节点的icon字段必传。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
