using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RiskInfoDetail : AopObject
    {
        /// <summary>
        /// 命中词
        /// </summary>
        [XmlElement("hit_word")]
        public string HitWord { get; set; }

        /// <summary>
        /// 命中文字坐标,文字中第几个字到第几个字
        /// </summary>
        [XmlElement("hit_word_index")]
        public string HitWordIndex { get; set; }

        /// <summary>
        /// 数组中8个数字分别代表左上、右上、右下、左下的坐标信息
        /// </summary>
        [XmlElement("new_picture_frame")]
        public string NewPictureFrame { get; set; }

        /// <summary>
        /// 图片画框 左上/右下坐标 以左下角为基准点
        /// </summary>
        [XmlElement("picture_frame")]
        public string PictureFrame { get; set; }
    }
}
