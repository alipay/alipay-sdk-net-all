using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HouseMode Data Structure.
    /// </summary>
    [Serializable]
    public class HouseMode : AopObject
    {
        /// <summary>
        /// 厨房数量
        /// </summary>
        [XmlElement("cook_num")]
        public long CookNum { get; set; }

        /// <summary>
        /// 户型描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 月租金，单位元
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 建筑面积，单位平方米
        /// </summary>
        [XmlElement("floorage")]
        public string Floorage { get; set; }

        /// <summary>
        /// 厅数量，客厅餐厅等
        /// </summary>
        [XmlElement("hall_num")]
        public long HallNum { get; set; }

        /// <summary>
        /// 户型图，使用的是文件上传的fileId
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 卧室数量
        /// </summary>
        [XmlElement("room_num")]
        public long RoomNum { get; set; }

        /// <summary>
        /// 卫生间数量
        /// </summary>
        [XmlElement("toilet_num")]
        public long ToiletNum { get; set; }
    }
}
