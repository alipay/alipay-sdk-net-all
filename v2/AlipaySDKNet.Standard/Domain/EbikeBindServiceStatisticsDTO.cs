using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbikeBindServiceStatisticsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EbikeBindServiceStatisticsDTO : AopObject
    {
        /// <summary>
        /// 用户年龄段
        /// </summary>
        [XmlElement("age_flag")]
        public string AgeFlag { get; set; }

        /// <summary>
        /// 阵地绑车用户数
        /// </summary>
        [XmlElement("bind_user_cnt")]
        public long BindUserCnt { get; set; }

        /// <summary>
        /// 充电服务点击uv
        /// </summary>
        [XmlElement("charge_uv")]
        public long ChargeUv { get; set; }

        /// <summary>
        /// 换电服务点击uv
        /// </summary>
        [XmlElement("exchange_uv")]
        public long ExchangeUv { get; set; }

        /// <summary>
        /// 领取绿色能量点击uv
        /// </summary>
        [XmlElement("green_energy_uv")]
        public long GreenEnergyUv { get; set; }

        /// <summary>
        /// 用户职业
        /// </summary>
        [XmlElement("occupation")]
        public string Occupation { get; set; }

        /// <summary>
        /// 租电动车点击uv
        /// </summary>
        [XmlElement("rent_car_uv")]
        public long RentCarUv { get; set; }

        /// <summary>
        /// 场景活跃用户数
        /// </summary>
        [XmlElement("scene_vst_uv")]
        public long SceneVstUv { get; set; }

        /// <summary>
        /// 服务点击总用户数
        /// </summary>
        [XmlElement("service_uv")]
        public long ServiceUv { get; set; }

        /// <summary>
        /// 值为：F/M/未知 F：女；M：男；未知：未知
        /// </summary>
        [XmlElement("user_gender")]
        public string UserGender { get; set; }
    }
}
