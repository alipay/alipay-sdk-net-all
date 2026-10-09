using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceBroadcastQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceBroadcastQueryResponse : AopResponse
    {
        /// <summary>
        /// 播报时间,单位为秒. 如果没有播报,则返回空字符串
        /// </summary>
        [XmlElement("broadcast_time")]
        public string BroadcastTime { get; set; }

        /// <summary>
        /// 播报结果. true表示播报成功,false表示未播报. 注意:播报结果的查询可能有一定延迟,延迟时间为5s-1min左右; 并且播报结果只能查询最近1周内的数据.
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
