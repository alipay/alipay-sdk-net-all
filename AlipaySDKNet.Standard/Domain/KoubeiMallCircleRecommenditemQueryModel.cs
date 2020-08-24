using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMallCircleRecommenditemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallCircleRecommenditemQueryModel : AopObject
    {
        /// <summary>
        /// 口碑城市编码（示例：杭州市330100）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 身份ID，识别合作方身份（可联系口碑综合体业务获取）
        /// </summary>
        [XmlElement("data_set_id")]
        public string DataSetId { get; set; }

        /// <summary>
        /// 展示渠道：ALIPAY_APP KOUBEI_APP TAOBAO_APP（默认ALIPAY_APP）
        /// </summary>
        [XmlElement("display_channel")]
        public string DisplayChannel { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 每页查询量，默认为10，每页最大查询量不能超过50，最小查询量不能低于1
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询起始值，默认为0
        /// </summary>
        [XmlElement("start")]
        public long Start { get; set; }

        /// <summary>
        /// 终端设备描述(中、英文均可)
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }

        /// <summary>
        /// 生活圈ID；参数不为空，表明指定是生活圈
        /// </summary>
        [XmlElement("tribe_id")]
        public string TribeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
