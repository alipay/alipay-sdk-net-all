using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemMainBodyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemMainBodyRequest : AopObject
    {
        /// <summary>
        /// * 如果用印坐标未知，可根据关键字及出现的次序计算用印座标。 则：传入关键字及出现次序，axisX，axisY无需传入，内部会计算出对应的值,覆盖外部传入的axisX，axisY 如果已知用印坐标，直接传入axisX，axisY。  则：(axisX，axisY)附近根据locationType，rotateAngle用印
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键字类型 1:"当前页" 2:"所有页"
        /// </summary>
        [XmlElement("key_word_type")]
        public long KeyWordType { get; set; }

        /// <summary>
        /// 当传入关键字时，kwIndex不能为空，从1开始，表示第一个命中的关键字 为-1时，表示命中的最后一个关键字
        /// </summary>
        [XmlElement("kw_index")]
        public long KwIndex { get; set; }

        /// <summary>
        /// 正文章模式 [{"KEY_WORD", "关键字模式"},{"ABSOLUTE_POSITION", "绝对坐标模式"}]
        /// </summary>
        [XmlElement("main_body_model")]
        public string MainBodyModel { get; set; }

        /// <summary>
        /// 签署页码
        /// </summary>
        [XmlElement("pos_page")]
        public long PosPage { get; set; }

        /// <summary>
        /// 签署区位置横坐标
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }
    }
}
