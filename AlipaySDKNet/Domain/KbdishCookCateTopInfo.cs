using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishCookCateTopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishCookCateTopInfo : AopObject
    {
        /// <summary>
        /// 口碑类目id
        /// </summary>
        [XmlElement("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 操作类型 top：置顶 cancelTop：取消置顶
        /// </summary>
        [XmlElement("oper_type")]
        public string OperType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
