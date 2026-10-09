using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamematerialDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamematerialDataSyncModel : AopObject
    {
        /// <summary>
        /// 素材点击次数
        /// </summary>
        [XmlElement("click_pv")]
        public long ClickPv { get; set; }

        /// <summary>
        /// 素材点击用户数
        /// </summary>
        [XmlElement("click_uv")]
        public long ClickUv { get; set; }

        /// <summary>
        /// 素材效果数据的统计时间，以日期为维度更新数据。
        /// </summary>
        [XmlElement("data_time")]
        public string DataTime { get; set; }

        /// <summary>
        /// 素材曝光次数
        /// </summary>
        [XmlElement("expose_pv")]
        public long ExposePv { get; set; }

        /// <summary>
        /// 素材曝光用户数
        /// </summary>
        [XmlElement("expose_uv")]
        public long ExposeUv { get; set; }

        /// <summary>
        /// 效果数据对应的素材 ID，素材ID由平台定义通知CP
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
