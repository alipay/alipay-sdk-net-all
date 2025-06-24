using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourOrderSyncResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TourOrderSyncResponse : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 入库业务号
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
