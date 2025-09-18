using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourOrderSyncFailureDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TourOrderSyncFailureDetail : AopObject
    {
        /// <summary>
        /// 该参数含义为描述订单同步失败的原因。当发生某些参数异常时或者系统异常时，会返回该错误信息提示。
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 外部订单号。当订单同步接口系统遇到无法处理的异常或者参数异常时，会将该同步失败的订单信息进行返回。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
