using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicExplanationPoint Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicExplanationPoint : AopObject
    {
        /// <summary>
        /// 景点语音讲解的讲解时长，单位秒（s）。
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 该语音讲解的讲解人信息。
        /// </summary>
        [XmlElement("explainer")]
        public string Explainer { get; set; }

        /// <summary>
        /// 如该景点包含多个子讲解点（如博物馆某展馆下的多个藏品），传入自讲解点名称列表。
        /// </summary>
        [XmlArray("explainer_points")]
        [XmlArrayItem("string")]
        public List<string> ExplainerPoints { get; set; }

        /// <summary>
        /// 景区内景点的详细经纬度信息。
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 景区内景点的详细经纬度信息。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商户（或ISV）系统内的景点id。
        /// </summary>
        [XmlElement("point_id")]
        public string PointId { get; set; }

        /// <summary>
        /// 景区内景点的详细名称。
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 该语音讲解售价，如免费则不传。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 景点故事的文字描述。
        /// </summary>
        [XmlElement("story")]
        public string Story { get; set; }
    }
}
