using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CaSystemMainBody Data Structure.
    /// </summary>
    [Serializable]
    public class CaSystemMainBody : AopObject
    {
        /// <summary>
        /// 只有自动签署时支持加盖日期组件
        /// </summary>
        [XmlElement("date_tabs")]
        public DateTabs DateTabs { get; set; }

        /// <summary>
        /// 关键字，mainBodyModel为KEY_WORD时必填
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键字类型，mainBodyModel为KEY_WORD时必填（1-当前页；2-所有页）
        /// </summary>
        [XmlElement("key_word_type")]
        public long KeyWordType { get; set; }

        /// <summary>
        /// 第几个关键字，mainBodyModel为KEY_WORD时必填
        /// </summary>
        [XmlElement("kw_index")]
        public long KwIndex { get; set; }

        /// <summary>
        /// x偏移量，单位点（point）
        /// </summary>
        [XmlElement("kw_shift_x")]
        public long KwShiftX { get; set; }

        /// <summary>
        /// y偏移量，单位点（point）
        /// </summary>
        [XmlElement("kw_shift_y")]
        public long KwShiftY { get; set; }

        /// <summary>
        /// 正文章模式
        /// </summary>
        [XmlElement("main_body_model")]
        public string MainBodyModel { get; set; }

        /// <summary>
        /// 签署页码
        /// </summary>
        [XmlElement("pos_page")]
        public long PosPage { get; set; }

        /// <summary>
        /// 签署区位置横坐标，mainBodyModel为ABSOLUTE_POSITION时必填，单位点（point）
        /// </summary>
        [XmlElement("pos_x")]
        public long PosX { get; set; }

        /// <summary>
        /// 签署区位置纵坐标，mainBodyModel为ABSOLUTE_POSITION时必填，单位点（point）
        /// </summary>
        [XmlElement("pos_y")]
        public long PosY { get; set; }
    }
}
