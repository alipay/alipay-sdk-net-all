using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboCarControlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboCarControlInfo : AopObject
    {
        /// <summary>
        /// 空调信息
        /// </summary>
        [XmlElement("air_conditioner")]
        public RoboAirConditionerInfo AirConditioner { get; set; }

        /// <summary>
        /// 车窗信息
        /// </summary>
        [XmlElement("car_window")]
        public RoboCarWindowInfo CarWindow { get; set; }

        /// <summary>
        /// 车前灯信息
        /// </summary>
        [XmlElement("front_light")]
        public RoboFrontLightInfo FrontLight { get; set; }

        /// <summary>
        /// 座椅加热信息
        /// </summary>
        [XmlElement("seat_heating")]
        public RoboSeatHeatingInfo SeatHeating { get; set; }

        /// <summary>
        /// 迎宾灯信息
        /// </summary>
        [XmlElement("welcome_light")]
        public RoboWelcomeLightInfo WelcomeLight { get; set; }

        /// <summary>
        /// 鸣笛信息
        /// </summary>
        [XmlElement("whistle")]
        public RoboWhistleInfo Whistle { get; set; }
    }
}
