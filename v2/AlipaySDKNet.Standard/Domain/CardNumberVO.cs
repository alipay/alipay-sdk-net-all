using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardNumberVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardNumberVO : AopObject
    {
        /// <summary>
        /// 福卡模板ID，即福卡类型
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 用户持有该类型的福卡数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 福卡名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 卡槽小图彩色
        /// </summary>
        [XmlElement("pi_url")]
        public string PiUrl { get; set; }

        /// <summary>
        /// 卡槽小图灰色
        /// </summary>
        [XmlElement("pi_url_dis")]
        public string PiUrlDis { get; set; }

        /// <summary>
        /// 默认选中的福卡数量
        /// </summary>
        [XmlElement("selected_count")]
        public long SelectedCount { get; set; }

        /// <summary>
        /// 卡槽序列
        /// </summary>
        [XmlElement("serial")]
        public long Serial { get; set; }
    }
}
