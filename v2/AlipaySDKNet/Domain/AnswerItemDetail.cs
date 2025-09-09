using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerItemDetail : AopObject
    {
        /// <summary>
        /// 事项的受理条件
        /// </summary>
        [XmlElement("accept_conditions")]
        public string AcceptConditions { get; set; }

        /// <summary>
        /// 推荐事项的办理指南
        /// </summary>
        [XmlElement("check_list")]
        public string CheckList { get; set; }

        /// <summary>
        /// 推荐事项的id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 推荐事项的办理地址
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 推荐事项的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 机构用户上传到知识库时定义的事项编码。
        /// </summary>
        [XmlElement("service_item_id")]
        public string ServiceItemId { get; set; }
    }
}
