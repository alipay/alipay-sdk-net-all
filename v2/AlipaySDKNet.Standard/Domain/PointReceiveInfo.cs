using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PointReceiveInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PointReceiveInfo : AopObject
    {
        /// <summary>
        /// 处理结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 领取积分数量
        /// </summary>
        [XmlElement("received_point_amount")]
        public long ReceivedPointAmount { get; set; }

        /// <summary>
        /// 领取结果,true:成功，false:失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
