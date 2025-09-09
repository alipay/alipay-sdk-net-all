using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPromoteChannelVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPromoteChannelVO : AopObject
    {
        /// <summary>
        /// true表达可以删除，false表达不可以删除，正常是官方定义的渠道不能删除，自定义渠道可以删除
        /// </summary>
        [XmlElement("delete_tag")]
        public bool DeleteTag { get; set; }

        /// <summary>
        /// 渠道说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 渠道id标识，唯一标识某个渠道
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 渠道参数（英文标识），允许数字字母和下划线
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 渠道名称，渠道中文描述
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户加入群聊的地址信息
        /// </summary>
        [XmlElement("promote_link")]
        public string PromoteLink { get; set; }
    }
}
