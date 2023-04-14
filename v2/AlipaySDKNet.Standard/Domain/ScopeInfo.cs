using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScopeInfo : AopObject
    {
        /// <summary>
        /// 圆形范围半径（单位公里），type为CIRCULAR时必填
        /// </summary>
        [XmlElement("circular_area")]
        public string CircularArea { get; set; }

        /// <summary>
        /// 多边形范围，type为POLYGON时必填;["lon1;lat1","lon2;lat2","lon3;lat3"] 3个点<=每个多边形<10 ""中是多边形中的点，  ;分隔经纬度，
        /// </summary>
        [XmlArray("polygon_area")]
        [XmlArrayItem("string")]
        public List<string> PolygonArea { get; set; }

        /// <summary>
        /// 枚举： NO_RESTRICTIONS：表示没有下单距离限制 POLYGON：表示限制下单范围由多边形组成 CIRCULAR：表示限制下单范围由圆形组成
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
