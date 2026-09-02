using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinauctionApplystatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinauctionApplystatusQueryModel : AopObject
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 外部订单号（阿里拍卖单号）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
