using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeitemQueryModel : AopObject
    {
        /// <summary>
        /// 推荐上下文
        /// </summary>
        [XmlElement("context")]
        public ApeRecContext Context { get; set; }

        /// <summary>
        /// 待推荐候选集itemId列表，用于调用方指定推荐item的范围，推荐接口将对传入的item进行打分，可为空。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户唯一标识id，支付宝的用户填写支付宝的用户id。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
