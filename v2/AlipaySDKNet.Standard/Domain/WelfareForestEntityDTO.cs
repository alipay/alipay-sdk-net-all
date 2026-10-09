using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareForestEntityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareForestEntityDTO : AopObject
    {
        /// <summary>
        /// 公益林描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 前端展示信息
        /// </summary>
        [XmlElement("display_info")]
        public string DisplayInfo { get; set; }

        /// <summary>
        /// 公益林的icon信息，传递支付宝端使用的icon格式
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 单个公益林id。调浇水接口需要传过来
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 公益林名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 固定浇水66g，可为空，为空时表明改公益林浇水时需要上游传递浇水值
        /// </summary>
        [XmlElement("solid_water_value")]
        public string SolidWaterValue { get; set; }

        /// <summary>
        /// 公益林状态，未开始和已结束表明该公益林无法进行浇水行为
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 公益林标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用于表示该公益林会种植哪些树种
        /// </summary>
        [XmlElement("tree_name")]
        public string TreeName { get; set; }

        /// <summary>
        /// 公益林的类型信息，包含企业，综艺等类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
